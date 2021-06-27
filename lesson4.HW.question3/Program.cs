using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson4.HW.question3
{
    class Program
    {
        static void Main(string[] args)
        {

            int[,] arr = new int[5, 5];
            Random rnd = new Random();
            int num, index;

            for (int i = 0; i < arr.GetLength(0); i++)
            { 
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    num = rnd.Next(1, 11);
                    arr[i, j] = num;

                    Console.WriteLine(arr[i, j]);
                }

            }
            Console.WriteLine("Enter number");
            index = int.Parse(Console.ReadLine());

            for (int i = 0; i < arr.GetLength(0); i++)
            {

                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (arr[i, j] == index)
                    {
                        Console.Write("Row: {0} Column: {1} ", i, j);
                    }
                }

            }
            Console.ReadLine();
        }
        
    }
}

