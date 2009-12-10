using System;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Threading;
using System.Collections.Generic;
using System.Collections;



namespace Multicast_test
{
	class MainClass
	{
		
		public static string ip;
		public static int port;
		public enum possible {sendinfo, receiveinfo, sendfile, receivefile, nothing};
		public enum expecting {file, ip, port, ip_port, nothing};
		
		public static void Main(string[] args)
		{
			
			ip = "224.1.1.1"; // default
			port = 9001; // default
			
			
			string file = "";
			
			
			possible happening = possible.nothing;
			expecting what = expecting.nothing;
			
			foreach (string arg in args)
			{
				if (what == expecting.nothing){
					switch(arg){
					case "-s":
						goto case "--sendinfo";
					case "--sendinfo":
						happening = possible.sendinfo;
						break;
						
					case "-r":
						goto case "--receiveinfo";
					case "--receiveinfo":
						happening = possible.receiveinfo;
						break;
						
					case "-sf":
						goto case "--sendfile";
					case "--sendfile":
						happening = possible.sendfile;
						break;
						
					case "-rf":
						goto case "--receivefile";
					case "--receivefile":
						happening = possible.receivefile;
						break;
						
					case "-i":
						goto case "--inputfile";
					case "--inputfile":
						what = expecting.file;
						break;
						
					case "-ip":
						goto case "--ip";
					case "--ip":
						what = expecting.ip;
						break;
						
					case "-p":
					case "--port":
						what = expecting.port;
						break;
						
					default:
						file = arg;
						break;
					}
				}else{
					// we're expecting something other than a command line arg
					switch (what){
					case expecting.file:
						file = arg;
						break;
					case expecting.ip:
						ip = arg;
						break;
					case expecting.port:
						if (int.TryParse(arg, out port)){
							Console.Write("Not a port.");
						}
						break;
					case expecting.ip_port:
						int colon = arg.IndexOf(":");
						ip = arg.Substring(0, colon-1);
						if (int.TryParse(arg.Substring(colon+1), out port)){
							Console.Write("Not a port.");
						}
						break;
					default:
					file = arg;
						break;
					}
					
					what = expecting.nothing;
				}
			}
			
			switch (happening){
			case possible.sendinfo:
				SendFileInfo(file);
							break;
			case possible.receiveinfo:
				ReceiveFileInfo();
							break;
			case possible.sendfile:
				SendFile(file);
							break;
			case possible.receivefile:
				ReceiveFile(file);
							break;
			default:
				Console.WriteLine("You didn't tell me what to do.");
							break;
			}
			
			
		}
		
		public static void SendFileInfo(string file){
			
			FileInfo fi = new FileInfo(file);
			if (!fi.Exists){
				Console.WriteLine("File doesn't exist");
				return;
			}
			
			Controller control = new Controller(ip, port);
			control.SetReadFile(file);
			
			
			
			Console.WriteLine("Sending File info...");
			while(true){
				Thread.Sleep(250);
				control.SendFileInfo();
			}
			
		}
		public static void ReceiveFileInfo(){
			
			Controller control = new Controller(ip, port);
			
			
			Console.WriteLine("Receiving file info...");
			while(true){
				Thread.Sleep(2000);
				control.UpdateFilesAvailable();
				List<List<string>> files = control.GetFilesAvailable();
				foreach(List<string> info in files){
					string temp = info[0] + " / " + info[1] + " / " + info[2];
					Console.WriteLine(temp);
				}
			}
			
		}
		public static void SendFile(string file){
			
			FileInfo fi = new FileInfo(file);
			if (!fi.Exists){
				Console.WriteLine("File doesn't exist");
				return;
			}
			
			Controller control = new Controller(ip, port);
			control.SetReadFile(file);
			
			
			
			Console.WriteLine("Sending File info...");
			while(true){
				Thread.Sleep(250);
				if (control.SendChecker()){
					Console.WriteLine("Done Sending");
				}else{
					Console.WriteLine("Sending: " + control.GetPercent());
				}
			}
			
			
		}
		
		public static void ReceiveFile(string file){
			FileInfo fi = new FileInfo(file);
			if (fi.Exists){
				Console.WriteLine("File exist! Overwriting.");
				// TODO: Make it ask
			}
			
			Controller control = new Controller(ip, port);
			control.SetWriteFile(file, 90000);
			while(true){
				Thread.Sleep(250);
				if (control.ReceiveChecker()){
					Console.WriteLine("Done Receiving");
				}else{
					Console.WriteLine("Receiving: " + control.GetPercent());
				}
			}
			
		}
			
		
	}

}
