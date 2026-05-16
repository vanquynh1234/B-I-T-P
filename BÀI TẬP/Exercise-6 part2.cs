using System;
using System.Collections.Generic;
using System.Text;

namespace BÀI_TẬP
{
    internal class Exercise_6_part2
    {
       
        static void Main()
        {


            {
                // BÀI 1: BUBBLE SORT
                Console.WriteLine("=== BUBBLE SORT ===");

                int[] arr = new int[10];

                Console.WriteLine("Enter 10 integers:");
                for (int i = 0; i < 10; i++)
                {
                    Console.Write("Number " + (i + 1) + ": ");
                    arr[i] = int.Parse(Console.ReadLine());
                }

                // Bubble Sort
                for (int i = 0; i < arr.Length - 1; i++)
                {
                    for (int j = 0; j < arr.Length - i - 1; j++)
                    {
                        if (arr[j] > arr[j + 1])
                        {
                            int temp = arr[j];
                            arr[j] = arr[j + 1];
                            arr[j + 1] = temp;
                        }
                    }
                }

                Console.WriteLine("Sorted array:");
                foreach (int num in arr)
                {
                    Console.Write(num + " ");
                }

                Console.WriteLine("\n");

                //  BÀI 2: LINEAR SEARCH 
                Console.WriteLine("=== LINEAR SEARCH ===");

                Console.Write("Enter a sentence: ");
                string sentence = Console.ReadLine();

                Console.Write("Enter a word to search: ");
                string word = Console.ReadLine();

                string[] words = sentence.Split(' ');
                bool found = false;

                // Linear Search
                for (int i = 0; i < words.Length; i++)
                {
                    if (words[i].ToLower() == word.ToLower())
                    {
                        found = true;
                        break;
                    }
                }

                if (found)
                    Console.WriteLine("The word exists in the sentence.");
                else
                    Console.WriteLine("The word does NOT exist in the sentence.");
            }
        }
    }
    }


