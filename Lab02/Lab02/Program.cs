using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02
{
	class Program
	{
		static int[] mang = new int[1000];

		private static int soLuong = 0;
		static void Main(string[] args)
		{
			/*
			NhapNgauNhien();
			XuatMang();

			int tong = TinhTong();
			Console.WriteLine("Tong cac phan tu cua mang la: {0}", tong);

			Console.Write("Nhap vao phan tu x can tim: ");
			int x = int.Parse(Console.ReadLine());
			int vitri = TimViTri(x);
			if (vitri == -1)
				Console.WriteLine("Khong tim thay {0} trong mang", x);
			else
			{
				Console.WriteLine("Phan tu {0} o vi tri {1} trong mang", x, vitri);
			}

			vitri = TimSoLonNhat();
			Console.WriteLine("So lon nhat trong mang nam o vi tri {0}", vitri);

			Console.Write("Nhap vao vi tri can xoa: ");
			vitri = int.Parse(Console.ReadLine());

			XoaTaiViTri(vitri);
			Console.WriteLine("Da xoa phan tu tai vi tri {0}", vitri);
			XuatMang();

			Console.Write("Nhap vao gia tri phan tu can xoa: ");
			x = int.Parse(Console.ReadLine());
			if (XoaPhanTuX(x))
			{
				Console.WriteLine("Da xoa phan tu co gia tri {0} trong mang", x);
			}
			else
			{
				Console.WriteLine("Khong xoa duoc vi phan tu {0} khong ton tai trong mang");
			}
			XuatMang();*/

			ChayChuongTrinh();
			Console.ReadKey();
		}

		static void NhapMang()
		{
			Console.Write("Nhap so luong phan tu cua mang: ");
			soLuong = int.Parse(Console.ReadLine());

			for (int i = 0; i < soLuong; i++)
			{
				Console.Write("mang[{0}] = ", i);
				mang[i] = int.Parse(Console.ReadLine());
			}
		}

		static void NhapNgauNhien()
		{
			Console.Write("Nhap so luong phan tu cua mang: ");
			soLuong = int.Parse(Console.ReadLine());

			Random rd = new Random();

			for (int i = 0; i < soLuong; i++)
			{
				mang[i] = rd.Next(1000);
			}
		}

		static void XuatMang()
		{
			Console.WriteLine("Cac phan tu cua mang: ");
			for (int i = 0; i < soLuong; i++)
			{
				Console.Write("{0}\t", mang[i]);
			}
			Console.WriteLine();
		}

		static int TinhTong()
		{
			int sum = 0;
			for (int i = 0; i < soLuong; i++)
			{
				sum += mang[i];
			}
			return sum;
		}

		static int TimSoLonNhat()
		{
			int max = mang[0];
			for (int i = 1; i < soLuong; i++)
			{
				if (mang[i] > max)
					max = mang[i];
			}
			return max;
		}

		static int TimViTri(int x)
		{
			for (int i = 0; i < soLuong; i++)
			{
				if (mang[i] == x)
					return i;
			}
			return -1;
		}

		static void XoaTaiViTri(int viTri)
		{
			for (int i = viTri; i < soLuong; i++)
			{
				mang[i] = mang[i+1];
			}
		}

		static bool XoaPhanTuX(int x)
		{
			for (int i = 0; i < soLuong; i++)
			{
				if (mang[i] == x)
				{
					for (int j = i; j < soLuong; j++)
					{
						mang[j] = mang[j + 1];
					}
					return true;
				}
			}
			return false;
		}

		static void InMenu()
		{
			Console.WriteLine("============================ MENU ==============================");
			Console.WriteLine("{0}. Nhap mang bang tay", (int)ThucDon.NhapMang);
			Console.WriteLine("{0}. Nhap ngau nhien", (int)ThucDon.NhapNgauNhien);
			Console.WriteLine("{0}. Xuat cac phan tu cua mang", (int)ThucDon.XuatMang);
			Console.WriteLine("{0}. Tinh tong cac phan tu", (int)ThucDon.TinhTong);
			Console.WriteLine("{0}. Tim phan tu lon nhat", (int)ThucDon.TimMax);
			Console.WriteLine("{0}. Tim vi tri cua phan tu X", (int)ThucDon.TimViTri);
			Console.WriteLine("{0}. Tim vi tri phan tu lon nhat", (int)ThucDon.TimViTriMax);
			Console.WriteLine("{0}. Xoa phan tu tai vi tri cho truoc", (int)ThucDon.XoaTaiViTri);
			Console.WriteLine("{0}. Xoa phan tu X khoi mang", (int)ThucDon.XoaPhanTuX);
			Console.WriteLine("{0}. Thoat", (int)ThucDon.Thoat);
		}

		static ThucDon ChonMenu()
		{
			int soMenu = Enum.GetNames(typeof(ThucDon)).Length;
			int menu = 0;
			do
			{
				InMenu();
				Console.Write("Nhap so de chon menu (0 ...{0}) : ", soMenu);
				menu = int.Parse(Console.ReadLine());
			} while (menu < 0 || menu >= soMenu);
			return (ThucDon) menu;
		}

		static void XuLy(ThucDon menu)
		{
			switch (menu)
			{
				case ThucDon.NhapMang:NhapMang();
					break;
				case ThucDon.NhapNgauNhien:NhapNgauNhien();
					break;
				case ThucDon.XuatMang:XuatMang();
					break;
				default:
					break;
			}
		}

		static void ChayChuongTrinh()
		{
			ThucDon menu = ThucDon.Thoat;
			do
			{
				menu = ChonMenu();
				XuLy(menu);
			} while (menu != ThucDon.Thoat);
		}
	}
}
