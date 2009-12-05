
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
		
		
		
		byte[] data;
		Int64 number;
		
		public FilePiece(Int64 num, byte[] file_data)
		{
			data = file_data;
			number = num;
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
			
			byte[] b = data_length;
			data_length.CopyTo(b, 0);
			piece_number.CopyTo(b,4);
			checksum.CopyTo(b, 12);
			data.CopyTo(b,28);
			
			return b;
			
		}
	}
}
