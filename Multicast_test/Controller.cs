
using System;
using System.Collections;
using System.Text;
using System.Collections.Generic;

namespace Multicast_test
{
	public struct files_available{
		public string user_name;
		public string file_name;
		public Int64 file_size;
		public DateTime updated;
	}
	
	public class Controller
	{
		FileStreamer file_stream;
		networking network;
		
		String user_name;
		List<files_available> files_available;
		
		// statistics
		Int64 bytes_sent;
		Int64 bytes_received;
		Int64 packets_error;
		DateTime start_time;
		
		double sending_speed; // bytes/second
		
		// constants
		const double starting_speed = 2048.0;
		const double change_without_error_increase = 1.05;
		const double change_with_error_decrease = 0.90;
		
		const double MAX_AGE_FILES = 5;
		
		const Int64 MESSAGE_RESEND = -1;
		const Int64 MESSAGE_FILEINFO = -2;
		
		
		
		public Controller(string ip, int port)
		{
			network = new networking(ip, port);
			reset_stats();
			
			user_name = "";
			files_available = new List<files_available>();
			// don't init filestreamer yet
		}
		
		public void reset_stats(){
			bytes_received = 0;
			bytes_sent = 0;
			packets_error = 0;
			sending_speed = starting_speed;
			files_available = new List<files_available>();
		}
		
		public double[] GetStats(){
			double [] stats = {bytes_received, bytes_sent, packets_error, sending_speed};
			return stats;
		}
		
		public bool SetReadFile(String file_name){
			file_stream = new FileStreamer(file_name);
			return (file_stream.FileReadReady());
		}
		
		public void SendFileInfo(){
			if (file_stream == null){
				return;
			}
			byte[] b = new byte[FilePiece.data_size];
			
			file_stream.GetFileName().CopyTo(b, 0);
			System.BitConverter.GetBytes(file_stream.GetExpectedSize()).CopyTo(b, 255);
			new UnicodeEncoding().GetBytes(user_name).CopyTo(b, 255+8);
			
			FilePiece piece = new FilePiece(MESSAGE_FILEINFO , b);
			
			network.send(piece.get_packet());
		}
		
		public List<List<string>> GetFilesAvailable(){
			// uses the files_available array to make an array of files available
			
			List<files_available> files = new List<files_available>();
			files.AddRange(files_available);
			
			DateTime cur_time = DateTime.Now;
			
			foreach( files_available file in files){
				if ((cur_time - file.updated).TotalSeconds > MAX_AGE_FILES){
					files.Remove(file);
					continue;
				}
				
				foreach (files_available compared_file in files){
					if (compared_file.file_name.Equals(file.file_name) && 
						compared_file.file_size.Equals(file.file_size) &&
						compared_file.user_name.Equals(file.user_name) &&
						!compared_file.updated.Equals(file.updated)){
						// everything but time
						files.Remove(file);
						continue;
					}
				}
			}
			List<List<string>> stringified = new List<List<string>>();
			
			foreach (files_available file in files){
				stringified.Add(new List<string>{
					file.file_name, 
					file.file_size.ToString(), 
					file.user_name});
			}
			
			
			return stringified;
		}
		
		
		public void UpdateFilesAvailable(){
			
			if (network.GetReceiveStatus() == false){
				return;
			}
			
			byte[] b;
			
			do{
				b = network.PopReceiveBuffer();
				// we have data in b! Deal with it.
				FilePiece piece = FilePiece.parse_packet(b);
				if (piece != null && piece.number > 0){
					// do nothing. Someone is sending pieces and we don't want that.
				}else if (piece.number == MESSAGE_FILEINFO){
					//hey! It's some file info! Parse it and put it on the stack.
					
					files_available new_file = new files_available();
					byte[] file_name = new byte[255];
					for (int i = 0; i < file_name.Length; i++){
						file_name[i] = b[i];
					}
					new_file.file_name = BitConverter.ToString(file_name);
					
					byte[] file_size = new byte[8];
					for (int i = file_name.Length; i < file_name.Length+8; i++){
						file_size[i- file_name.Length] = b[i];
					}
					new_file.file_size = Int64.Parse(BitConverter.ToString(file_size));
					
					byte[] user_name = new byte[255];
					for (int i = 255+8; i < file_name.Length+8+user_name.Length; i++){
						user_name[i - 8 - file_name.Length] = b[i];
					}
					new_file.user_name = BitConverter.ToString(user_name);
					
					new_file.updated = DateTime.Now;
					
					
					files_available.Add(new_file);
					
				}
				
			}while (b != null);
			
		}
		
		public void SetWriteFile(String file_name, Int64 size){
			file_stream = new FileStreamer(file_name, size);
		}
	
		
		// returns true if streaming started
		public bool StartReceiving(){
			if (file_stream != null){
				return false;
			}
			network.start_receiving();
			return true;
		}
		
		public bool ReceiveChecker(){
			// will return true if all receiving is done.
			// false indicates that the file isn't done being received.
			if (file_stream == null || network.GetReceiveStatus() == false){
				return true;
			}
			
			byte[] b;
			
			do{
				b = network.PopReceiveBuffer();
				// we have data in b! Deal with it.
				FilePiece piece = FilePiece.parse_packet(b);
				if (piece != null && piece.number > 0){
					file_stream.WritePiece(piece);
				}else if (piece.number == MESSAGE_RESEND){
					// A request for a packet has been sent. 
					// We're not server, so we don't do anything
				}
				
			}while (b != null);
			
			Stack missing_pieces = file_stream.GetRequiredPieces();
			if (missing_pieces != null){
				while ( missing_pieces.Count >0){
					network.send(FilePiece.get_missing_packet((Int64)missing_pieces.Pop()));
				}
			}
			
			return file_stream.GetFileStatus();
		}
		
		public bool StartSending(){
			//returns true if it succeeds on starting the send
			if (file_stream != null){
				return false;
			}
			start_time = DateTime.Now.ToUniversalTime();
			
			// start receiving too, because we need to watch for errors.
			// we also need to remember to disregard positive file numbers
			StartReceiving();
			
			return true;
		}
		
		
		public bool SendChecker(){
			// returns true if we're done sending
			if (file_stream == null ||file_stream.GetFileStatus()){
				return true;
			}
			
			byte[] b;
			bool received_error = false;
			
			do{
				b = network.PopReceiveBuffer();
				// we have data in b! Deal with it.
				FilePiece piece = FilePiece.parse_packet(b);
				if (piece != null && piece.number > 0){
					// do nothing. We are not a receiver!
				}else if (piece.number == MESSAGE_RESEND){
					// we are server! We must re-send this packet.
					received_error = true;
					packets_error++;
					network.send(file_stream.GetSpecificChunk(piece.number));
				}
				
			}while (b != null);
			
			
			
			// now that we're caught up, adjust the speed based on errors.
			if (received_error){
				sending_speed *= change_with_error_decrease;
			}else{
				sending_speed *= change_without_error_increase;
			}
			
			// returns true if all pieces have been sent. 
			//Does some sending if there are things to send
			if (file_stream.GetFileStatus()){
				double time_spent = (DateTime.Now.ToUniversalTime() - start_time).TotalSeconds;
				while (sending_speed > (double)bytes_sent/(double)time_spent){
					byte[] bytes = file_stream.GetNextChunk();
					if (bytes != null){
						network.send(bytes);
						bytes_sent += bytes.Length;
					}else{
						// exit loop if we're done sending file
						break;
					}
				}
				return false;
			}else{
				// file stream is done, so we're done sending!
				return true;
			}
			
		}
		
		
		
	}
}
