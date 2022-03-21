using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01_BaiTapThem09
{
	class Program
	{
		static void Main(string[] args)
		{
			int num1, num2, temp1, temp2;

			Console.Write("Nhap vao so thu nhat a = ");
			num1 = int.Parse(Console.ReadLine());
			Console.Write("Nhap vao so thu hai b = ");
			num2 = int.Parse(Console.ReadLine());
			temp1 = num1;
			temp2 = num2;
			while (temp1 != temp2)
			{
				if (temp1 > temp2)
					temp1 -= temp2;
				else
					temp2 -= temp1;

				//if (temp1 > temp2)
				//	temp1 %= temp2;
				//else
				//	temp2 %= temp1;
			}
			Console.WriteLine("Uoc chung lon nhat cua {0} va {1} la {2}", num1, num2, temp2);
			Console.WriteLine("Boi chung nho nhat cua {0} va {1} la {2}", num1, num2, num1*num2/temp2);
		}
	}
}
