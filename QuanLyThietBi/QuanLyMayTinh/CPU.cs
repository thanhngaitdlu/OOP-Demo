namespace QuanLyMayTinh
{
	public class CPU : IThietBi
	{
		private float _gia;
		private string _hangSx;
		private float _tocDo;

		public float Gia
		{
			get { return _gia; }
			set { _gia = value; }
		}

		public string HangSx
		{
			get { return _hangSx; }
			set
			{
				_hangSx = value;
				ThuVienDungChung.Them(_hangSx);
			}
		}

		public float TocDo
		{
			get { return _tocDo; }
			set { _tocDo = value; }
		}

		public CPU()
		{
		}

		public CPU(string hang, float gia, float tocDo)
		{
			_hangSx = hang;
			_gia = gia;
			_tocDo = tocDo;
		}

		public CPU(string line)
		{
			string[] s = line.Split(',');

			HangSx = s[1];
			Gia = float.Parse(s[2]);
		}

		public override string ToString()
		{
			return "CPU hang " + HangSx + " gia = " + Gia;
		}
	}
}