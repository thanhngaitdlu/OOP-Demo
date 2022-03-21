using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01_BaiTapThem04
{
	class Program
	{
		static void Main(string[] args)
		{
			for (int i = 1000; i < 2000; i++)
			{
				Console.Write(i + "\t");

				if (i%5 == 4)
				{
					Console.WriteLine();
				}
			}
		}
	}
}
