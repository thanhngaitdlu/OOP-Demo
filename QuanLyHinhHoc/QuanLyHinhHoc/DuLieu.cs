using System.IO;

namespace QuanLyHinhHoc
{
	class DuLieu
	{
		public static DanhSachHinhHoc DocTuFile(string fileName)
		{
			DanhSachHinhHoc ds = new DanhSachHinhHoc();
			StreamReader reader = new StreamReader(fileName);
			string str = "", type;
			
			while ((str = reader.ReadLine()) != null)
			{
				string[] line = str.Split(' ');
				type = line[0];
				HinhHoc hh = null;

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

				if (hh != null) ds.Them(hh);
			}

			return ds;
		}

		public static void LuuXuongFile(string fileName, DanhSachHinhHoc dshh)
		{
			
		}
	}
}