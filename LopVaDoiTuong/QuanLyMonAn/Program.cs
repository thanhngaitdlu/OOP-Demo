using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyMonAn
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.OutputEncoding = Encoding.UTF8;
			DSMonAn dsMonAn = new DSMonAn();

			dsMonAn.AddFromFile();

			dsMonAn.XuatDanhSach();

			Console.WriteLine("Đơn giá cao nhất là : " + dsMonAn.TimDonGiaCaoNhat());

			var dsMonCoDGCaoNhat = dsMonAn.TimMonAnCoDGCaoNhat();

			Console.WriteLine("------------------------------------------------");
			Console.WriteLine("Các món ăn có đơn giá cao nhất là:");
			foreach (var monAn in dsMonCoDGCaoNhat)
			{
				Console.WriteLine(monAn.TenMonAn);
			}
			Console.WriteLine("------------------------------------------------");
			Console.WriteLine("Nhập vào đơn giá của món ăn cần tìm:");
			int donGia = int.Parse(Console.ReadLine());

			var ds = dsMonAn.TimMonAnTheoDonGia(donGia);

			if (ds.Count > 0)
			{
				Console.WriteLine("Các món ăn có đơn giá {0} là:", donGia);
				foreach (var monAn in ds)
				{
					Console.WriteLine(monAn);
				}

			}
			else
			{
				Console.WriteLine("Không có món ăn nào có đơn giá này");
			}



			Console.ReadKey();
		}
	}
}
