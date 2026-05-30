using System;
using System.Collections.Generic;
using System.Text;

namespace BÀI_TẬP
{
    internal class Excercises_8
    {
        static void Main()
        {
            Console.WriteLine("===== STRING OPERATIONS =====");

            // 1. Input and print a string
            Console.Write("Enter a string: ");
            string str = Console.ReadLine();

            Console.WriteLine("\n1. Print String:");
            Console.WriteLine(str);

            // 2. Find length without library function
            int length = 0;
            foreach (char c in str)
            {
                length++;
            }
            Console.WriteLine("\n2. Length of String: " + length);

            // 3. Separate individual characters
            Console.WriteLine("\n3. Individual Characters:");
            foreach (char c in str)
            {
                Console.WriteLine(c);
            }

            // 4. Print characters in reverse order
            Console.WriteLine("\n4. Characters in Reverse Order:");
            for (int i = str.Length - 1; i >= 0; i--)
            {
                Console.Write(str[i] + " ");
            }
            Console.WriteLine();

            // 5. Count words
            int words = 1;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == ' ')
                    words++;
            }
            Console.WriteLine("\n5. Total Words: " + words);

            // 6. Compare two strings
            Console.Write("\nEnter another string for comparison: ");
            string str2 = Console.ReadLine();

            bool equal = true;

            if (str.Length != str2.Length)
            {
                equal = false;
            }
            else
            {
                for (int i = 0; i < str.Length; i++)
                {
                    if (str[i] != str2[i])
                    {
                        equal = false;
                        break;
                    }
                }
            }

            Console.WriteLine("6. Comparison Result: " +
                             (equal ? "Strings are equal" : "Strings are not equal"));

            // 7. Count alphabets, digits, special characters
            int alphabets = 0, digits = 0, special = 0;

            foreach (char c in str)
            {
                if (char.IsLetter(c))
                    alphabets++;
                else if (char.IsDigit(c))
                    digits++;
                else
                    special++;
            }

            Console.WriteLine("\n7. Character Count");
            Console.WriteLine("Alphabets: " + alphabets);
            Console.WriteLine("Digits: " + digits);
            Console.WriteLine("Special Characters: " + special);

            // 8. Count vowels and consonants
            int vowels = 0, consonants = 0;

            foreach (char c in str.ToLower())
            {
                if (char.IsLetter(c))
                {
                    if ("aeiou".Contains(c))
                        vowels++;
                    else
                        consonants++;
                }
            }

            Console.WriteLine("\n8. Vowels and Consonants");
            Console.WriteLine("Vowels: " + vowels);
            Console.WriteLine("Consonants: " + consonants);

            // 9. Check substring presence
            Console.Write("\nEnter a substring: ");
            string sub = Console.ReadLine();

            if (str.Contains(sub))
                Console.WriteLine("9. Substring Found");
            else
                Console.WriteLine("9. Substring Not Found");

            // 10. Find substring position
            int position = str.IndexOf(sub);

            if (position >= 0)
                Console.WriteLine("10. Position of Substring: " + position);
            else
                Console.WriteLine("10. Substring Not Found");

            // 11. Check character type and case
            Console.Write("\nEnter a character: ");
            char ch = Convert.ToChar(Console.ReadLine());

            if (char.IsLetter(ch))
            {
                if (char.IsUpper(ch))
                    Console.WriteLine("11. Uppercase Alphabet");
                else
                    Console.WriteLine("11. Lowercase Alphabet");
            }
            else
            {
                Console.WriteLine("11. Not an Alphabet");
            }

            // 12. Count occurrences of substring
            int count = 0;
            int index = 0;

            while ((index = str.IndexOf(sub, index)) != -1)
            {
                count++;
                index += sub.Length;
            }

            Console.WriteLine("12. Number of Occurrences: " + count);

            // 13. Insert substring before first occurrence
            Console.Write("\nEnter string to find: ");
            string find = Console.ReadLine();

            Console.Write("Enter string to insert: ");
            string insert = Console.ReadLine();

            int pos = str.IndexOf(find);

            if (pos >= 0)
            {
                string result = str.Insert(pos, insert);
                Console.WriteLine("13. Result after Insertion:");
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("13. String Not Found");
            }
        }
    }

    }
