using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Lab01_BaiTap08
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Write("Nhap vao so luong so nguyen to can tim n = ");
			int count = int.Parse(Console.ReadLine());

			Console.Write("{0} so nguyen to can tim la: ", count);
			int number = 2;

			while (count > 0)
			{
				bool laNT = true;
				int i = 2, cbh = (int)Math.Sqrt(number);

				while (i <= cbh && laNT)
				{
					if (number % i == 0)
					{
						laNT = false;
					}
					i++;
				}

				if (laNT)
				{
					Console.Write(number + "\t");
					count--;
				}

				number++;
			}

			Console.ReadKey();
		}
	}
}
