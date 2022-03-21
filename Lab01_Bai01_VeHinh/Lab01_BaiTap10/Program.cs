using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01_BaiTap10
{
	class Program
	{
		static void Main(string[] args)
		{
			int ngay, thang, nam;
			Console.Write("Nhap vao ngay: ");
			ngay = int.Parse(Console.ReadLine());
			Console.Write("Nhap vao thang: ");
			thang = int.Parse(Console.ReadLine());
			Console.Write("Nhap vao nam: ");
			nam = int.Parse(Console.ReadLine());

			int y0 = nam - (14 - thang)/12;
			int x = y0 + y0/4 - y0/100 + y0/400;
			int m0 = thang + 12*((14 - thang)/12) - 2;
			int d0 = (ngay + x + (31*m0)/12)%7;

			switch (d0)
			{
				case 0:
					Console.WriteLine("Ngay {0}/{1}/{2} la ngay chu nhat", ngay, thang, nam);
					break;
				case 1:
					Console.WriteLine("Ngay {0}/{1}/{2} la ngay thu hai", ngay, thang, nam);
					break;
				case 2:
					Console.WriteLine("Ngay {0}/{1}/{2} la ngay thu ba", ngay, thang, nam);
					break;
				case 3:
					Console.WriteLine("Ngay {0}/{1}/{2} la ngay thu tu", ngay, thang, nam);
					break;
				case 4:
					Console.WriteLine("Ngay {0}/{1}/{2} la ngay thu nam", ngay, thang, nam);
					break;
				case 5:
					Console.WriteLine("Ngay {0}/{1}/{2} la ngay thu sau", ngay, thang, nam);
					break;
				case 6:
					Console.WriteLine("Ngay {0}/{1}/{2} la ngay thu bay", ngay, thang, nam);
					break;
				
			}
		}

	}
}
