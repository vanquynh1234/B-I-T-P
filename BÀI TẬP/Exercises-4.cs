using System;
using System.Collections.Generic;
using System.Text;

namespace BÀI_TẬP
{
    internal class Exercises_4
    {
        public static void MainBai4(string[] args)
        {
            ex_01();
            ex_02();
            ex_03();
            ex_04();
            ex_05();
            ex_06();
            ex_07();
            ex_08();
            ex_09();
            ex_10();
            ex_11();
        }
        //1. Write a C# Sharp program to check whether a given number is even or odd
        static void ex_01()
        {
            Console.Write("Nhap 1 so bat ky: ");
            int so = int.Parse(Console.ReadLine());
            if (so % 2 == 0)
                Console.WriteLine($"{so} la so chan");
            else
                Console.WriteLine($"{so} la so le");
        }

        //2. Write a C# Sharp program to find the largest of three numbers
        static void ex_02()
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
        //3. Write a C# Sharp program to accept a coordinate point in an XY coordinate system and determine in which quadrant the coordinate point lies
        static void ex_03()
        {
            Console.Write("Input the value for X coordinate: ");
            int x = int.Parse(Console.ReadLine());

            Console.Write("Input the value for Y coordinate: ");
            int y = int.Parse(Console.ReadLine());
            if (x > 0 && y > 0)
            {
                Console.WriteLine($"The coordinate point ({x},{y}) lies in the First quadrant.");
            }
            else if (x < 0 && y > 0)
            {
                Console.WriteLine($"The coordinate point ({x},{y}) lies in the Second quadrant.");
            }
            else if (x < 0 && y < 0)
            {
                Console.WriteLine($"The coordinate point ({x},{y}) lies in the Third quadrant.");
            }
            else if (x > 0 && y < 0)
            {
                Console.WriteLine($"The coordinate point ({x},{y}) lies in the Fourth quadrant.");
            }
            else
            {
                Console.WriteLine($"The coordinate point ({x},{y}) lies at the origin.");
            }
        }

        //4. Write a program to check whether a triangle is Equilateral, Isosceles or Scalene
        static void ex_04()
        {
            Console.Write("Nhap canh m: ");
            double m = double.Parse(Console.ReadLine());
            Console.Write("Nhap canh n: ");
            double n = double.Parse(Console.ReadLine());
            Console.Write("Nhap canh p: ");
            double p = double.Parse(Console.ReadLine());
            if (m + n > p && m + p > n && n + p > m)
            {
                if (m == n && n == p)
                    Console.WriteLine("Day la tam giac deu");
                else if (m == n || m == p || n == p)
                    Console.WriteLine("Day la tam giac can");
                else
                    Console.WriteLine("Day la tam giac thuong");
            }
            else
                Console.WriteLine("Ba canh khong tao thanh tam giac.");
        }

        //5. Write a program to read 10 numbers and find their average and sum
        static void ex_05()
        {
            int sum = 0;
            for (int i = 1; i <= 10; i++)
            {
                Console.Write("Nhap so thu " + i + ": ");
                int number = int.Parse(Console.ReadLine());
                sum += number;
            }
            double average = sum / 10.0;

            Console.WriteLine("Tong = " + sum);
            Console.WriteLine("Trung binh cong = " + average);
        }

        //6. Write a program to display the multiplication table of a given integer
        static void ex_06()
        {
            Console.Write("Nhap mot so nguyen: ");
            int a6 = int.Parse(Console.ReadLine());
            Console.WriteLine("Bang cuu chuong cua " + a6 + ":");
            for (int i = 1; i <= 10; i++)
                Console.WriteLine($"{a6} x {i} = {a6 * i}");
        }

        //7. Write a program to display a pattern like triangles with a number
        static void ex_07()
        {
            Console.Write("Nhap so dong: ");
            int a7 = int.Parse(Console.ReadLine());
            for (int i7 = 1; i7 <= a7; i7++)
            {
                for (int j7 = 1; j7 <= i7; j7++)
                    Console.Write(j7);
                Console.WriteLine();
            }
        }

        //8. The patterns like
        static void ex_08()
        {
            // Hình 1
            for (int i8a = 1; i8a <= 4; i8a++)
            {
                for (int j8a = 1; j8a <= i8a; j8a++)
                    Console.Write(j8a);
            }
            Console.WriteLine();
            //  Hình 2
            int num2 = 1;
            for (int i8b = 1; i8b <= 4; i8b++)
            {
                for (int j8b = 1; j8b <= i8b; j8b++)
                    Console.Write(num2 + " ");
                num2++;
            }
            Console.WriteLine();
            // Hình 3
            int num3 = 1;
            int rows = 4;
            for (int i8c = 1; i8c <= rows - i8c; i8c++)
            {
                for (int s8 = 1; s8 <= rows - i8c; s8++)
                    Console.Write(" ");
                for (int j8c = 1; j8c <= i8c; j8c++)
                    Console.Write(num3 + " ");
                num3++;
            }
            Console.WriteLine();
        }

        //9. Write a program to display the n terms of harmonic series and their sum. 1 + 1/2 + 1/3 + 1/4 + 1/5 ... 1/n terms
        static void ex_09()
        {
            Console.Write("Nhap n9: ");
            int n9 = int.Parse(Console.ReadLine());
            double sum9 = 0;
            Console.Write("Day dieu hoa: ");
            for (int i9 = 1; i9 <= n9; i9++)
            {
                sum9 += 1.0 / i9;
                Console.Write("1/" + i9);
                if (i9 < n9)
                    Console.Write(" + ");
            }
            Console.WriteLine();
            Console.WriteLine("Tong = " + sum9);
        }

        //10. Write a program to find the ‘perfect’ numbers within a given number range
        static void ex_10()
        {
            Console.Write("Nhap so can kiem tra ");
            int so_10 = int.Parse(Console.ReadLine());

            int tonguoc = 1;
            for (int i = 2; i <= Math.Sqrt(so_10); i++)
            {
                if (so_10 % i == 0)
                    tonguoc += i;
            }
            if (tonguoc == so_10)
                Console.WriteLine($"{so_10} la so hoan hao");
            else
                Console.WriteLine($"{so_10} khong phai la so hoan hao");
        }

        //11. Write a program to determine whether a given number is prime or not
        static void ex_11()
        {
            Console.WriteLine("Nhap so can kiem tra: ");
            int so_11 = int.Parse(Console.ReadLine());
            if (so_11 < 2)
                Console.WriteLine("Khong phai so nguyen to");
            else
            {
                bool isPrime = true;
                for (int i = 2; i <= Math.Sqrt(so_11); i++)
                {
                    if (so_11 % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                    Console.WriteLine($"{so_11} la so nguyen to");
                else
                    Console.WriteLine($"{so_11} khong phai so nguyen to");
            }
        }
    }
    }
