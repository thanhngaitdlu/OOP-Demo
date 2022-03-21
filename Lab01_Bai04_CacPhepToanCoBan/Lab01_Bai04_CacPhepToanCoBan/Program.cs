using System;


namespace Lab01_Bai04_CacPhepToanCoBan
{
	class Program
	{
		static void Main(string[] args)
		{
			/*
			int x = 12, y = 5, ketQua;
			// ===================================================================
			// Các phép toán số học
			ketQua = x + y;        // Phép cộng
			Console.WriteLine("{0} + {1} = {2}", x, y, ketQua);

			ketQua = x - y;       // Phép trừ
			Console.WriteLine("{0} - {1} = {2}", x, y, ketQua);

			ketQua = x * y;      // Phép nhân
			Console.WriteLine("{0} * {1} = {2}", x, y, ketQua);

			ketQua = x / y;      // Phép chia
			Console.WriteLine("{0} / {1} = {2}", x, y, ketQua);

			ketQua = x % y;      // Phép chia lấy dư
			Console.WriteLine("{0} % {1} = {2}", x, y, ketQua);

			//===================================================================
			// Các toán tử thao tác bit
			ketQua = ~x;            // Phép đảo bit 0-1
			Console.WriteLine("y = {0}, Ket qua = {1}", y, ketQua);

			ketQua = x | y;            // Phép OR theo bit
			Console.WriteLine("{0} | {1} = {2}",x, y, ketQua);

			ketQua = x & y;            // Phép AND theo bit
			Console.WriteLine("{0} & {1} = {2}",x, y, ketQua);

			ketQua = x << y;            // Phép dịch trái
			Console.WriteLine("{0} << {1} = {2}", x, y, ketQua);

			ketQua = x >> y;            // Phép dịch phải
			Console.WriteLine("{0} >> {1} = {2}", x, y, ketQua);

			//=================================================================
			// Các toán tử so sánh
			bool logic = false;

			logic = x < y;             // Nhỏ hơn
			Console.WriteLine("{0} < {1} : {2}", x, y, logic);

			logic = x <= y;             // Nhỏ hơn hoặc bằng
			Console.WriteLine("{0} <= {1} : {2}", x, y, logic);

			logic = x > y;             // Lớn hơn
			Console.WriteLine("{0} > {1} : {2}", x, y, logic);

			logic = x == y;             // So sánh bằng
			Console.WriteLine("{0} == {1} : {2}", x, y, logic);

			logic = x != y;             // Khác nhau
			Console.WriteLine("{0} != {1} : {2}", x, y, logic);
			*/
			bool p = true, q = false;
			bool logic;

			logic = !p;
			Console.WriteLine("!{0} = {1}", p, logic);

			logic = p && q;
			Console.WriteLine("{0} && {1} = {2}", p, q, logic);

			logic = p || q;
			Console.WriteLine("{0} || {1} = {2}", p, q, logic);







		}
	}
}
