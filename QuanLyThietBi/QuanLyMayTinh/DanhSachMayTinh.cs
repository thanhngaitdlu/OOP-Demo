using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace QuanLyMayTinh
{
	public class DanhSachMayTinh
	{
		private List<MayTinh> dsMayTinh;

		public DanhSachMayTinh()
		{
			dsMayTinh = new List<MayTinh>();
		}

		public void Them(MayTinh mt)
		{
			dsMayTinh.Add(mt);
		}

		public void NhapTuFile()
		{
			string path = @"data.txt";
			StreamReader sr = new StreamReader(path);
			string str = "";

			while ((str = sr.ReadLine()) != null)
			{
				// CPU,Intel,300 * CPU,Intel,300 * RAM,SamSung,50 * HDD,Seagate,500
				MayTinh mt = new MayTinh();
				string[] s = str.Split('*');

				foreach (string item in s)
				{
					var segment = item.Trim();

					if (segment.IndexOf("CPU") == 0)
						mt.Them(new CPU(item));

					if (segment.IndexOf("RAM") == 0)
						mt.Them(new RAM(item));

					if (segment.IndexOf("HDD") == 0)
						mt.Them(new DiaCung(item));

					if (segment.IndexOf("KBOARD") == 0)
						mt.Them(new BanPhim(item));

					if (segment.IndexOf("MOUSE") == 0)
						mt.Them(new Chuot(item));
				}

				Them(mt);
			}
		}

		public float TimGiaCaoNhat()
		{
			var giaMax = 0f;

			foreach (var mt in dsMayTinh)
			{
				var tongGia = mt.TongGia();

				if (giaMax < tongGia)
					giaMax = tongGia;
			}

			return giaMax;
		}

		public float TimGiaThapNhat()
		{
			var giaMin = float.MaxValue;

			foreach (var mt in dsMayTinh)
			{
				var tongGia = mt.TongGia();

				if (giaMin > tongGia)
					giaMin = tongGia;
			}

			return giaMin;
		}

		public DanhSachMayTinh TimMayTinhCoGiaCaoNhat()
		{
			var ketQua = new DanhSachMayTinh();
			var giaMax = TimGiaCaoNhat();

			foreach (var mt in dsMayTinh)
			{
				if (giaMax.Equals(mt.TongGia()))
					ketQua.Them(mt);
			}

			return ketQua;
		}

		public DanhSachMayTinh TimMayTinhCoCpuReNhat()
		{
			return TimMayTinhCoThietBiReNhat(LoaiThietBi.CPU);
		}

		public DanhSachMayTinh TimMayTinhCoRamNhat()
		{
			return TimMayTinhCoThietBiReNhat(LoaiThietBi.RAM);
		}

		private DanhSachMayTinh TimMayTinhCoThietBiReNhat(LoaiThietBi loaiTb)
		{
			var giaMin = TimGiaReNhatTheoLoaiThietBi(loaiTb);
			var ketQua = new DanhSachMayTinh();

			foreach (var mt in dsMayTinh)
			{
				var dsThietBi = mt.TimThietBiTheoLoai(loaiTb);
				var timThay = false;

				foreach (var tb in dsThietBi)
				{
					if (giaMin.Equals(tb.Gia))
					{
						timThay = true;
						break;
					}
				}

				if (timThay) ketQua.Them(mt);
			}

			return ketQua;
		}

		private float TimGiaReNhatTheoLoaiThietBi(LoaiThietBi loaiTb)
		{
			var giaMin = float.MaxValue;

			foreach (var mt in dsMayTinh)
			{
				var dsThietBi = mt.TimThietBiTheoLoai(loaiTb);

				foreach (var tb in dsThietBi)
				{
					if (giaMin > tb.Gia)
						giaMin = tb.Gia;
				}
			}

			return giaMin;
		}

		/*public List<string> TimHangXuatHienNhieuNhat()
		{
			var dict = new Dictionary<string, int>();
			var soLanXhMax = 0;

			foreach (var mt in dsMayTinh)
			{
				var demTheoHang = mt.DemSoThietBiTheoTungHang(LoaiThietBi.ALL);

				foreach (var kvp in demTheoHang)
				{
					if (dict.ContainsKey(kvp.Key))
						dict[kvp.Key] += kvp.Value;
					else
						dict[kvp.Key] = kvp.Value;

					if (dict[kvp.Key] > soLanXhMax)
						soLanXhMax = dict[kvp.Key];
				}
			}

			var ketQua = new List<string>();
			foreach (var item in dict)
			{
				if (item.Value == soLanXhMax)
					ketQua.Add(item.Key);
			}

			return ketQua;
		}*/

		public int DemThietBiTheoHang(string hang)
		{
			var tongSoTb = 0;

			foreach (var mt in dsMayTinh)
			{
				tongSoTb += mt.DemThietBiTheoHang(LoaiThietBi.ALL, hang);
			}

			return tongSoTb;
		}

		public int DemThietBiTheoHang(LoaiThietBi loai, string hang)
		{
			var tongSoTb = 0;

			foreach (var mt in dsMayTinh)
			{
				tongSoTb += mt.DemThietBiTheoHang(loai, hang);
			}

			return tongSoTb;
		}

		
		public void SapXep(KieuSapXep kieuSapXep, ThuTu thuTuSx)
		{
			for (int i = 0; i < dsMayTinh.Count - 1; i++)
			{
				for (int j = i + 1; j < dsMayTinh.Count; j++)
				{
					if (SoSanh(dsMayTinh[i], dsMayTinh[j], kieuSapXep) * (int)thuTuSx > 0)
					{
						MayTinh tam = dsMayTinh[i];
						dsMayTinh[i] = dsMayTinh[j];
						dsMayTinh[j] = tam;
					}
				}
			}
		}

		private int SoSanh(MayTinh x, MayTinh y, KieuSapXep ksx)
		{
			switch (ksx)
			{
				case KieuSapXep.TheoDungLuongRam:
					return x.TongDungLuongRam().CompareTo(y.TongDungLuongRam());
				default:
					return x.SoThietBi().CompareTo(y.SoThietBi());
			}
		}

		public override string ToString()
		{
			var sb = new StringBuilder();

			foreach (var mt in dsMayTinh)
			{
				sb.AppendLine(mt.ToString());
			}

			return sb.ToString();
		}

		public void ThemDanhSachHang(List<string> kq, List<string> hang)
		{
			foreach (var item in hang)
			{
				if (!kq.Contains(item))
					kq.Add(item);
			}
		}
		public List<string> TimDanhSachHang()
		{
			List<string> kq = new List<string>();
			foreach (var mt in dsMayTinh)
			{
				ThemDanhSachHang(kq, mt.TimDanhSachHang());
			}
			return kq;
		}
		public int TimThietBiNhieuNhat(LoaiThietBi loai)
		{
			int max = -1;
			//List<string> ds = TimDanhSachHang();
			foreach (var item in ThuVienDungChung.dsHang)
			{
				int tam = DemThietBiTheoHang(loai,item);
				if (max < tam)
					max = tam;
			}
			return max;
		}
		public List<string> TimHangXuatHienNhieuNhat(LoaiThietBi loai)
		{
			List<string> kq = new List<string>();
			int max = TimThietBiNhieuNhat(loai);
			//List<string> ds = TimDanhSachHang();
			foreach (var item in ThuVienDungChung.dsHang)
			{
				int tam = DemThietBiTheoHang(item);
				if (tam == max)
					kq.Add(item);
			}
			return kq;
		}

		
	}
}