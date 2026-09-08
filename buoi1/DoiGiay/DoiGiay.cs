using System;
namespace LapTrinhCSharp.Buoi1;
public class DoiGiay
{
	public static void Main()
	{
		Console.Write("Nhap so gio:");
		int gio = int.Parse(Console.ReadLine() ?? "0");

		Console.Write("Nhap so phut:");
		int phut = int.Parse(Console.ReadLine() ?? "0");

		Console.Write("Nhap so giay:");
		int giay = int.Parse(Console.ReadLine() ?? "0");

		int tongSoGiay = gio * 3600 + phut * 60 + giay;

		Console.WriteLine($"Tong so giay cua {gio}:{phut}:{giay} la {tongSoGiay} giay");
	}
}
