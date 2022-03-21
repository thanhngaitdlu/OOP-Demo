using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vidu1
{
	public class CatList
	{
		private List<Cat> _catList;
		//private int _numOfCats;

		public CatList()
		{
			_catList = new List<Cat>();
			//_numOfCats = 0;
		}

		public void Add(Cat cat)
		{
			_catList.Add(cat);
		}

		public void AddFromFile()
		{
			StreamReader reader = new StreamReader("data.txt");

			var line="";

			while ((line = reader.ReadLine()) != null)
			{
				Cat cat = new Cat(line);
				_catList.Add(cat);
			}
		}

		public void PrintList()
		{
			// for (int i = 0; i < _numOfCat; i++)
			foreach (var cat in _catList)
			{
				Console.WriteLine(cat);
			}
		}

		// Tìm con mèo có tên đầu tiên trong danh sách
		public int FindCatByName(string catName)
		{
			for (int i = 0; i < _catList.Count; i++)
			{
				if (_catList[i].Name.ToLower() == catName.ToLower())
				{
					return i;
				}
			}
			return -1;

		}

		// Tìm tất cả những con mèo có chứa màu vàng
		public List<Cat> FindCatsByFurColor(string color)
		{
			List<Cat> result = new List<Cat>();

			for (int i = 0; i < _catList.Count; i++)
			{
				var furColor = _catList[i].FurColor.ToLower();
				if (furColor.Contains(color.ToLower()))
				{
					result.Add(_catList[i]);
				}
			}
			return result;
		}
	}
}
