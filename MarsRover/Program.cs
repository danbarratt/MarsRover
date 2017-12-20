using System;
using System.Text;
using MarsRover.Core;

namespace MarsRover
{
    class Program
    {
        static void Main()
        {
            var rovers = new InputReader().Parse(ReadConsole());

            string output = new OutputWriter().Write(rovers);

            Console.WriteLine(output);
        }

        private static string ReadConsole()
        {
            if (Console.IsInputRedirected == false) {
                Console.WriteLine("Enter MarsRover input data (can be multi-line, enter blank line to process instructions):");
            }

            StringBuilder sb = new StringBuilder();
            String input = Console.ReadLine();

            while (string.IsNullOrWhiteSpace(input) == false) {
                sb.AppendLine(input);
                input = Console.ReadLine();
            }

            return sb.ToString();
        }
    }
}
