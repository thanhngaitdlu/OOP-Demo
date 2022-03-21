namespace QuanLyMayTinh
{
	public class RAM : IThietBi
	{
		private float _gia;
		private string _hangSx;
		private int _dungLuong;

		public float Gia
		{
			get { return _gia; }
			set { _gia = value; }
		}

		public string HangSx
		{
			get { return _hangSx; }
			set { _hangSx = value; }
		}

		public int DungLuong
		{
			get { return _dungLuong; }
			set { _dungLuong = value; }
		}

		public RAM()
		{
		}

		public RAM(string hang, float gia, int dungLuong)
		{
			_hangSx = hang;
			_gia = gia;
			_dungLuong = dungLuong;
		}

		public RAM(string line)
		{
			string[] s = line.Split(',');

			HangSx = s[1];
			Gia = float.Parse(s[2]);
		}

		public override string ToString()
		{
			return "RAM hang " + HangSx + " gia = " + Gia;
		}
	}
}