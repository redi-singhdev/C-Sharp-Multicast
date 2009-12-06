
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
		
		public byte[] data;
		public Int64 number;
		
		public FilePiece(Int64 num, byte[] file_data)
		{
			data = file_data;
			number = num;
			if (data.Length != data_size){
				// data length is wrong! D:
				data.Initialize();
				number = -1;
			}
		}
		public byte[] get_checksum(){
			
			MD5 checksum = new MD5CryptoServiceProvider();
			byte[] sum = checksum.ComputeHash(data);
			return sum;
		}
		public byte[] get_packet(){
			
			byte[] data_length = System.BitConverter.GetBytes(data.Length);
			byte[] piece_number = System.BitConverter.GetBytes(number);
			byte[] checksum = get_checksum();
			
			byte[] b = new byte[4 + 8 + 16 + data.Length]; // 4 + 8 + 16 + data_length
			
			data_length.CopyTo(b, 0);
			piece_number.CopyTo(b,4);
			checksum.CopyTo(b, 12);
			data.CopyTo(b,28);
			
			return b;
			
		}
		
		static public FilePiece parse_packet(byte[] packet){
			if (packet.Length < 28){ // header isn't long enough
				return null;
			}
			Int32 data_length = System.BitConverter.ToInt32(packet, 0);
			if (data_length < 0){ // no data
				return null;
			}
			Int64 piece_number = System.BitConverter.ToInt64(packet, 4);
			if (piece_number < 0){ // can't have less than 0 piece number
				return null;
			}
			byte[] checksum = new byte[16];
			for(int i = 12; i < 28; i++){
				checksum[i] = packet[i];
			}
			System.ArraySegment<byte> data_segment = new System.ArraySegment<byte>(packet, 28, packet.Length-28);
			
			byte[] data = data_segment.Array;
			
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
