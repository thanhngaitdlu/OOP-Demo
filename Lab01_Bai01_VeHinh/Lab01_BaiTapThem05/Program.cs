using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01_BaiTapThem05
{
	class Program
	{
		static void Main(string[] args)
		{
			int number, count = 0;
			do
			{
				Console.Write("Nhap vao mot so nguyen duong n = ");
				number = int.Parse(Console.ReadLine());
			} while (number <= 0);

			//string s = Convert.ToString(number, 2);
			//char[] arr = s.ToCharArray();

			//for (int i = 0; i < arr.Length; i++)
			//{
			//	count += (int)arr[i] - 48;
			//}

			while (number > 0)
			{
				count++;
				number &= number - 1;
			}

			Console.WriteLine("So bit 1 trong bieu dien nhi phan cua {0} la {1} bit", number,count);

		}
	}
}
