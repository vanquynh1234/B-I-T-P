using System;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace BÀI_TẬP
{
    internal class Exercise_2
    {
        static void Main()
        {
            // Bài 1: Print Hello and Name
            Console.WriteLine("Hello");
            Console.WriteLine("Quynh Van");

            // Bài 2: Sum of Two Numbers
            int a = 10;
            int b = 20;
            int sum = a + b;
            Console.WriteLine("Sum of two numbers: " + sum);

            // Bài 3: Divide Two Numbers
            int x = 20;
            int y = 5;
            int result = x / y;
            Console.WriteLine("Division result: " + result);

            // Bài 4: Specified Operations
            Console.WriteLine("-1 + 4 * 6 = " + (-1 + 4 * 6));
            Console.WriteLine("(35 + 5) % 7 = " + ((35 + 5) % 7));
            Console.WriteLine("14 + -4 * 6 / 11 = " + (14 + -4 * 6 / 11));
            Console.WriteLine("2 + 15 / 6 * 1 - 7 % 2 = " + (2 + 15 / 6 * 1 - 7 % 2));

            // Bài 5: Swap Two Numbers
            int d = 5;
            int e = 6;
            Console.WriteLine($"Before swap: d = {d}, e = {e}");
            int temp = d;
            d = e;
            e = temp;
            Console.WriteLine($"After swap: d = {d}, e = {e}");

            // Bài 6:Multiply Three Numbers
            int m1 = 2, m2 = 3, m3 = 6;
            int result1 = m1 * m2 * m3;
            Console.WriteLine($"{m1} x {m2} x {m3} = {result1}");

            // Bài 7:Arithmetic Operations
            int a1 = 25;
            int a2 = 4;
            Console.WriteLine($"{a1} + {a2} = {a1 + a2}");
            Console.WriteLine($"{a1} - {a2} = {a1 - a2}");
            Console.WriteLine($"{a1} x {a2} = {a1 * a2}");
            Console.WriteLine($"{a1} / {a2} = {a1 / a2}");
            Console.WriteLine($"{a1} mod {a2} = {a1 % a2}");

            // Bài 8: Mutiplication Table
            int n = 5;

            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine($"{n} * {i} = {n * i}");
            }

            // Bài 9: Avrage of Four Numbers
            int b1 = 10; int b2 = 15; int b3 = 20; int b4 = 30;
            double average = (b1 + b2 + b3 + b4) / 4.0;
            Console.WriteLine($"Average of four numbers: {average}");

            // Bài 10: Specified Formula with Three Numbers
            int c1 = 5; int c2 = 6; int c3 = 7;
            int result2 = (c1 + c2) * c3; int result3 = c1 * c2 + c2 * c3;
            Console.WriteLine($"Result of ({c1} + {c2}) * {c3} = {result2}");
            Console.WriteLine($"Result of {c1} * {c2} + {c2} * {c3} = {result3}");

            // Bài 11:  Print Age Message
            int age = 25;
            Console.WriteLine($"You look older than {age}");

            // Bài 12: Repeat Number in Rows
            int d1 = 25;
            // Cách 1: dùng WriteLine bình thường
            Console.WriteLine(d1 + " " + d1 + " " + d1 + " " + d1);
            Console.WriteLine(d1.ToString() + d1 + d1 + d1);

            // Cách 2: dùng {0}
            Console.WriteLine("{0} {0} {0} {0}", d1);
            Console.WriteLine("{0}{0}{0}{0}", d1);

            // Bài 13: Rectangle Pattern with Number
            int d2 = 5;
            // Dòng 1
            Console.WriteLine($"{d2}{d2}{d2}");
            // Dòng 2 → 4
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"{d2} {d2}");
            }
            // Dòng 5
            Console.WriteLine($"{d2}{d2}{d2}");


            // Bài 14: Celsius to Kelvin and Fahrenheit
            double celsius = 30;
            double kelvin = celsius + 273;
            double fahrenheit = (celsius * 9 / 5) + 32;
            Console.WriteLine($"Kelvin = {kelvin}");
            Console.WriteLine($"Fahrenheit = {fahrenheit}");

            // Bài 15: Remove Character by Index
            string str = "w3resource";
            // Xóa ký tự ở vị trí index = 1
            Console.WriteLine(str.Remove(1, 1));
            // Xóa ký tự ở vị trí cuối
            Console.WriteLine(str.Remove(str.Length - 1, 1));
            // Xóa ký tự ở vị trí đầu
            Console.WriteLine(str.Remove(0, 1));

            // Bài 16: Swap First and Last Characters
            string str1 = "w3resource";

            if (str1.Length > 1)
            {
                string result4 = str1[str1.Length - 1] +
                                str1.Substring(1, str1.Length - 2) +
                                str1[0];

                Console.WriteLine("Result: " + result4);
            }
            else
            {
                Console.WriteLine("Result: " + str1);
            }
            string str2 = "Python";

            if (str2.Length > 1)
            {
                string result5 = str2[str2.Length - 1] +
                                str2.Substring(1, str2.Length - 2) +
                                str2[0];

                Console.WriteLine("Result: " + result5);
            }
            else
            {
                Console.WriteLine("Result: " + str2);
            }
            // Bài 17: Add First Character to Front and Back
            string str3 = "The quick brown fox jumps over the lazy dog.";

            string result6 = str3[0] + str3 + str3[0];

            Console.WriteLine(result6);

            // Bài 18: Check Positive and Negative Pair
            int f1 = -5;
            int f2 = 25;

            bool result7 = (f1 < 0 && f2 > 0) || (f1 > 0 && f2 < 0);

            Console.WriteLine("Check if one is negative and one is positive:");
            Console.WriteLine(result7);

            // Bài 19: Sum or Triple Sum of Integers
            int f3 = 2;
            int f4 = 3;
            int sum1 = f3 + f4;
            if (f3 == f4)
            {
                Console.WriteLine("Result: " + (sum1 * 3));
            }
            else
            {
                Console.WriteLine("Result: " + sum1);
            }

            // Bài 20: Absolute Difference or Double It
            int f5 = 5;
            int f6 = 3;
            int result8 =Math.Abs(f5 - f6);
            if (f5 > f6)
            {
                result8 = result8 * 2;
            }
            Console.WriteLine("Result: " + result8);

            int f7 = 3;
            int f8= 5;
            int result9 = Math.Abs(f7 - f8);
            if (f7 > f8)
            {
                result9 = result9 * 2;
            }
            Console.WriteLine("Result: " + result9);
        }
    }
}
