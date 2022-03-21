using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyMonAn
{
	public class MonAn
	{
		public string TenMonAn { get; set; }

		public string NhomMonAn { get; set; }

		public string DonViTinh { get; set; }

		public int DonGia { get; set; }

		public MonAn()
		{
			TenMonAn = "Mon an moi";
			NhomMonAn = "Chua phan loai";
			DonViTinh = "Dia";
			DonGia = 100000;
		}

		public MonAn(string tenMonAn, string nhomMonAn, string donViTinh, int donGia)
		{
			TenMonAn = tenMonAn;
			NhomMonAn = nhomMonAn;
			DonViTinh = donViTinh;
			DonGia = donGia;
		}

		public MonAn(string line)
		{
			var monAn = line.Split('^');

			TenMonAn = monAn[0];
			NhomMonAn = monAn[1];
			DonViTinh = monAn[2];
			DonGia = int.Parse(monAn[3]);
		}

		public override string ToString()
		{
			return string.Format("{0, -30} {1, -10}{2, -10}{3, -10}", TenMonAn, NhomMonAn, DonViTinh, DonGia);
		}
	}
}
