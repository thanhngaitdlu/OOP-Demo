using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyHinhHoc
{
	class DanhSachHinhHoc
	{
		List<HinhHoc> dsHinhHoc = new List<HinhHoc>();

		public void Them(HinhHoc hh)
		{
			dsHinhHoc.Add(hh);
		}

		public override string ToString()
		{
			StringBuilder sb = new StringBuilder();

			foreach (var item in dsHinhHoc)
			{
				sb.AppendLine(item.ToString());
			}

			return sb.ToString();
		}

		public void NhapTuFile(string fileName)
		{
			StreamReader reader = new StreamReader(fileName);
			string str = "", type;
			HinhHoc hh = new HinhHoc();

			while ((str = reader.ReadLine()) != null)
			{
				string[] line = str.Split(' ');
				type = line[0];

				switch (type)
				{
					case "HV":
						hh = new HinhVuong(float.Parse(line[1].Trim()));
						break;
					case "HT":
						hh = new HinhTron(float.Parse(line[1].Trim()));
						break;
					case "HCN":
						hh = new HinhChuNhat(float.Parse(line[1]), float.Parse(line[1]));
						break;
				}

				Them(hh);
			}
		}

		private float TinhDienTich(HinhHoc hinh)
		{
			if (hinh is HinhVuong) return ((HinhVuong) hinh).TinhDT();
			if (hinh is HinhChuNhat) return ((HinhChuNhat)hinh).TinhDT();
			if (hinh is HinhTron) return ((HinhTron)hinh).TinhDT();
			return 0;
		}

		private KieuHinh LayKieuHinh(HinhHoc hinh)
		{
			if (hinh is HinhVuong) return KieuHinh.HinhVuong;
			if (hinh is HinhChuNhat) return KieuHinh.HinhChuNhat;
			if (hinh is HinhTron) return KieuHinh.HinhTron;
			return KieuHinh.TatCa;
		}

		private bool TrungKieuHinh(HinhHoc hinh, KieuHinh kieu)
		{
			return kieu == KieuHinh.TatCa ||
			       (hinh is HinhTron && kieu == KieuHinh.HinhTron) ||
			       (hinh is HinhVuong && kieu == KieuHinh.HinhVuong) ||
			       (hinh is HinhChuNhat && kieu == KieuHinh.HinhChuNhat);
		}

		public float TimDienTichLonNhat()
		{
			float max = 0;

			foreach (var item in dsHinhHoc)
			{
				float dt = TinhDienTich(item);

				if (dt > max)
					max = dt;
			}

			return max;
		}

		public float TinhTongDienTich()
		{
			float sum = 0;

			foreach (var item in dsHinhHoc)
			{
				sum += TinhDienTich(item);
			}

			return sum;
		}

		public DanhSachHinhHoc TimHinhTheoDienTich(float dienTich)
		{
			DanhSachHinhHoc kq = new DanhSachHinhHoc();

			foreach (var item in dsHinhHoc)
			{
				float dt = TinhDienTich(item);

				if (dt.Equals(dienTich))
					kq.Them(item);
			}

			return kq;
		}

		public DanhSachHinhHoc TimHinhTheoKieuHinh(KieuHinh kieu)
		{
			DanhSachHinhHoc kq = new DanhSachHinhHoc();

			foreach (var item in dsHinhHoc)
			{
				//if (kieu == KieuHinh.TatCa || LayKieuHinh(item) == kieu)
				if (TrungKieuHinh(item, kieu))
					kq.Them(item);
			}

			return kq;
		}

		public float TimDienTichHinhVuongLonNhat()
		{
			float max = 1;

			foreach (var item in dsHinhHoc)
			{
				if (item is HinhVuong)
				{
					float dt = ((HinhVuong) item).TinhDT();
					if (dt > max)
						max = dt;
				}
			}
			return max;
		}

		public DanhSachHinhHoc TimHinhVuongCoDienTichLonNhat()
		{
			//DanhSachHinhHoc kq = new DanhSachHinhHoc();
			//float max = TimDienTichHinhVuongLonNhat();

			//foreach (var item in dsHinhHoc)
			//{
			//	if (item is HinhVuong)
			//	{
			//		float dt = ((HinhVuong)item).TinhDT();
			//		if (dt == max)
			//			//kq.Them(item);
			//			dsHinhHoc.Sort();
			//	}
			//}

			//return kq;

			DanhSachHinhHoc dshv = TimHinhTheoKieuHinh(KieuHinh.HinhVuong);
			float dienTichMax = dshv.TimDienTichLonNhat();
			return dshv.TimHinhTheoDienTich(dienTichMax);
		}

		public KieuHinh TimKieuHinhCoDienTichLonNhat()
		{
			float dienTichMax = 0;
			KieuHinh kieuHinhKq = KieuHinh.TatCa;

			for (int i = 1; i < 4; i++)
			{
				KieuHinh kieuCanTim = (KieuHinh) i;
				DanhSachHinhHoc ds = TimHinhTheoKieuHinh(kieuCanTim);
				float tongDienTich = ds.TinhTongDienTich();

				if (tongDienTich > dienTichMax)
				{
					tongDienTich = dienTichMax;
					kieuHinhKq = kieuCanTim;
				}
			}

			return kieuHinhKq;
		}

		public void SapXep(KieuSoSanh kieuSo, ThuTu thuTu)
		{
			for (int i = 0; i < dsHinhHoc.Count - 1; i++)
			{
				for (int j = i + 1; j < dsHinhHoc.Count; j++)
				{
					if (SoSanhHinh(dsHinhHoc[i], dsHinhHoc[j], kieuSo)*(int) thuTu > 0)
					{
						HinhHoc tam = dsHinhHoc[i];
						dsHinhHoc[i] = dsHinhHoc[j];
						dsHinhHoc[j] = tam;
					}
				}
			}			
		}

		public int SoSanhHinh(HinhHoc x, HinhHoc y, KieuSoSanh kieu)
		{
			switch (kieu)
			{
				case KieuSoSanh.DienTich:
					return TinhDienTich(x).CompareTo(TinhDienTich(y));
				case KieuSoSanh.DienTichHinhVuong:
					return TrungKieuHinh(x, KieuHinh.HinhVuong) && TrungKieuHinh(y, KieuHinh.HinhVuong)
						? TinhDienTich(x).CompareTo(TinhDienTich(y))
						: 0;
			}

			return 0;
		}
	}
}
