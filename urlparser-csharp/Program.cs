﻿namespace urlparser_csharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if(args.Length < 1)
            {
                Console.WriteLine("Need more arguments\n");
                Console.WriteLine("Usage:");
                Console.WriteLine("urlparser.exe file.txt > output.txt");
                return;
            }

            Console.ReadLine();
        }
    }
}