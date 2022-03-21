using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01_Bai01_VeHinh
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Write("Nhap vao kich thuoc cac hinh: ");
			int size = int.Parse(Console.ReadLine());

			for (int i = 1; i <= size; i++)
			{
				for (int j = 1; j <= size; j++)
				{
					if (i%2 == 0)
						Console.Write("* ");
					else
					{
						Console.Write(" *");
					}
				}
				Console.WriteLine();

			}

			// Xuat hinh 2
			Console.WriteLine();

			for (int i = 1; i <= size; i++)
			{
				for (int j = 1; j <= size; j++)
				{
					if (i == 1 || i == size || j == 1 || j == size)

						Console.Write("* ");
					else
					{
						Console.Write("  ");
					}

				}
				Console.WriteLine();

			}
			// Xuất hình 3
			for (int j = 1; j <= size; j++)
			{
				Console.Write("* ");
			}
			Console.WriteLine();
			for (int i = 2; i <= size; i++)
			{
				for (int j = 1; j < size*2; j++)
				{
					if (j == i || j == size*2 - i)
						Console.Write("*");

					else
					{
						Console.Write(" ");
					}
				}
				Console.WriteLine();
			}
		}
	}
}
