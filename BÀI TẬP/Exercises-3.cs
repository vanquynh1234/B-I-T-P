using System;
using System.Collections.Generic;
using System.Text;

namespace BÀI_TẬP
{
    internal class Exercises_3
    {
        static void Main()
        {
            //Bài 1:
            double num1 = 10;
        double num2 = 5;
        char op = '+';

        double result = 0;

        switch (op)
        {
            case '+': result = num1 + num2; break;
            case '-': result = num1 - num2; break;
            case '*':
            case 'x': result = num1* num2; break;
            case '/': result = num1 / num2; break;
        }

          Console.WriteLine("1. Calculator:");
           Console.WriteLine($"{num1} {op} {num2} = {result}\n");
            // Bài 2:
            Console.WriteLine("2. Function x = y^2 + 2y + 1:");
            for (int y = -5; y <= 5; y++)
            {
                int x = y * y + 2 * y + 1;
                Console.WriteLine($"y = {y}, x = {x}");
            }
            //Bai 3: 

            double distance = 100; // km
                int h = 2, m = 30, s = 0;

                double time = h + (m / 60.0) + (s / 3600.0);

                double kmh = distance / time;
                double mph = kmh * 0.621371;

                Console.WriteLine("3. Speed:");
                Console.WriteLine($"Distance: {distance} km, Time: {h}h {m}m {s}s");
                Console.WriteLine($"Speed: {kmh} km/h");
                Console.WriteLine($"Speed: {mph} miles/h\n");


            //Bài 4: 
            double r = 3;

            double surface = 4 * Math.PI * r * r;
            double volume = (4.0 / 3.0) * Math.PI * Math.Pow(r, 3);

            Console.WriteLine("4. Sphere:");
            Console.WriteLine($"Radius: {r}");
            Console.WriteLine($"Surface: {surface}");
            Console.WriteLine($"Volume: {volume}\n");

            //Bài 5:
            char ch = 'A';

            Console.WriteLine("5. Check character:");
            Console.WriteLine($"Character: {ch}");

            if ("aeiouAEIOU".IndexOf(ch) != -1)
            {
                Console.WriteLine("It is a vowel.");
            }
            else if (char.IsDigit(ch))
            {
                Console.WriteLine("It is a digit.");
            }
            else
            {
                Console.WriteLine("It is another symbol.");
            }


        }
    }
}
