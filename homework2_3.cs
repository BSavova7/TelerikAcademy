using System;

    class TypeUShort
    {
        static void Main()
        {
            ushort a = 254;

            String  hexadecimal = "FE";
            Console.WriteLine("hexadecimal representation an  {0}  is  {1}", a, hexadecimal);
            Console.WriteLine();
            ushort hex = 0xFE;
            Console.Write("decimal representation an FE is ");
            Console.WriteLine(hex);
            Console.WriteLine();
        }
    }
