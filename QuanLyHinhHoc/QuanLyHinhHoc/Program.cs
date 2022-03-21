using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyHinhHoc
{
	class Program
	{
		static void Main(string[] args)
		{
			DanhSachHinhHoc ds = new DanhSachHinhHoc();

			ds.Them(new HinhVuong(2));
			ds.Them(new HinhChuNhat(3, 7));
			ds.Them(new HinhVuong(8));
			ds.Them(new HinhTron(2));
			ds.Them(new HinhVuong(14));
			ds.Them(new HinhChuNhat(4, 9));
			ds.Them(new HinhTron(15));
			ds.Them(new HinhTron(20));
			ds.Them(new HinhChuNhat(8, 6));
			ds.Them(new HinhTron(11));
			ds.Them(new HinhChuNhat(2, 3));
			ds.Them(new HinhChuNhat(3, 4));
			ds.Them(new HinhVuong(4));
			ds.Them(new HinhChuNhat(5, 9));
			ds.Them(new HinhTron(7));

			Console.WriteLine(ds.ToString());
			Console.WriteLine("".PadLeft(80, '-'));

			ds.SapXep(KieuSoSanh.DienTich, ThuTu.Tang);

			Console.WriteLine(ds.ToString());

			Console.ReadKey();
		}
	}
}
