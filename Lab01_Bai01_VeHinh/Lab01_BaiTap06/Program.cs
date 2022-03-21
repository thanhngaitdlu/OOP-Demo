using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01_BaiTap06
{
	class Program
	{
		static void Main(string[] args)
		{
			int num, temp, temp1;
			string binString = "", octString = "", hexString = "";
			
			do
			{
				Console.Write("Nhap vao mot so nguyen duong n = ");
				num = int.Parse(Console.ReadLine());
			
			} while (num <= 0);

			temp = num;

			while (temp != 0)
			{
				binString += temp%2;
				temp = temp/2;
			}

			char[] arr = binString.ToCharArray();
			Array.Reverse(arr);
			binString = new string(arr);

			temp = num;
			while (temp != 0)
			{
				octString += temp % 8;
				temp = temp / 8;
			}

			arr = octString.ToCharArray();
			Array.Reverse(arr);
			octString = new string(arr);

			temp = num;
			while (temp != 0)
			{
				temp1 = temp % 16;
				temp = temp / 16;

				if (temp1 < 10)
					hexString += temp1;
				else
					hexString += (char)(temp1 + 65);

				//switch (temp1)
				//{
				//	case 15:
				//		hexString += "F";
				//		break;
				//	case 14:
				//		hexString += "E";
				//		break;
				//	case 13:
				//		hexString += "D";
				//		break;
				//	case 12:
				//		hexString += "C";
				//		break;
				//	case 11:
				//		hexString += "B";
				//		break;
				//	case 10:
				//		hexString += "A";
				//		break;
				//	default:
				//		hexString += temp1;
				//		break;
				//}
			}

			arr = hexString.ToCharArray();
			Array.Reverse(arr);
			hexString = new string(arr);

			Console.WriteLine("Dang nhi phan cua {0} la: {1}", num, binString);
			Console.WriteLine("Dang bat phan cua {0} la: {1}", num, octString);
			Console.WriteLine("Dang thap luc phan cua {0} la: {1}", num, hexString);

			//Console.WriteLine("Dang nhi phan cua n la " + Convert.ToString(num, 2));
			//Console.WriteLine("Dang bat phan cua n la " + Convert.ToString(num, 8));
			//Console.WriteLine("Dang thap luc phan cua n la " + Convert.ToString(num, 16));
		}
	}
}
