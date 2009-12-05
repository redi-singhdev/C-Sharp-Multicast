
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
		
		
		public FileStreamer(string file_to_read)
		{
			writing = false;
			path = file_to_read;
			fs = File.OpenRead(path);
			position = 0;
		}
			
		
		public byte[] GetNextChunk(){
			
			
			byte[] b = new byte[1024];
			UTF8Encoding temp = new UTF8Encoding(true);
			if (fs.Read(b,0,b.Length) >0 ){
				position += 1;
				return b;
			}
			return null;
		}
		
		public FilePiece GetNextPiece(){
			
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
			
		}
		
		
		public double GetPercent(){
			//return (double)position/(double)File SIZE
			return 1.0;
		}
		
		
	}
}
