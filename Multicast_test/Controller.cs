
using System;

namespace Multicast_test
{
	
	
	public class Controller
	{
		FileStreamer file_stream;
		networking network;
		
		
		public Controller(string filename, string ip, int port)
		{
			network = new networking(ip, port);
			// don't init filestreamer yet
		}
		
		public void SetReadFile(String file_name){
			file_stream = new FileStreamer(file_name);
		}
		
		public void SetWriteFile(String file_name){
			
		}
		
		// returns true if streaming started
		public bool StartReceiving(){
			if (file_stream != null){
				return false;
			}
			network.start_receiving();
			return true;
		}
		
		private bool ReceiveChecker(){
			byte[] b;
			
			do{
				b = network.PopReceiveBuffer();
				// we have data in b! Deal with it.
				FilePiece piece = FilePiece.parse_packet(b);
				if (piece != null){
					file_stream.WritePiece(piece);
				}
				
			}while (b != null);
			
			return file_stream.GetFileStatus();
		}
	}
}
