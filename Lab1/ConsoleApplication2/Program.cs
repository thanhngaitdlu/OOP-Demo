using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
	class Program
	{
		static void Main(string[] args)
		{
			/*Console.WriteLine("Chao ban. Ten ban la gi?");
			string hoTen = "Nga";
			hoTen = Console.ReadLine();
			
			Console.WriteLine("Chao " + hoTen + ". Rat vui duoc gap ban!!!!");
			Console.WriteLine("Chao {0}. Rat vui duoc gap ban!!!!", hoTen);

			Console.WriteLine("Ban hay nhap vao mot so: ");
			int soNhap = int.Parse(Console.ReadLine());
			int binhPhuong = soNhap*soNhap;

			Console.WriteLine("Cam on {0} da nhap vao so {1}. Binh phuong cua so nay la {2}", hoTen, soNhap, binhPhuong);
			Console.WriteLine("Cam on" + hoTen + "da nhap vao so" + soNhap + ". Binh phuong cua so nay la" + binhPhuong);
			*/
			double soTienVay, laiSuat, tienTra, soTienConLai;

			Console.WriteLine("Nhap vao so tien ban da vay: ");
			soTienVay = Double.Parse(Console.ReadLine());
			Console.WriteLine("Nhap vao lai suat vay: ");
			laiSuat = Double.Parse(Console.ReadLine());
			Console.WriteLine("Nhap vao so tien tra moi thang: ");
			tienTra = Double.Parse(Console.ReadLine());

			soTienConLai = soTienVay;
			int soThang = 1;

			while (soTienConLai > 0)
			{
				
				//tienLai = soTienConLai * laiSuat;
				soTienConLai *= (1+laiSuat);
				soTienConLai -=  tienTra;
				//soThang = soThang + 1;
				Console.WriteLine("{0}. {1}", soThang, soTienConLai);
				soThang++;
			}
			
			Console.WriteLine("Neu vay {0} thi phai tra trong vong {1} thang", soTienVay, soThang-1);
			
			Console.ReadKey();
		}
	}
}
