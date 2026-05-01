using System;
using System.Collections.Generic;
using System.Text;

namespace BÀI_TẬP
{
    internal class Exercises_1
    {
        private static void MainBai1(string[] args)
        {
            Console.WriteLine("Hello, teacher!");
            // 1. Cộng 2 số
            int n1 = 30, n2 = 20;
            Console.WriteLine("Bai 1: Tong la " + (n1 + n2));

            // 2. Hoán đổi
            int a = 6, b = 10;
            int temp = a; a = b; b = temp;
            Console.WriteLine($"Bai 2: Sau hoan doi a={a}, b={b}");

            // 3. Nhân số thực
            float f1 = 1.5f, f2 = 2.0f;
            Console.WriteLine("Bai 3: Tich so thuc = " + (f1 * f2));

            // 4. Feet sang Meter
            double feet = 10;
            Console.WriteLine($"Bai 4: {feet} feet = {feet * 0.3048} meter");

            // 5. C sang F
            double c = 40;
            Console.WriteLine($"Bai 5: {c}C = {(c * 9 / 5) + 32}F");

            // 6. Size of types
            Console.WriteLine($"Bai 6: int size = {sizeof(int)} bytes");

            // 7. ASCII
            char ch = 'A';
            Console.WriteLine($"Bai 7: ASCII cua {ch} la {(int)ch}");

            // 8. Dien tich hinh tron
            double r = 5;
            Console.WriteLine("Bai 8: Dien tich hinh tron = " + (Math.PI * r * r));

            // 9. Dien tich hinh vuong
            double canh = 5;
            Console.WriteLine("Bai 9: Dien tich hinh vuong = " + (canh * canh));

            // 10. Doi ngay
            int totalDays = 400;
            int y = totalDays / 365;
            int w = (totalDays % 365) / 7;
            int d = (totalDays % 365) % 7;
            Console.WriteLine($"Bai 10: {totalDays} ngay = {y} nam, {w} tuan, {d} ngay");
        }
    }
}
