﻿using System;

namespace Example1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0; 
            int b = 0; 
            Console.Write("Type a whole number: ");
            a= Int32.Parse(Console.ReadLine()); 
            Console.Write("Type another whole number: ");
            b= Int32.Parse(Console.ReadLine()); 
            Console.WriteLine("LOADING... ");
            Console.WriteLine($"subtracting {a} - {b} equals {subtractNumber(a,b)} ");



        }

        static int subtractNumber(int a, int b)
        {
            return a - b; 
        }
    }
}
