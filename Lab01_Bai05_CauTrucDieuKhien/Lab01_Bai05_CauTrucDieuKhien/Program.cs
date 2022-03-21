using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01_Bai05_CauTrucDieuKhien
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Nhap gio hien tai (0 .. 24): ");

			int gioHienTai;
			gioHienTai = int.Parse(Console.ReadLine());

			//===============================================================
			// Lệnh IF
			if (gioHienTai % 2 == 0)
				Console.WriteLine("Gio chan");
			else
				Console.WriteLine("Gio le");

			if (gioHienTai < 0 || gioHienTai > 24)
				Console.WriteLine("Ban nhap gio sai");
			else if (gioHienTai <= 12)
				Console.WriteLine("Chao buoi sang");
			else
				Console.WriteLine("Chao buoi chieu");

			// Lệnh FOR
			int n = 10, tong = 0;
			// Tinh tổng các số từ 1 đến n
			for (int i = 1; i <= n; i++)
				tong += i;

			// Xuất kết quả ra màn hình
			Console.WriteLine("1 + 2 + ... + {0} = {1}", n, tong);

			/*
			double soTienVay = 25000000, laiSuat = 0.01, tienTra = 2000000;
			int soThang = 0;

			while (soTienVay > 0)
			{
				soThang++;
				soTienVay *= 1 + laiSuat;
				soTienVay -= tienTra;
			}

			Console.WriteLine("So thang phai tra tien: {0} thang", soThang);
			
			int number = 0;

			do
			{
				Console.Write("Nhap mot so tu 0 den 10: ");
				number = int.Parse(Console.ReadLine());
			} while (number < 0 || number > 10);
			*/
			char diem = 'B';
			switch (diem)
			{
				case 'A':
					Console.WriteLine("Hoc luc Gioi");
					break;
				case 'B':
					Console.WriteLine("Hoc luc Kha");
					break;
				case 'C':
					Console.WriteLine("Hoc luc Trung binh");
					break;
				case 'D':
					Console.WriteLine("Hoc luc Yeu");
					break;
				default:
					Console.WriteLine("Khong xep loai");
					break;
			}
		}
	}
}
