using System;
using System.Collections.Generic;
using System.Text;

namespace BÀI_TẬP
{
    internal class Exercises_5
    {
        
        public static void Main(string[] args)
        {
            ex_01();
            ex_02();

        }
        // Bài 1: Tìm số lớn nhất trong 3 số nguyên
        static void ex_01()
        {
            Console.Write("Nhap so thu nhat: ");
            int so_1 = int.Parse(Console.ReadLine());
            Console.Write("Nhap so thu hai: ");
            int so_2 = int.Parse(Console.ReadLine());
            Console.Write("Nhap so thu ba: ");
            int so_3 = int.Parse(Console.ReadLine());
            int max = so_1;
            if (max < so_2 && so_2 > so_3)
                max = so_2;
            else if (max < so_3 && so_3 > so_2)
                max = so_3;
            Console.WriteLine($"So lon nhat cua 3 so {so_1},{so_2},{so_3} la so {max}");
        }

        // Bài 2: Tính giai thừa của một số nguyên dương
        static void ex_02()
        {
            Console.Write("Nhap mot so nguyen duong: ");
            int n = int.Parse(Console.ReadLine());
            long giai_thua = 1;
            for (int i = 1; i <= n; i++)
            {
                giai_thua *= i;
            }
            Console.WriteLine($"Giai thua cua {n} la {giai_thua}");

            // Bai 3: Kiểm tra số nguyên tố 
            static bool IsPrime(int n)
            {
                if (n < 2)
                    return false;
                for ( int i = 2; i <= )
            }
        }
        



    }
}

