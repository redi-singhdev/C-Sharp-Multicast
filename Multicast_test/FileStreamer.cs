
using System;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;


namespace Multicast_test
{
	
	
	public class FileStreamer
	{
		string path;
		FileStream fs;
		Int64 position;
		Boolean writing;
		Int64 expected_size;
		
		List<Int64> received_pieces; // List of numbers
		
		public bool GetFileStatus(){
			if ((position >= expected_size) && 
			    ((received_pieces != null) && (received_pieces.Count <= 0))){
				return true;
			}else{
				return false;
			}
		}
		
		public FileStreamer(string file_to_read)
		{
			writing = false;
			path = file_to_read;
			FileInfo fi = new FileInfo(path);
			if (fi.Exists){
				fs = File.OpenRead(path);
				expected_size = fi.Length;
			}else{
				fs = null;
			}
			position = 0;
		}
		
		public bool FileReadReady(){
			return (fs != null);
		}
		
		public FileStreamer(string file_to_write, Int64 size){
			// warning: overwrites by default
			writing = true;
			path = file_to_write;
			FileInfo fi = new FileInfo(path);
			if (fi.Exists){
				fi.Delete();
			}
			expected_size = size;
			received_pieces = new List<Int64>(1);
			received_pieces.Add(-1);
			fs = File.OpenWrite(path);
			position = 0;
			
		}
		
		public Int64 GetExpectedSize(){
			return expected_size;
		}
		
		public byte[] GetFileName(){
			FileInfo fi = new FileInfo(path);
			return Encoding.UTF8.GetBytes(fi.Name.Normalize());
		}
		
		public List<Int64> GetRequiredPieces(){
			if (received_pieces.Count > 1){
				Console.WriteLine("We know we're missing packets:" + received_pieces.Count);
				received_pieces.Sort();
				List<Int64> required_pieces = new List<Int64>();
				int pos = 0;
				for( Int64 i = received_pieces[0]; i < received_pieces[received_pieces.Count-1] ; i++){
					if (received_pieces[pos] <= i){
						pos++;
					}else{
						if (i >0){
							required_pieces.Add(i);
						}
					}
				}
				return required_pieces;
			}
			return null;
			
		}
		
		public byte[] GetSpecificChunk(Int64 number){
			if (writing || number < 0){
				// polymorphism in action!
				return null;
			}
			byte[] b = new byte[FilePiece.data_size];
			long cur_position = fs.Position;
			fs.Seek(number * FilePiece.data_size, SeekOrigin.Begin);
			
			if (fs.Read(b,0,b.Length) <=0 ){
				b = null;
			}
			fs.Seek(cur_position, SeekOrigin.Begin);
			return b;
			
		}
		
		
		
		public byte[] GetNextChunk(){
			if (writing){
				// polymorphism in action!
				return null;
			}
			byte[] b = new byte[FilePiece.data_size];
			if (fs.Read(b,0,b.Length) >0 ){
				position += 1;
				return b;
			}
			return null;
		}
		
		public FilePiece GetNextPiece(){
			if (writing){
				// polymorphism in action!
				return null;
			}
			
			byte[] b = GetNextChunk();
			FilePiece piece;
			if (b != null){
				piece = new FilePiece(fs.Position/FilePiece.data_size -1, b);
			}else{
				piece = null;
			}
			return piece;
		}
		
		
		public void WriteSpecificPiece(FilePiece piece){
			// NOTE: Requires that all data pieces be EXACTLY data_size in length! (see FilePiece.cs)
			if (!writing){
				// polymorphism in action!
				Console.WriteLine("We're not writing. Don't call this function!");
				return;
			}
			
			if (piece.number < 0){
				Console.WriteLine("Don't tell us to write a non-existant piece.");
				return;
			}
			
			fs.Seek(piece.number * FilePiece.data_size, SeekOrigin.Begin);
			fs.Write(piece.get_data(), 0, piece.data.Length);
			
			received_pieces.Sort();
			
			if (received_pieces.Count <= 1 && received_pieces[0].Equals(piece.number - 1)){
				received_pieces.Clear();
				received_pieces.Add(piece.number);
			}else{
				if (received_pieces.Contains(piece.number)){
					Console.WriteLine("Detected Duplicate packet");
					received_pieces.Remove(piece.number);
				}else{
					received_pieces.Add(piece.number);
				}
			}
			
		}
		
		
		public double GetPercent(){
			if (expected_size <= 0){
				return (double)0;
			}
			if (fs.Position >= expected_size){
				return (double)1;
			}
			return (double)fs.Position/(double)expected_size;
		}
		
		
	}
}
