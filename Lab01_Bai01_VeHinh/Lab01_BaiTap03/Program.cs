using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01_BaiTap03
{
	class Program
	{
		static void Main(string[] args)
		{
			int x = 7, y = -3;

			int z = x++ + x++;
			Console.WriteLine("x = {0}, y = {1}, z = {2}", x, y, z);
			z = x++ + x++ + ++x;
			Console.WriteLine("x = {0}, y = {1}, z = {2}", x, y, z);
			z = ++x + y-- - ++y - x-- - x-- - ++y - x--;
			Console.WriteLine("x = {0}, y = {1}, z = {2}", x, y, z);
			z = x++ + ++y - x-- + --y;
			Console.WriteLine("x = {0}, y = {1}, z = {2}", x, y, z);
			z = x++*y++/++x - --y % x++;
			Console.WriteLine("x = {0}, y = {1}, z = {2}", x, y, z);
			z = x++ + ++y - x-- + --y;
			Console.WriteLine("x = {0}, y = {1}, z = {2}", x, y, z);
		}
	}
}
