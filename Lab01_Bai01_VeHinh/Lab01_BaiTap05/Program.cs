using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01_BaiTap05
{
	class Program
	{
		static void Main(string[] args)
		{
			bool laTamGiac = false;
			int a, b, c;
			do
			{
				Console.Write("Nhap vao do dai canh thu nhat: a = ");
				a = int.Parse(Console.ReadLine());
				Console.Write("Nhap vao do dai canh thu nhat: b = ");
				b = int.Parse(Console.ReadLine());
				Console.Write("Nhap vao do dai canh thu nhat: c = ");
				c = int.Parse(Console.ReadLine());

				if (a + b > c && a + c > b && b + c > a)
					laTamGiac = true;
				else
				{
					Console.WriteLine("Khong ton tai tam giac voi 3 canh da cho. Vui long nhap lai");
				}
			} while (!laTamGiac);

			double p = (a + b + c)/2.0;
			double s = Math.Sqrt(p * (p - c) * (p - b) * (p - a));
			Console.WriteLine("Diện tích hình tam giác S = {0}", s);

			Console.ReadKey();
		}
	}
}
