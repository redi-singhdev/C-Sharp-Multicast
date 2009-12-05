
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
		
	
	}
}
