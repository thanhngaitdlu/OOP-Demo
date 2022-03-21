using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vidu1
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.OutputEncoding = Encoding.UTF8;
			CatList dsMeo = new CatList();

			//Cat miluCat = new Cat();
			//miluCat.Name = "Milu";
			//miluCat.FurColor = "Nâu";

			//dsMeo.Add(miluCat);
			

			//Cat pepy = new Cat("Pepy", "Trang hong");
			//dsMeo.Add(pepy);

			//Cat kitty = new Cat("Kitty", "Trang");
			//dsMeo.Add(kitty);

			//Cat mitty = new Cat("Mitty", "Trang hong vang");
			//dsMeo.Add(mitty);

			dsMeo.AddFromFile();
			dsMeo.PrintList();

			Console.Write("\nNhập tên con mèo cần tìm: ");
			var ten = Console.ReadLine();
			int hoctu = dsMeo.FindCatByName(ten);

			Console.WriteLine("Con mèo bạn cần tìm ở hộc tủ số " + hoctu);

			Console.Write("\nNhập mau con mèo cần tìm: ");
			var mau = Console.ReadLine();

			List<Cat> list = dsMeo.FindCatsByFurColor(mau);

			foreach (var cat in list)
			{
				Console.WriteLine(cat.ToString());
			}

			Console.ReadKey();
		}
	}
}
