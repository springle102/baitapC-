using System;

namespace LapTrinhCSharp.Buoi1;

public class HinhTron
{
    private const double Pi = 3.14;

    public static void Main(string[] args)
    {
        Console.Write("Nhap ban kinh hinh tron: ");
        if (double.TryParse(Console.ReadLine(), out double r) && r > 0)
        {
            double chuVi = 2 * Pi * r;
            double dienTich = Pi * r * r;

            Console.WriteLine($"Ban kinh: {r}");
            Console.WriteLine($"Chu vi: {chuVi:F2}");
            Console.WriteLine($"Dien tich: {dienTich:F2}");
        }
        else
        {
            Console.WriteLine("Ban kinh khong hop le!");
        }
    }
}