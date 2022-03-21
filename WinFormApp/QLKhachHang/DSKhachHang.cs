using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKhachHang
{
	public class DSKhachHang
	{
		public List<KhachHang> DanhSach { get; set; }

		public DSKhachHang()
		{
			DanhSach = new List<KhachHang>();
		}

		public void ThemKH(KhachHang kh)
		{
			DanhSach.Add(kh);
		}

		public void DocDanhSachTuTapTin(string tenTT)
		{
			using (var stream = new FileStream(tenTT, FileMode.Open, FileAccess.Read))
			{
				using (var reader = new StreamReader(stream))
				{
					var line = "";

					while ((line = reader.ReadLine()) != null)
					{
						var sv = new KhachHang(line);
						DanhSach.Add(sv);
					}
				}
			}
		}

		private int TimKHTheoSĐT(string sdt)
		{
			for (int i = 0; i < DanhSach.Count; i++)
			{
				if (DanhSach[i].SoDT == sdt) 
					return i;
			}
			return -1;
		}

		public bool SuaDiem(string sdt, int diem)
		{
			var vt = TimKHTheoSĐT(sdt);
			if (vt == -1) return false;

			DanhSach[vt].Diem += diem;
			return true;
		}
	}
}
