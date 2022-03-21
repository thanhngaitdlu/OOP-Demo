using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyHinhHoc
{
	class HinhVuong : HinhHoc
	{
		public float canh;

		public HinhVuong()
		{
			
		}

		public HinhVuong(float c)
		{
			canh = c;
		}

		public float TinhDT()
		{
			return canh*canh;
		}

		public float TinhCV()
		{
			return canh*4;
		}
		public override string ToString()
		{
			return "Hinh vuong canh " + canh + " dien tich " + TinhDT();
		}
	}
}
