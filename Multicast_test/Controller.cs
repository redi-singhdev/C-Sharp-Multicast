
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
		
		private void ReceiveHandler(){
			
			
		}
	}
}
