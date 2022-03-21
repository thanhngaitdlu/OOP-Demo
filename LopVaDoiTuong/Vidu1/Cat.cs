using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vidu1
{
	public class Cat
	{
		public string Name { get; set; }

		public string FurColor { get; set; }

		public Cat()
		{
			Name = "khong ten";
			FurColor = "chua biet mau";
		}

		public Cat(string name, string furColor)
		{
			Name = name;
			FurColor = furColor;
		}

		public Cat(string line)
		{
			string[] str = line.Split('^');
			Name = str[0];
			FurColor = str[1];
		}
		public void SayMeoMeo()
		{
			Console.WriteLine("Con meo ten {0} keu meooo meoooo", Name);
		}

		public void Sit(string place)
		{
			Console.WriteLine("Con meo ten {0} dang ngoi o vi tri {1}", Name, place);
		}

		public override string ToString()
		{
			return string.Format("{0, -10} {1, -30}", Name, FurColor);
		}
	}
}
