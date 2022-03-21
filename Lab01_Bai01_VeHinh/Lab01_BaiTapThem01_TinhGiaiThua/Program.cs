using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01_BaiTapThem01_TinhGiaiThua
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Write("Nhap mot so nguyen n = ");
			int number = int.Parse(Console.ReadLine());

			long giaithua = 1;

			for (int i = 2; i <= number; i++)
				giaithua *= i;
			Console.WriteLine("{0}! = {1}", number, giaithua);
			{
				
			}
		}
	}
}
