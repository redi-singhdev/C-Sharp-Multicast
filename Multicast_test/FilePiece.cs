
using System;
using System.Security.Cryptography;


namespace Multicast_test
{
	
	
	
	public class FilePiece
	{
		/*
		 * 4 bytes: data_length  (Int32)
		 * 8 bytes: piece number (Int64)
		 * 16 bytes: MD5 checksum of data
		 * 
		 * rest: data
		 */
		
		public const int data_size = 1024;
		public const int header_size = 4+8+16;
		
		public byte[] data;
		public Int64 number;
		
		public FilePiece(Int64 num, byte[] file_data)
		{
			data = file_data;
			number = num;
		}
		
		public int get_packet_size(){
			return header_size + data.Length;
		}
		
		public byte[] get_data(){
			return data;
		}
		
		
		public byte[] get_checksum(){
			
			MD5 checksum = new MD5CryptoServiceProvider();
			byte[] sum = checksum.ComputeHash(data); // TODO: make this for piece number and data length as well
			return sum;
		}
//		public void send(){
//			send(this.get_packet());
//		}
		
		public byte[] get_packet(){
			
			byte[] data_length = System.BitConverter.GetBytes(data.Length);
			byte[] piece_number = System.BitConverter.GetBytes(number);
			byte[] checksum = get_checksum();
			
			byte[] b = new byte[header_size + data_size]; // 4 + 8 + 16 + data_size
			
			data_length.CopyTo(b, 0);
			piece_number.CopyTo(b,4);
			checksum.CopyTo(b, 12);
			data.CopyTo(b,header_size);
			
			return b;
			
		}
		
		public static byte[] get_missing_packet(Int64 missing_number){
			
			byte[] number_data = System.BitConverter.GetBytes(missing_number);
			FilePiece piece = new FilePiece(-1, number_data);
			
			return piece.get_packet();
			
		}
		
		static public FilePiece parse_packet(byte[] packet){
			
			if (packet.Length < header_size){ // packet is shorter than the header has to be
				return null;
			}
			Int32 data_length = System.BitConverter.ToInt32(packet, 0);
			if (data_length < 0){ // no data
				return null;
			}
			Int64 piece_number = System.BitConverter.ToInt64(packet, 4);
			
			byte[] checksum = new byte[16];
			for(int i = 12; i < 28; i++){
				checksum[i-12] = packet[i];
			}
			
			
			byte[] data = new byte[data_length];
			for (int i = 0; i < data_length; i++){
				data[i] = packet[i+header_size];
			}
			
			
			// do a checksum
			MD5 check = new MD5CryptoServiceProvider();
			byte[] sum = check.ComputeHash(data);
			if (sum.Equals(checksum)){
				return null; // data checksum doesn't match
			}
			
			
			FilePiece piece = new FilePiece(piece_number, data);
			
			return piece;
			
			
		}
	}
}
