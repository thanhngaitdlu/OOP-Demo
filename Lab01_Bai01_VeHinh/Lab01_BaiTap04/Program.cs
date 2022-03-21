using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01_BaiTap04
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Write("Nhap vao ban kinh mat day: r = ");
			int r = int.Parse(Console.ReadLine());
			Console.Write("Nhap vao chieu cao cua hinh tru: h = ");
			int h = int.Parse(Console.ReadLine());
			Console.WriteLine("Chu vi mat day cua hinh tru cv = {0}", 2*Math.PI*r);
			Console.WriteLine("Dien tich mat day cua hinh tru tron S= {0}", Math.PI*r*r);
			Console.WriteLine("The tich cua hinh tru tron V = {0}", Math.PI*r*r*h);


		}
	}
}
