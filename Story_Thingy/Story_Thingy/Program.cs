using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Story_Thingy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a positive integer: ");
            int n;

            if (int.TryParse(Console.ReadLine(), out n) && n > 0)
            {
                PrintNumberPattern(n);
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a positive integer.");
            }
        }

        static void PrintNumberPattern(int n)
        {
            for (int i = n; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
