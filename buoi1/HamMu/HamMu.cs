using System;

namespace LapTrinhCSharp.Buoi1;

internal class HamMu
{
    static void Main(string[] args)
    {
        Console.Write("Nhap so thuc a: ");
        double a = double.Parse(Console.ReadLine()!);

        Console.Write("Nhap so mu n: ");
        int n = int.Parse(Console.ReadLine()!);

        // Sử dụng hàm Math.Pow để tính a lũy thừa n
        double ketQua = Math.Pow(a, n);

        Console.WriteLine($"Ket qua {a}^{n} = {ketQua}");
    }
}