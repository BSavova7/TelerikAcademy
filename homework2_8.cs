using System;

    class Symbols
    {
        static void Main()
        {
           Char emptysymbol;
            Char symbol;
            symbol = (char)0x00A9;
            emptysymbol = (char)0x20;
            Console.Write("   ");
            Console.WriteLine(symbol);
            Console.Write("{0}{1}{2}{3}{4}", emptysymbol, emptysymbol, symbol, emptysymbol, symbol);
            Console.WriteLine();
            Console.Write(" ");
            Console.Write(symbol);
            Console.Write("   ");
            Console.WriteLine(symbol);
            for(int i=0;i<4;i++)
            Console.Write("{0}{1}",symbol,emptysymbol);
            Console.WriteLine('\n');
        }
    }
