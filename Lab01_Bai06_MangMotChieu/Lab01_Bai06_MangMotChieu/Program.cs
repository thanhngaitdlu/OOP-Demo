using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01_Bai06_MangMotChieu
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] mmc;
			mmc = new int[1000];
			int dem = 0;

			Console.Write("Hay nhap so phan tu cua mang: ");
			dem = int.Parse(Console.ReadLine());
			for (int i = 0; i <dem; i++)
			{
				Console.Write("a[{0}] = ", i);
				mmc[i] = int.Parse(Console.ReadLine());
			}
			Console.WriteLine("Cac phan tu cua mang: ");
			for (int i = 0; i < dem; i++)
			{
				Console.Write("{0}\t", mmc[i]);
			}

			// Tìm phần tử nhỏ nhất trong mảng
			int min = mmc[0];
			for (int i = 0; i < dem; i++)
			{
				if (min > mmc[i])
					min = mmc[i];
			}
			Console.WriteLine("Phan tu nho nhat trong mang la: {0}", min);

			// Tìm vị trí xuất hiện đầu tiên của một phần tử X
			Console.Write("Nhap vao phan tu X can tim: ");
			int x = int.Parse(Console.ReadLine());

			int viTri = -1;
			for (int i = 0; i < dem; i++)
			{
				if (mmc[i] == x)
				{
					viTri = i;
					break;
				}
			}
			if(viTri == -1)
				Console.WriteLine("Khong tim thay {0} trong mang", x);
			else
			{
				Console.WriteLine("{0} nam o vi tri thu {1}", x, viTri+1);
			}

			// Sắp xếp các phần tử của mảng theo thứ tự tăng dần
			for (int i = 0; i < dem; i++)
			{
				for (int j = i + 1; j < dem; j++)
				{
					if (mmc[i] > mmc[j])
					{
						int tam = mmc[i];
						mmc[i] = mmc[j];
						mmc[j] = tam;
					}
				}
			}
			// Xuất mảng
			Console.WriteLine("Cac phan tu cua mang: ");
			for (int i = 0; i < dem; i++)
			{
				Console.Write("{0}\t", mmc[i]);
			}
		}
	}
}
