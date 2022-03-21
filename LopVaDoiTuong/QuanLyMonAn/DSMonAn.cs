using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyMonAn
{
	public class DSMonAn
	{
		public List<MonAn> DsMonAn;

		public DSMonAn()
		{
			DsMonAn = new List<MonAn>();
		}

		public void Add(MonAn cat)
		{
			DsMonAn.Add(cat);
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

		// Tìm vị trí đầu tiên của món ăn có đơn giá cao nhất

		// Tìm món ăn theo đơn vị tính

		// Tìm các món ăn theo nhóm

		// Tìm các món ăn có giá nằm trong khoảng min, max

		// Tìm các món ăn có đơn giá nhỏ hơn giá nhập vào


	}
}
