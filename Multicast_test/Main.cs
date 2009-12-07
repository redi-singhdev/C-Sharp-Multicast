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
			
			string file = "/home/adam/Desktop/british-english";
			Controller control = new Controller("224.1.1.1", 9001);
			
			if (false){
				control.SetReadFile(file);
				if (false){
					while (true){
						Thread.Sleep(500);
						control.SendFileInfo();
					}
				}else{
					control.StartSending();
					while(true){
						Thread.Sleep(500);
						control.SendChecker();
					}
				}
			}else{
				control.SetWriteFile(file, 26000000);
				while (true){
					Thread.Sleep(500);
					control.ReceiveChecker();
					
				}
			}
			
			
		}
		
	}
}
