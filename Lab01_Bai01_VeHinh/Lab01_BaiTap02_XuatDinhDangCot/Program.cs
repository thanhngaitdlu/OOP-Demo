using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01_BaiTap02_XuatDinhDangCot
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("{0,70}", "DANH SACH SINH VIEN");
			Console.WriteLine();
			Console.WriteLine("{0, -15}{1, -35}{2,-10}{3,-10}", "MSSV", "Ho va Ten", "Khoa", "Diem");
			Console.WriteLine("{0, -15}{1, -35}{2,-10}{3,-10}", "-----", "---------------------", "-----", "----");
			Console.WriteLine("{0, -15}{1, -35}{2,-10}{3,-10}", "1211520", "Le Duy Tung", 33, 4.57);
			Console.WriteLine("{0, -15}{1, -35}{2,-10}{3,10}", "1210152", "Tran Van Tien", 34, "VT");
			Console.WriteLine("{0, -15}{1, -35}{2,-10}{3,-10}", "1211962", "Pham Duc Anh", 33, 6.48);

		}
	}
}
