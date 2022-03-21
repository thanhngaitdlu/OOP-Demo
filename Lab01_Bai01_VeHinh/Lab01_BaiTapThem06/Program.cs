using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01_BaiTapThem06
{
	class Program
	{
		static void Main(string[] args)
		{
			
			int[] arr = new int[50];
			Random r = new Random();
			int count = 0;
			for (int i = 0; i < arr.Length; i++)
			{
				arr[i] = r.Next(1, 100);
			}
			for (int i = 0; i < arr.Length; i++)
			{
				Console.Write(arr[i] + "\t");
			}
			Console.WriteLine();
			Console.Write("Vi tri cac so nguyen to trong mang la: ");
			for (int i = 0; i < arr.Length; i++)
			{
				//if (LaNguyenTo(arr[i]))
				//{
				//	Console.Write("{0}\t", i);
				//}
				
				if (LaSoHoanChinh(arr[i]))
				{
					count++;
					Console.Write("{0}\t", arr[i]);
				}
			}
			Console.WriteLine();
			if (count > 0)
			{
				Console.WriteLine("Co {0} so hoan chinh trong mang", count);
			}
			else
			{
				Console.WriteLine("Mang nay khong ton tai so hoan chinh");
			}
		}

		static bool LaNguyenTo(int number)
		{
			int cbh = (int)Math.Sqrt(number);
			for (int i = 2; i <= cbh ; i++)
			{
				if (number % i == 0)
				{
					return false;
				}
			}
			return true;
		}

		static bool LaSoHoanChinh(int number)
		{
			int i = 1, temp = number;
			while (temp >= 0 && i <= number/2)
			{
				if (number % i == 0)
				{
					temp -= i;
				}
				i++;
			}
			return temp == 0;
		}
	}
}
