using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyHinhHoc
{
	class HinhChuNhat : HinhHoc
	{
		public float chieuDai;
		public float chieuRong;

		public HinhChuNhat()
		{
			
		}

		public HinhChuNhat(float cd, float cr)
		{
			chieuDai = cd;
			chieuRong = cr;
		}

		public float TinhDT()
		{
			return chieuDai * chieuRong;
		}

		public float TinhCV()
		{
			return 2*(chieuDai + chieuRong);
		}
		public override string ToString()
		{
			return "Hinh chu nhat chieu dai " + chieuDai + " chieu rong " + chieuRong + " dien tich " + TinhDT();
		}
	}
}
