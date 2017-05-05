using System;
using System.IO;

namespace DisplayFile
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length < 1)
                return;

            string[] lines = File.ReadAllLines(args[0]);

            foreach (string item in lines)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Press Any Key To Exit");
            Console.ReadKey();
        }
    }
}
