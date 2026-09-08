using System;

namespace LapTrinhCSharp.Buoi1;

internal class InNhan
{
    static void Main(string[] args)
    {
        //in các dòng ra màn hình console
        Console.Write("Nhap ho ten: ");
        string hoTen = Console.ReadLine()!;
        //in các dòng ra màn hình console
        Console.WriteLine("**************************");
        Console.WriteLine("* Truong: Dai Hoc HUFLIT *");
        Console.WriteLine("* Khoa: CNTT             *");
        Console.WriteLine($"* Ho ten: {hoTen,-15}*");
        Console.WriteLine("**************************");
    }
}