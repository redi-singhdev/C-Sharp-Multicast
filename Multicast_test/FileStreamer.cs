
using System;
using System.IO;
using System.Text;
using System.Collections;

namespace Multicast_test
{
	
	
	public class FileStreamer
	{
		string path;
		FileStream fs;
		Int64 position;
		Boolean writing;
		Int64 expected_size;
		
		Stack received_pieces; // stack of numbers
		
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
			received_pieces = new Stack();
			fs = File.OpenWrite(path);
			position = 0;
			
		}
		
		public Int64 GetExpectedSize(){
			return expected_size;
		}
		
		public byte[] GetFileName(){
			FileInfo fi = new FileInfo(path);
			return Encoding.UTF8.GetBytes(fi.Name.ToString());
		}
		
		public Stack GetRequiredPieces(){
			if (received_pieces.Count > 1){
				object[] objects = received_pieces.ToArray();
				Int64[] sorted_ints = new Int64[objects.Length];
				for (Int64 i = 0; i < sorted_ints.Length; i++){
					sorted_ints[i] = (Int64)objects[i];
				}
				Array.Sort(sorted_ints);
				
				
				Stack required_pieces = new Stack();
				Int64 pos = 0;
				for( Int64 i = sorted_ints[0]; i < sorted_ints[sorted_ints.Length-1] ; i++){
					if (sorted_ints[pos] <= i){
						pos++;
					}else{
						required_pieces.Push(i);
					}
				}
				return required_pieces;
			}
			return null;
			
		}
		
		public byte[] GetSpecificChunk(Int64 number){
			if (writing){
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
				piece = new FilePiece(position, b);
			}else{
				piece = null;
			}
			return piece;
		}
		
		public void WritePiece(FilePiece piece){
			// WARNING: THIS IS FOR TESTING PURPOSES ONLY
			if (!writing){
				// polymorphism in action!
				return;
			}
			fs.Write(piece.data, 0, piece.data.Length);
			// TODO: Use BeginWrite to make it more responsive
		}
		
		public void WriteSpecificPiece(FilePiece piece){
			// NOTE: Requires that all data pieces be EXACTLY data_size in length! (see FilePiece.cs)
			if (!writing){
				// polymorphism in action!
				return;
			}
			
			if (piece.number < 0){
				return;
			}
			
			fs.Seek(piece.number * FilePiece.data_size, SeekOrigin.Begin);
			fs.Write(piece.data, 0, piece.data.Length);
			
			if (received_pieces.Count <= 1 && (Int64)received_pieces.Peek() == piece.number - 1){
				received_pieces.Clear();
				received_pieces.Push(piece.number);
			}else{
				received_pieces.Push(piece.number);
			}
			
		}
		
		
		public double GetPercent(){
			if (expected_size <= 0){
				return (double)0;
			}
			return (double)position/(double)expected_size;
		}
		
		
	}
}
