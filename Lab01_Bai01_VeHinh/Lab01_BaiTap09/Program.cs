using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01_BaiTap09
{
	class Program
	{
		static double[] arr;
		static int len;
		const int MAX = 100;
		static void Main(string[] args)
		{
			Console.Write("Nhap vao so phan tu cua mang: ");
			len = int.Parse(Console.ReadLine());

			Random rand = new Random();

			arr = new double[len];

			for (int i = 0; i < len; i++)
			{
				arr[i] = rand.NextDouble()*MAX - 50;
			}
			output();
			/*
			Console.Write("Nhap vao can duoi: ");
			int minNum = int.Parse(Console.ReadLine());
			Console.Write("Nhap vao can tren: ");
			int maxNum = int.Parse(Console.ReadLine());

			Console.WriteLine("Cac so nam trong khoang ({0},{1}) la: ", minNum, maxNum);

			for (int i = 0; i < len; i++)
			{
				if(arr[i] >= minNum && arr[i] <= maxNum)
					Console.Write(arr[i] + "\t");
			}
			Console.WriteLine();
			Console.Write("Vi tri cua cac so am nam o vi tri le la: ");

			for (int i = 0; i < len; i++)
			{
				if(arr[i] < 0 && i % 2 == 1)
					Console.Write(arr[i] + "\t");
			}

			Console.WriteLine();
			Console.Write("Cac so o vi tri chia het cho 3 la: ");

			double sum = 0;

			for (int i = 0; i < len; i++)
			{
				if (i%3 == 0)
				{
					Console.Write(arr[i] + "\t");
					sum += arr[i];
				}
			}
			
			Console.WriteLine("Tong cua cac so nam o vi tri chia het cho 3 la: {0}", sum);
			Console.WriteLine();
			//Console.Write("Cac so o vi tri chia het cho 3 la: ");
			sum = 0;
			for (int i = 0; i < len; i++)
			{
				sum += arr[i];
			}

			if (len == 0)
				Console.WriteLine("Mang chua co phan tu nao");
			else
			{
				Console.WriteLine("Trung binh cong cua cac so trong mang la {0}", sum/len);
			}

	*/

			Console.WriteLine("Nhap vao so luong cac so lon nhat can xuat: ");
			int count = int.Parse(Console.ReadLine());
			double temp;

			for (int i = 0; i < len-1; i++)
			{
				for (int j = i+1; j < len; j++)
				{
					if (arr[j] > arr[i])
					{
						temp = arr[i];
						arr[i] = arr[j];
						arr[j] = temp;
					}
				}
				
			}
			Console.WriteLine("Mang da sap xep giam: ");
			output();

			Console.WriteLine("{0} so lon nhat trong mang la: ", count);

			for (int j = 0; j < count; j++)
			{
				Console.Write(arr[j] + "\t");
			}

			Console.ReadKey();
		}

		static void output()
		{
			for (int i = 0; i < len; i++)
			{
				Console.Write(arr[i] + "\t");
			}
			Console.WriteLine();
		}
	}
}
