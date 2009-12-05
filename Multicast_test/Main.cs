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
				
				
				Socket s=new Socket(AddressFamily.InterNetwork,
				                    SocketType.Dgram, ProtocolType.Udp);
				
				IPEndPoint ipep = new IPEndPoint(ip, port);
				
				
				s.Connect(ipep);
				
				
				byte[] b = new byte[(20)];
				for (int i = 0; i < b.Length; i++){
					b[i] = (byte)(i+65);
				}
				
				s.Send(b,b.Length,SocketFlags.None);
				Console.WriteLine("Message sent");
				s.Close();
				
			}catch(System.Net.Sockets.SocketException e) {
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
				
				IPEndPoint ipep = new IPEndPoint(IPAddress.Any, port);
				
				s.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, 1);
				
				s.Bind(ipep);
				
				s.SetSocketOption(SocketOptionLevel.IP, SocketOptionName.MulticastTimeToLive, 0); 
				
				s.SetSocketOption(SocketOptionLevel.IP, SocketOptionName.AddMembership, new MulticastOption(ip));
				
				
				
				
				 while(true) {
					byte[] b=new byte[20];
					Console.WriteLine("Waiting for data..");
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
