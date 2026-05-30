using System;
using System.Collections.Generic;
using System.Text;

namespace BÀI_TẬP
{
    internal class Exercises_5
    {
        
        
    
        static void Baitap5()
        {
            Console.WriteLine("Bai 1: " + TinhTong(3, 5));
            Console.WriteLine("Bai 2: " + KiemTraChan(4));
            Console.WriteLine("Bai 3: " + TimMax(3, 7, 5));
            Console.WriteLine("Bai 4: " + TinhGiaiThua(5));
            Console.WriteLine("Bai 5: " + DaoNguocChuoi("hello"));

            Console.WriteLine("Bai 6: " + KiemTraNguyenTo(7));
            InFibonacci(6);

            Console.WriteLine("Bai 8: " + DemNguyenAm("Hello World"));
            Console.WriteLine("Bai 9: " + TinhLuyThua(2, 3));
            Console.WriteLine("Bai 10: " + TinhTrungBinh(new int[] { 4, 5, 6, 7 }));

            Console.WriteLine("Bai 11: " + KiemTraDoiXung("radar"));
            Console.WriteLine("Bai 12: " + CelsiusToFahrenheit(25));
            Console.WriteLine("Bai 13: " + TimMin(new int[] { 10, 5, 8, 2, 9 }));

            Console.WriteLine("Bai 14: " + TongCacChuSo(1234));

            int[] arr = { 3, 1, 4, 2 };
            SapXepMang(arr);

            Console.WriteLine("Bai 16: " + XoaTrungLap("programming"));
            Console.WriteLine("Bai 17: " + UCLN(12, 18));
            Console.WriteLine("Bai 18: " + DecimalToBinary(10));
            Console.WriteLine("Bai 19: " + KiemTraNamNhuan(2024));
            Console.WriteLine("Bai 20: " + DemSoTu("Hoc lap trinh C# rat thu vi"));
        }

        // 1
        static int TinhTong(int a, int b) => a + b;

        // 2
        static bool KiemTraChan(int n) => n % 2 == 0;

        // 3
        static int TimMax(int a, int b, int c) => Math.Max(Math.Max(a, b), c);

        // 4
        static long TinhGiaiThua(int n)
        {
            long result = 1;
            for (int i = 1; i <= n; i++) result *= i;
            return result;
        }

        // 5
        static string DaoNguocChuoi(string input)
        {
            char[] arr = input.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }

        // 6
        static bool KiemTraNguyenTo(int n)
        {
            if (n < 2) return false;
            for (int i = 2; i <= Math.Sqrt(n); i++)
                if (n % i == 0) return false;
            return true;
        }

        // 7
        static void InFibonacci(int n)
        {
            int a = 0, b = 1;
            Console.Write("Bai 7: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(a + " ");
                int temp = a + b;
                a = b;
                b = temp;
            }
            Console.WriteLine();
        }

        // 8
        static int DemNguyenAm(string s)
        {
            int count = 0;
            foreach (char c in s.ToLower())
                if ("aeiou".Contains(c)) count++;
            return count;
        }

        // 9
        static double TinhLuyThua(double x, int y)
        {
            double result = 1;
            for (int i = 0; i < y; i++) result *= x;
            return result;
        }

        // 10
        static double TinhTrungBinh(int[] arr)
        {
            return arr.Average();
        }

        // 11
        static bool KiemTraDoiXung(string s)
        {
            string rev = new string(s.Reverse().ToArray());
            return s == rev;
        }

        // 12
        static double CelsiusToFahrenheit(double c)
        {
            return c * 9 / 5 + 32;
        }

        // 13
        static int TimMin(int[] arr)
        {
            return arr.Min();
        }

        // 14
        static int TongCacChuSo(int n)
        {
            int sum = 0;
            while (n > 0)
            {
                sum += n % 10;
                n /= 10;
            }
            return sum;
        }

        // 15
        static void SapXepMang(int[] arr)
        {
            Array.Sort(arr);
            Console.Write("Bai 15: ");
            foreach (int x in arr) Console.Write(x + " ");
            Console.WriteLine();
        }

        // 16
        static string XoaTrungLap(string s)
        {
            string result = "";
            foreach (char c in s)
                if (!result.Contains(c)) result += c;
            return result;
        }

        // 17
        static int UCLN(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        // 18
        static string DecimalToBinary(int n)
        {
            string result = "";
            while (n > 0)
            {
                result = (n % 2) + result;
                n /= 2;
            }
            return result;
        }

        // 19
        static bool KiemTraNamNhuan(int year)
        {
            return (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
        }

        // 20
        static int DemSoTu(string sentence)
        {
            return sentence.Split(' ').Length;
        }
    }
}







