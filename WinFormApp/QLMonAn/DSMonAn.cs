using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLMonAn
{
	public class DSMonAn
	{
		public List<MonAn> DsMonAn;

		public DSMonAn()
		{
			DsMonAn = new List<MonAn>();
		}

		public void Add(MonAn monAn)
		{
			DsMonAn.Add(monAn);
		}

		public void AddFromFile()
		{
			StreamReader reader = new StreamReader("data.txt");

			var line = "";

			while ((line = reader.ReadLine()) != null)
			{
				MonAn monAn = new MonAn(line);
				DsMonAn.Add(monAn);
			}
		}

		public void XuatDanhSach()
		{
			// for (int i = 0; i < _numOfCat; i++)
			foreach (var monAn in DsMonAn)
			{
				Console.WriteLine(monAn);
			}
		}

		

		public override string ToString()
		{
			return "";
		}

		// Tìm món ăn theo tên
		public int TimTheoTen(string ten)
		{
			for (int i = 0; i < DsMonAn.Count; i++)
			{
				if (DsMonAn[i].TenMonAn.CompareTo(ten) == 0)
					return i;
			}
			return -1;
		}

		public bool SuaMonAnTheoTen(string ten, string donViTinh, string nhom, int donGia)
		{
			int vitri = TimTheoTen(ten);

			if(vitri == -1)
				return false;
			DsMonAn[vitri].NhomMonAn = nhom;
			DsMonAn[vitri].DonViTinh = donViTinh;
			DsMonAn[vitri].DonGia = donGia;
			return true;
		}

		public bool XoaMonAn(string ten)
		{
			int vitri = TimTheoTen(ten);
			if (vitri == -1) return false;

			DsMonAn.RemoveAt(vitri);
			return true;
		}

		// Tìm món ăn theo giá (nhập vào giá, xuất ra món có đơn giá bằng giá nhập vào)
		public List<MonAn> TimMonAnTheoDonGia(int donGia)
		{
			var ds = new List<MonAn>();

			foreach (var monAn in DsMonAn)
			{
				if (monAn.DonGia == donGia)
					ds.Add(monAn);
			}

			return ds;
		}

		// Tìm món ăn có đơn giá cao nhất
		public List<MonAn> TimMonAnCoDGCaoNhat()
		{
			var ds = new List<MonAn>();
			var maxDonGia = TimDonGiaCaoNhat();

			ds = TimMonAnTheoDonGia(maxDonGia);

			return ds;
		}

		// Tìm món ăn có đơn giá thấp nhất
		public List<MonAn> TimMonAnCoDGThapNhat()
		{
			var ds = new List<MonAn>();
			var minDonGia = TimDonGiaThapNhat();

			ds = TimMonAnTheoDonGia(minDonGia);

			return ds;
		}

		// Tìm đơn giá cao nhất
		public int TimDonGiaCaoNhat()
		{
			var max = DsMonAn[0].DonGia;

			for (int i = 1; i < DsMonAn.Count; i++)
			{
				if (DsMonAn[i].DonGia > max)
					max = DsMonAn[i].DonGia;
			}

			return max;
		}

		public int TimDonGiaThapNhat()
		{
			var min = DsMonAn[0].DonGia;

			for (int i = 1; i < DsMonAn.Count; i++)
			{
				if (DsMonAn[i].DonGia < min)
					min = DsMonAn[i].DonGia;
			}

			return min;
		}
		
		//Tìm theo nhóm
		public List<MonAn> TimTheoNhom(string tenNhom)
		{
			var ketqua = new List<MonAn>();

			foreach (var monAn in DsMonAn)
			{
				if (monAn.NhomMonAn.CompareTo(tenNhom) == 0)
					ketqua.Add(monAn);
			}

			return ketqua;
		}
	}
}
