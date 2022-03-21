using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKhachHang
{
	public class KhachHang
	{
		public string TenKhachHang { get; set; }

		public string SoDT { get; set; }

		public int Diem { get; set; }

		public KhachHang(string ten, string sdt, int diem)
		{
			TenKhachHang = ten;
			SoDT = sdt;
			Diem = diem;
		}

		public KhachHang(string hang)
		{
			string[] kq = hang.Split('\t');
			TenKhachHang = kq[0];
			SoDT = kq[1];
			Diem = int.Parse(kq[2]);
		}
	}
}
