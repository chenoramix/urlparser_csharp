using System.IO;
using System.Text.Json;

namespace urlparser_csharp
{
    internal class Program
    {
        // json ob
        public class JSONData
        {
            public string? url { get; set; }
            public string? comment { get; set; }
            public string? author { get; set; }

        }
        static void Main(string[] args)
        {
            if(args.Length < 1)
            {
                Console.WriteLine("Need more arguments\n");
                Console.WriteLine("Usage:");
                Console.WriteLine("urlparser.exe file.txt > output.txt");
                return;
            }

            string fileName = args[0];

            // check if the file exist.
            if(!File.Exists(fileName))
            {
                Console.WriteLine("File does not exist!");
                return;
            }

            foreach(string line in File.ReadLines(fileName))
            {
                if(!line.StartsWith("{\"url\":\""))
                {
                    continue;
                }

                JSONData jsonData = JsonSerializer.Deserialize<JSONData>(line)!;
                if(jsonData.url != null)
                {
                    Console.WriteLine(jsonData.url);
                }
            }

            // Console.ReadLine();
        }
    }
}