using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
	class Program
	{
		static int[] mmc = new int[100];
		static int soPhanTu = -1;
		static void Main(string[] args)
		{
			//const double PI = 3.1415;
			//string hoTen;
			//int tuoi = 20;
			//double heSoLuong = 3.34;

			//Console.WriteLine("Ten ban la gi?");

			//hoTen = Console.ReadLine();
			//Console.WriteLine("Xin chao " + hoTen + " !!!!");

			//Console.WriteLine("Ban bao nhieu tuoi?");
			//tuoi = int.Parse(Console.ReadLine());

			//Console.WriteLine("Xin chao {0}. Ban {1} tuoi. Ban co he so luong la {2}",hoTen, tuoi, heSoLuong);

			//int tong = 0;
			//for (int i = 1; i <= 5; i++)
			//{
			//	tong += i;
			//	Console.WriteLine("i = {0}; tong = {1}", i, tong);
			//}

			//int x = 1;
			//tong = 0;
			//while (x <= 5)
			//{
			//	//tong = tong + x;
			//	tong += x;
			//	Console.WriteLine("x = {0}; tong = {1}", x, tong);
			//	//x = x + 1;
			//	x++;
			//}

			//Console.WriteLine("Tong x = " + tong);

			while (soPhanTu <= 0 || soPhanTu >100)
			{
				Console.WriteLine("Nhap vao so phan tu cua mang: ");
				soPhanTu = int.Parse(Console.ReadLine());
			}
			Console.WriteLine("So phan tu cua mang la: {0} phan tu",soPhanTu);

			NhapMang(soPhanTu);

			XuatMang();

			//int so = 8;
			//GapDoi(ref so);
			//Console.WriteLine("\n So gap doi la "+so);

			XuatSoLeTrongMang();


			int tong;
			tong = TongCacSoOViTriChiaHetCho3();
			Console.WriteLine("\nTong cac so nam o vi tri chia het cho 3 la:  " + tong);

			tong = TongChiaHet3();
			Console.WriteLine("\nTong cac so chia het cho 3 la:  " + tong);

			for (int i = 100; i <= 102; i++)
			{
				Them(i);
			}

			XuatMang();

			tong = TongCacSoOViTriChiaHetCho3();
			Console.WriteLine("\nTong cac so nam o vi tri chia het cho 3 la:  " + tong);

			Console.Write("\nNhap vao so min = ");
			int min = int.Parse(Console.ReadLine());

			Console.Write("\nNhap vao so max = ");
			int max = int.Parse(Console.ReadLine());

			XuatCacPhanTuTrongKhoang(min, max);
			int soPt = 0;
			int[] kq = TimCacPhanTuTrongKhoang(min, max, ref soPt);
			XuatMang(kq, soPt);

			Console.ReadKey();
		}

		static void XuatMang()
		{
			Console.WriteLine("Danh sach cac phan tu trong mang la: ");
			for (int i = 0; i < soPhanTu; i++)
			{
				Console.Write(mmc[i] + "\t");

			}
		}

		static void XuatMang(int[] mang, int soLuong)
		{
			Console.WriteLine("Danh sach cac phan tu trong mang 2 la: ");
			for (int i = 0; i < soLuong; i++)
			{
				Console.Write(mang[i] + "\t");

			}
		}

		static void NhapMang(int soLuong)
		{
			for (int i = 0; i < soLuong; i++)
			{
				Console.Write("\nNhap vao phan tu thu {0}: ", i + 1);
				mmc[i] = int.Parse(Console.ReadLine());
			}
		}

		static void XuatSoLeTrongMang()
		{
			Console.WriteLine("\nDanh sach cac phan tu la so le trong mang la: ");
			for (int i = 0; i < soPhanTu; i++)
			{
				if (mmc[i] % 2 != 0)
					Console.Write(mmc[i] + "\t");
			}
		}

		static void Them()
		{
			Console.WriteLine("\nNhap phan tu muon them:  ");
			mmc[soPhanTu] = int.Parse(Console.ReadLine());
			soPhanTu++;
		}
		static void Them(int num)
		{
			mmc[soPhanTu] = num;
			soPhanTu++;
		}

		static int TongCacSoOViTriChiaHetCho3()
		{
			int tong = 0;
			for (int i = 0; i < soPhanTu; i++)
			{
				if (i % 3 == 0)
					tong += mmc[i];
			}
			return tong;
		}

		static void XuatCacPhanTuTrongKhoang(int min, int max)
		{
			for (int i = 0; i < soPhanTu; i++)
			{
				if(mmc[i] >= min && mmc[i] <= max)
					Console.Write(mmc[i] + "\t");
			}
		}

		static int[] TimCacPhanTuTrongKhoang(int min, int max, ref int soLuong)
		{
			int[] kq = new int[100];
			soLuong = 0;
			for (int i = 0; i < soPhanTu; i++)
			{
				if (mmc[i] >= min && mmc[i] <= max)
				{
					kq[soLuong] = mmc[i];
					soLuong++;
				}
			}
			return kq;
		}

		static void GapDoi(ref int so)
		{
			so *= 2;
		}
		//static void GapDoi(int so)
		//{
		//	so *= 2;
		//}

		static int TongChiaHet3()
		{
			int tong = 0;
			for (int i = 0; i < soPhanTu; i++)
			{
				if (mmc[i] % 3 == 0)
				{
					tong += mmc[i];
				}
			}
			return tong;
		}
	}
}
