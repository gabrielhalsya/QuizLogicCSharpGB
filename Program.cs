using System;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Transactions;

namespace QuizLogicCSharpGB // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quiz");
            // 12
            //for (int i = 1; i <= 5; i++)
            //{
            //    for (int j = 10; j >= 5 + i; j--)
            //    {
            //        Console.Write(j + " ");
            //    }
            //    Console.WriteLine();
            //}

            //for (int i = 1; i <= 5; i++)
            //{
            //    for (int j = i; j < i + i; j++)
            //    {
            //        Console.Write(j + " ");
            //    }
            //    Console.WriteLine();
            //}

            //int it=1;
            //Console.WriteLine();
            //for (int i = 1; i < 7; i++)
            //{
            //    for (int j = 1; j <it; j++)
            //    {
            //        Console.Write(j + " ");
            //    }
            //    Console.WriteLine();

            //    if (i > 3)
            //    {
            //        it--;
            //    }
            //    else
            //    {
            //        it++;
            //    }
            //}

            //for (int i = 1; i <= 5; i++)
            //{
            //    for (int j = 1; j <= 9 - i; j++)
            //    {
            //        Console.Write("  ");
            //    }
            //    for (int j = i; j < 2 * i; j++)
            //    {
            //        Console.Write($"{j} ");
            //    }
            //    for (int j = 2 * i - 2; j >= i; j--)
            //    {
            //        Console.Write($"{j} ");
            //    }
            //    Console.WriteLine();
            //}

            //11
            // Console.WriteLine(CheckKurawal("{}"));

            ////10
            //int[] numbers = new int[5];
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.Write($"Enter .{i+1} number : ");
            //    numbers[i] = int.Parse(Console.ReadLine());
            //}

            //Array.Sort(numbers);
            //Console.WriteLine("The second maximum value is " + numbers[numbers.Length - 2]);

            //9
            // Console.Write("Enter strings: ");
            // string inputString = Console.ReadLine();
            // Console.Write("Find string: ");
            // string findString = Console.ReadLine();
            // int count = (inputString.Length - findString.Replace(findString, "").Length) / findString.Length;
            // Console.WriteLine($"total kata yang muncul :{count} dari text {inputString}");


            //8
            //Console.Write("hari sabtu: ");
            //DateTime sabtu = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            //TimeSpan daysToGo = sabtu - DateTime.Now;
            //Console.WriteLine($"{(int)daysToGo.TotalDays+1} hari lagi!");

            ////7
            //Console.Write("Enter strings: ");
            //string input = Console.ReadLine();

            //string[] words = input.Split(' ');
            //string output = "";
            //foreach (string word in words)
            //{
            //    if (word.Length > 1)
            //    {
            //        output += word[0] + new string('*', word.Length - 2) + word[word.Length - 1] + " ";
            //    }
            //    else
            //    {
            //        output += word + " ";
            //    }
            //}
            //Console.WriteLine("Modified sentence: " + output);



            ////6
            //Console.Write("Enter the maximum range: ");
            //int max = int.Parse(Console.ReadLine());

            //Console.Write("Prime numbers: ");
            //for (int i = 2; i <= max; i++)     //i start from 2 because prime start 2
            //{
            //    int count = 0;
            //    for (int j = 1; j <= i; j++)
            //    {
            //        if (i % j == 0)
            //            count++;
            //    }
            //    if (count == 2)
            //        Console.Write(i + " ");
            //}

            ////5
            //Console.Write("Enter numbers: ");
            //int number = int.Parse(Console.ReadLine()); ;
            //for (int i = 1; i < number; i++)
            //{
            //    if (number % i == 0)
            //        Console.Write(i + " ");
            //}

            //4
            //int maxint = 0;
            //while (true)
            //{
            //    Console.Write("Enter integer [Type 0 for exit] : ");
            //    int newint = int.Parse(Console.ReadLine());
            //    if(newint>maxint) 
            //    { 
            //        maxint= newint;
            //    }
            //    else {break;}
            //}
            //Console.WriteLine($"angka terbesar : {maxint}");

            //3
            //Console.Write("Enter Number integer : ");
            //int number = int.Parse(Console.ReadLine());
            //while (number > 0)
            //{
            //    Console.Write(number % 10);
            //    number /= 10;
            //}

            //2
            //Console.Write("Enter Number integer : ");
            //int number = int.Parse(Console.ReadLine());
            //int count = 0;
            //while (number > 0)
            //{
            //    count += 1;
            //    number = number / 10;
            //}
            //Console.WriteLine("Count : " + count);

            //1
            //Console.Write("Enter Number integer : ");
            //int number = int.Parse(Console.ReadLine());
            //int sum = 0;
            //while (number > 0)
            //{
            //    int digit = number % 10;
            //    sum += digit;
            //    number = number / 10;
            //}
            //Console.WriteLine($"Total Sum = {sum}");
        }

        public static bool CheckKurawal(string input)
        {
            int count = 0;
            foreach (char c in input)
            {
                if (c == '{')
                    count++;
                if (c == '}')
                    count--;
                if (count < 0)
                    return false;
            }
            return count == 0;
        }
    }
}