namespace QuanLyMayTinh
{
	public class Chuot : IThietBi
	{
		private float _gia;
		private string _hangSx;

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

		public Chuot()
		{
		}

		public Chuot(string hang, float gia)
		{
			_hangSx = hang;
			_gia = gia;
		}

		public Chuot(string line)
		{
			string[] s = line.Split(',');

			HangSx = s[1];
			Gia = float.Parse(s[2]);
		}

		public override string ToString()
		{
			return "Chuot hang " + HangSx + " gia = " + Gia;
		}
	}
}