using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyHinhHoc
{
	class HinhTron : HinhHoc
	{
		public float banKinh;

		public HinhTron()
		{
			
		}

		public HinhTron(float r)
		{
			banKinh = r;
		}

		public float TinhDT()
		{
			return (float)Math.Round(Math.PI * banKinh * banKinh, 2);
		}

		public float TinhCV()
		{
			return (float)Math.Round(Math.PI * banKinh * 2, 2);
		}
		public override string ToString()
		{
			return string.Format("Ban kinh: {0:F2}. Dien tich: {1:F2}. Chu vi: {2:F2}", banKinh, TinhDT(), TinhCV());
		}
	}
}
