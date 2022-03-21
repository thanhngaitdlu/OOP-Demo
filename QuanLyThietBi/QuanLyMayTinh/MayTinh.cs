using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuanLyMayTinh
{
	public class MayTinh
	{
		private List<IThietBi> dsThietBi;

		public MayTinh()
		{
			dsThietBi = new List<IThietBi>();
		}

		public void Them(IThietBi tb)
		{
			dsThietBi.Add(tb);
		}

		public int SoThietBi()
		{
			return dsThietBi.Count;
		}

		public float TongGia()
		{
			var tong = 0f;

			foreach (var tb in dsThietBi)
			{
				tong += tb.Gia;
			}

			return tong;
		}

		public int TongDungLuongRam()
		{
			var dsRam = TimThietBiTheoLoai(LoaiThietBi.RAM);
			var tongRam = 0;

			foreach (RAM ram in dsRam)
			{
				tongRam += ram.DungLuong;
			}

			return tongRam;
		}

		public Dictionary<string, int> DemSoThietBiTheoTungHang(LoaiThietBi loaiTb)
		{
			var kq = new Dictionary<string, int>();

			foreach (var tb in dsThietBi)
			{
				if (CungLoaiThietBi(tb, loaiTb) == false)
					continue;

				if (kq.ContainsKey(tb.HangSx))
					kq[tb.HangSx]++;
				else
					kq.Add(tb.HangSx, 1);
			}

			return kq;
		}

		public List<string> TimDanhSachHang(LoaiThietBi loaiTb)
		{
			//var kq = new List<string>();

			//foreach (var tb in dsThietBi)
			//{
			//	if (!kq.Contains(tb.HangSx))
			//	{
			//		kq.Add(tb.HangSx);
			//	}
			//}

			//return kq;

			var kqDem = DemSoThietBiTheoTungHang(loaiTb);
			return kqDem.Keys.ToList();
		}

		public int DemThietBiTheoHang(LoaiThietBi loaiTb, string hang)
		{
			//var dem = 0;

			//foreach (var tb in dsThietBi)
			//{
			//	if (CungLoaiThietBi(tb, loaiTb) && tb.HangSx == hang)
			//		dem++;
			//}

			//return dem;

			var kqDem = DemSoThietBiTheoTungHang(loaiTb);
			return kqDem.ContainsKey(hang) ? kqDem[hang] : 0;
		}

		public List<IThietBi> TimThietBiTheoLoai(LoaiThietBi loaiTb)
		{
			if (loaiTb == LoaiThietBi.ALL) return dsThietBi;

			var ketQua = new List<IThietBi>();

			foreach (var tb in dsThietBi)
			{
				if (CungLoaiThietBi(tb, loaiTb))
					ketQua.Add(tb);
			}

			return ketQua;
		}

		private bool CungLoaiThietBi(IThietBi tb, LoaiThietBi loaiTb)
		{
			return (loaiTb == LoaiThietBi.ALL) ||
			       (loaiTb == LoaiThietBi.CPU && tb is CPU) ||
			       (loaiTb == LoaiThietBi.RAM && tb is RAM) ||
			       (loaiTb == LoaiThietBi.HDD && tb is DiaCung) ||
			       (loaiTb == LoaiThietBi.KBOARD && tb is BanPhim) ||
			       (loaiTb == LoaiThietBi.MOUSE && tb is Chuot);
		}

		public override string ToString()
		{
			var sb = new StringBuilder();

			foreach (var tb in dsThietBi)
			{
				sb.AppendLine(tb.ToString());
			}

			sb.AppendLine("Tong gia may tinh la: " + TongGia());

			return sb.ToString();
		}

		public List<string> TimDanhSachHang()
		{
			List<string> kq = new List<string>();
			foreach (var tb in dsThietBi)
			{
				kq.Add(tb.HangSx);
			}
			return kq;
		}
	}
}