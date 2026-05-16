using System;
using System.Collections.Generic;
using System.Text;

namespace BÀI_TẬP
{
    internal class Exercises_5
    {
        
        public static void MainBai5(string[] args)
        {
            ex_01();
           

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

       
            }
        }
        



    


