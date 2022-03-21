using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01_BaiTapThem10
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Write("Nhap vao so nguyen duong n = ");
			int number = int.Parse(Console.ReadLine());

			int[] array = new int[number];
			array[0] = 0;
			array[1] = 1;
			for (int i = 2; i < number; i++)
			{
				array[i] = array[i - 1] + array[i - 2];
			}
			Console.Write("{0} so Fibonnaci la: ", number);
			for (int i = 0; i < number; i++)
			{
				Console.Write(array[i] + "\t");
			}
			Console.WriteLine();
		}
	}
}
