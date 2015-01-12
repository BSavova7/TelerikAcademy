using System;

class Squares
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Squares:");
            Console.WriteLine();
            for (int i = 2; i < 12; i++)
            {
               Console.Write("  ");
               Console.Write(i*Math.Pow(-1,i));              
            }
            Console.WriteLine();
            Console.WriteLine();
        }
    }
    
