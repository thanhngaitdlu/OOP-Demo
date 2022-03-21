using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MangSoNguyen
{
	class Program
	{
		private static int[] array = new int[100];
		static int length = 0;

		static void Main(string[] args)
		{
			var fileName = "data.txt";

			NhapTuFileV2(fileName);
			XuatMang();
			Console.WriteLine();

			int soLanXuatHien = 1, soPhanTu = 0;
			int[] kq = TimDSSoNguyenXuatHienNhieuNhat(ref soLanXuatHien, ref soPhanTu);
			Console.WriteLine("Danh sach phan tu xuat hien nhieu nhat, voi so lan xuat hien la {0} lan", soLanXuatHien);
			XuatMang(kq, soPhanTu);

			kq = TimDSSoNguyenXuatHienItNhat(ref soLanXuatHien, ref soPhanTu);
			Console.WriteLine("\nDanh sach phan tu xuat hien ít nhat, voi so lan xuat hien la {0} lan", soLanXuatHien);
			XuatMang(kq, soPhanTu);

			int vtMin, vtMax;
			vtMin = TimViTriSoNhoNhat();
			vtMax = TimViTriSoLonNhat();
			Console.WriteLine("\nSo lon nhat trong mang nam o vi tri {0} va so nho nhat trong mang nam o vi tri {1}", vtMax, vtMin);

			Console.WriteLine("Nhap vi tri can xoa tu 0 toi {0}: ", length-1);
			int x = int.Parse(Console.ReadLine());
			if(XoaPhanTuViTriX(x))
				Console.WriteLine("Da xoa thanh cong.");
			else
			{
				Console.WriteLine("Da xoa that bai.");
			}
			XuatMang();

			Console.ReadKey();
		}

		static int[] TimDsCacPhanTuLonHonX(ref int len, int x)
		{
			int[] kq = new int[100];
			len = 0;
			for (int i = 0; i < length; i++)
			{
				if (array[i] >= x)
				{
					kq[len++] = array[i];
				}
			}
			return kq;
		}
		static void NhapMang()
		{
			Console.Write("Nhap chieu dai mang ");
			length = int.Parse(Console.ReadLine());
			for (int i = 0; i < length; i++)
			{
				Console.Write("a[{0}] = ", i);
				array[i] = int.Parse(Console.ReadLine());
			}
		}
		static void NhapTuFile(string fileName)
		{
			StreamReader sr = new StreamReader(fileName);
			string line = "";
			//Ket thuc file thi gia tri cua line = null
			while ((line = sr.ReadLine()) != null)
			{
				array[length++] = int.Parse(line);
			}
		}
		static void NhapTuFileV2(string fileName)
		{
			StreamReader sr = new StreamReader(fileName);
			var line = sr.ReadLine();
			string[] arr = line.Split(' ');
			foreach (var number in arr)
			{
				array[length++] = int.Parse(number);
			}
		}
		static void NhapMangNgauNhien()
		{
			Console.Write("Nhap chieu dai mang ");
			length = int.Parse(Console.ReadLine());
			var rand = new Random();
			for (int i = 0; i < length; i++)
			{
				array[i] = rand.Next(-100, 100);
			}
		}
		static void XuatMang()
		{
			Console.WriteLine("Danh sach cac phan tu ");
			for (int i = 0; i < length; i++)
			{
				Console.Write(array[i] + "\t");
			}
		}
		static void XuatMang(int[] arr, int length)
		{
			for (int i = 0; i < length; i++)
			{
				Console.Write(arr[i] + "\t");
			}
		}

		static int[] TimDSSoNguyenXuatHienNhieuNhat(ref int soLanXuatHien, ref int soPhanTu)
		{
			int max = 1;
			int[] kq = new int[100];
			soPhanTu = 0;

			for (int i = 0; i < length-1; i++)
			{
				soLanXuatHien = 1;
				for (int j = i+1; j < length; j++)
				{
					if (array[j] == array[i])
						soLanXuatHien++;
				}
				if (soLanXuatHien > max)
				{
					max = soLanXuatHien;
					soPhanTu = 0;
					kq[soPhanTu++] = array[i];
				}
				else if (soLanXuatHien == max)
				{
					kq[soPhanTu++] = array[i];
				}	
			}
			soLanXuatHien = max;
			return kq;
		}

		static int[] TimDSSoNguyenXuatHienItNhat(ref int soLanXuatHien,ref int soPhanTu)
		{
			int min = length, j;
			int[] kq = new int[100];
			soPhanTu = 0;

			for (int i = 0; i < length; i++)
			{
				soLanXuatHien = 1;
				j = 0;
				while (j < i && array[j] != array[i])
					j++;

				if (j == i)
				{
					for (j = i + 1; j < length; j++)
					{
						if (array[j] == array[i])
							soLanXuatHien++;
					}

					if (soLanXuatHien < min)
					{
						min = soLanXuatHien;
						soPhanTu = 0;
						kq[soPhanTu++] = array[i];
					}
					else if (soLanXuatHien == min)
					{
						kq[soPhanTu++] = array[i];
					}
				}

				
			}
			soLanXuatHien = min;
			return kq;
		}

		static int TimViTriSoLonNhat()
		{
			int max = array[0];
			int viTriMax = 0;

			for (int i = 1; i < length; i++)
			{
				if (array[i] > max)
				{
					max = array[i];
					viTriMax = i;
				}
			}
			return viTriMax;
		}
		static int TimViTriSoNhoNhat()
		{
			int min = array[0];
			int viTriMin= 0;

			for (int i = 1; i < length; i++)
			{
				if (array[i] < min)
				{
					min = array[i];
					viTriMin = i;
				}
			}
			return viTriMin;
		}

		static bool XoaPhanTuViTriX(int x)
		{
			if (x < 0 || x > length) return false;

			for (int i = x; i < length; i++)
			{
				array[i] = array[i + 1];
			}
			length--;
			return true;
		}
	}
}
