using System.IO;

namespace urlparser_csharp
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

            foreach(string line in File.ReadLines(args[0]))
            {
                Console.WriteLine(line);
            }

            Console.ReadLine();
        }
    }
}