using System;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Threading;


namespace Multicast_test
{
	class MainClass
	{
		

		public static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
			System.Threading.Thread.Sleep(1000); // give time for the receive to set up
			
			byte[] b = new byte[(20)];
			for (int i = 0; i < b.Length; i++){
				b[i] = (byte)(i+65);
			}
			System.Threading.Thread.Sleep(1000); // give time for the send to actually send and recieve to get it
		}
		
	}
}
