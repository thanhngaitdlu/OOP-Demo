using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSinhVien
{
	public class SinhVien
	{
		public string MSSV { get; set; }

		public string HoVaTenLot { get; set; }

		public string Ten { get; set; }

		public DateTime NgaySinh { get; set; }

		public string Phai { get; set; }

		public double Diem { get; set; }

		public SinhVien()
		{
			
		}

		public SinhVien(string mssv, string hoVaTenLot, string ten, DateTime ngaySinh, string phai, double diem)
		{
			MSSV = mssv;
			HoVaTenLot = hoVaTenLot;
			Ten = ten;
			NgaySinh = ngaySinh;
			Phai = phai;
			Diem = diem;
		}

		public SinhVien(string line)
		{
			var dong = line.Split('^');

			MSSV = dong[0];
			HoVaTenLot = dong[1];
			Ten = dong[2];
			NgaySinh = DateTime.Parse(dong[3]);
			Phai = dong[4];
			Diem = double.Parse(dong[5]);
		}

		public override string ToString()
		{
			return string.Format("{0}^{1}^{2}^{3}^{4}^{5}",
				MSSV, HoVaTenLot, Ten, NgaySinh.ToShortDateString(),Phai, Diem);
		}
	}
}
