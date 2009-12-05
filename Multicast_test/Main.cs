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
			Thread Receive = new Thread(new ThreadStart(receive));
			Receive.IsBackground = true;
			
			Receive.Start();
			System.Threading.Thread.Sleep(1000);
			send();
			System.Threading.Thread.Sleep(1000);
		}
		
		
		static void send()
		{
			
			try{
				IPAddress ip = IPAddress.Parse("224.1.1.0");
				int port = 1337;
				
				
				// create a socket that will send over UDP
				Socket s=new Socket(AddressFamily.InterNetwork,
				                    SocketType.Dgram, ProtocolType.Udp);
				
				// this is the "multicast room" in terms of op and port
				IPEndPoint ipep = new IPEndPoint(ip, port);
				
				
				// tell the sockets object to connect to the "room" ( nothing actually happens )
				s.Connect(ipep);
				
				
				byte[] b = new byte[(20)];
				for (int i = 0; i < b.Length; i++){
					b[i] = (byte)(i+65);
				}
				
				// send the char array "b" without any special socket flags
				s.Send(b,b.Length,SocketFlags.None);
				
				Console.WriteLine("Message sent");
				s.Close();
				
			}catch(System.Net.Sockets.SocketException e) {
				// this will spit out errors if there's a problem with any of the previous code
				Console.Error.WriteLine(e.Message);
				Console.Error.WriteLine(e.GetBaseException());
				Console.Error.WriteLine(e.ErrorCode);
			}
		}
		
		
		static void receive()
		{
			try{
				IPAddress ip = IPAddress.Parse("224.1.1.0");
				int port = 1337;
				
				
				Socket s=new Socket(AddressFamily.InterNetwork,
				                    SocketType.Dgram, ProtocolType.Udp);
				
				// create a "multicast room" that will listen for anything from anyone but only on the specified port
				IPEndPoint ipep = new IPEndPoint(IPAddress.Any, port);
				
				// allow us to listen to sockets being used for transmission (local loopback)
				s.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, 1);
				
				// tell the multicast object to bind to the "multicast room" 
				s.Bind(ipep);
				
				// receive all multicast packets (TTL is how many routers the packet can go through)
				s.SetSocketOption(SocketOptionLevel.IP, SocketOptionName.MulticastTimeToLive, 0); 
				
				// tell the "multicast room" that you're listening for anything
				s.SetSocketOption(SocketOptionLevel.IP, SocketOptionName.AddMembership, new MulticastOption(ip));
				
				
				
				
				 while(true) { 
					byte[] b=new byte[20];
					Console.WriteLine("Waiting for data..");
					
					// receive up to 20 bytes
					s.Receive(b);
					string str = System.Text.Encoding.ASCII.GetString(b,0,b.Length);
					Console.WriteLine("Received: " + str.Trim());
				}
				
				
				//s.Close();
				
			}catch(System.Net.Sockets.SocketException e) {
				Console.Error.WriteLine(e.Message);
				Console.Error.WriteLine(e.GetBaseException());
				Console.Error.WriteLine(e.ErrorCode);
			}
		}
		
	}
}
