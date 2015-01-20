using System;

    class Exchangeofvalues
    {
        static void Main(string[] args)
        {
            int a=5;
            int b=10;
            Console.WriteLine("a= {0}  b= {1}",a,b);
            int c;
            c=a;
            a=b;
            b=c;
            Console.WriteLine();
            Console.WriteLine("new a= {0}  new b= {1}",a,b);
            Console.WriteLine();

        }
    }
