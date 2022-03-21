using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSinhVien
{
	public class DSSinhVien
	{
		public List<SinhVien> DanhSach { get; set; }

		public DSSinhVien()
		{
			DanhSach = new List<SinhVien>();
		}

		public void Add(SinhVien sv)
		{
			DanhSach.Add(sv);
		}

		public void AddFromFile(string fileName)
		{

			using (var stream = new FileStream(fileName, FileMode.Open, FileAccess.Read))
			{
				using (var reader = new StreamReader(stream))
				{
					var line = "";

					while ((line = reader.ReadLine()) != null)
					{
						var sv = new SinhVien(line);
						DanhSach.Add(sv);
					}
				}
			}	
		}

		private int TimSVTheoMSSV(string ms)
		{
			for (int i = 0; i < DanhSach.Count; i++)
			{
				if (DanhSach[i].MSSV == ms)
					return i;
			}
			return -1;
		}

		public List<SinhVien> TimSVTheoTen(string ten)
		{
			var kq = new List<SinhVien>();
			for (int i = 0; i < DanhSach.Count; i++)
			{
				if (DanhSach[i].Ten.StartsWith(ten))
					kq.Add(DanhSach[i]);
			}
			return kq;
		}

		public List<SinhVien> TimSVBatDauMaSo(string ms)
		{
			var kq = new List<SinhVien>();
			for (int i = 0; i < DanhSach.Count; i++)
			{
				if (DanhSach[i].MSSV.StartsWith(ms))
					kq.Add(DanhSach[i]);
			}
			return kq;
		}
		

		public bool SuaSinhVienTheoMSSV(string mssv, string hoVaTenLot, string ten, DateTime ngaySinh, string phai, double diem)
		{
			var vt = TimSVTheoMSSV(mssv);
			if (vt == -1)return false;

			DanhSach[vt].HoVaTenLot= hoVaTenLot;
			DanhSach[vt].Ten = ten;
			DanhSach[vt].NgaySinh = ngaySinh;
			DanhSach[vt].Phai = phai;
			DanhSach[vt].Diem = diem;
			return true;
		}

		public void LuuDanhSach(string fileName)
		{
			
			using (var stream = new FileStream(fileName, FileMode.Create, FileAccess.Write))
			{
				using (var writer = new StreamWriter(stream))
				{
					foreach (var sv in DanhSach)
					{
						writer.WriteLine(sv);
					}
				}
			}
		}

		public void XoaSV(string mssv)
		{
			var vt = TimSVTheoMSSV(mssv);
			DanhSach.RemoveAt(vt);
		}

		private double TimDiemCaoNhat()
		{
			double max = 0;
			foreach (var sinhVien in DanhSach)
			{
				if (sinhVien.Diem > max)
					max = sinhVien.Diem;
			}
			return max;
		}

		public List<SinhVien> TimSVDiemCaoNhat()
		{
			var kq = new List<SinhVien>();
			var max = TimDiemCaoNhat();

			foreach (var sinhVien in DanhSach)
			{
				if (sinhVien.Diem == max )
					kq.Add(sinhVien);
			}
			return kq;
		}

		public List<SinhVien> TimSVDiemLonHon(double diem)
		{
			var kq = new List<SinhVien>();

			foreach (var sinhVien in DanhSach)
			{
				if (sinhVien.Diem >= diem)
					kq.Add(sinhVien);
			}
			return kq;
		}
	}
}
