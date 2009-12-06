
using System;
using System.IO;
using System.Text;

namespace Multicast_test
{
	
	
	public class FileStreamer
	{
		string path;
		FileStream fs;
		Int64 position;
		Boolean writing;
		Int64 expected_size;
		
		public bool GetFileStatus(){
			return (position >= expected_size);
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
		
		public FileStreamer(string file_to_write, Int64 size){
			// warning: overwrites by default
			writing = true;
			path = file_to_write;
			FileInfo fi = new FileInfo(path);
			if (fi.Exists){
				fi.Delete();
			}
			expected_size = size;
			fs = File.OpenWrite(path);
			position = 0;
			
		}
		
		public byte[] GetNextChunk(){
			if (writing){
				// polymorphism in action!
				return null;
			}
			byte[] b = new byte[1024];
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
			
		}
		
		
		public double GetPercent(){
			if (expected_size <= 0){
				return (double)0;
			}
			return (double)position/(double)expected_size;
		}
		
		
	}
}
