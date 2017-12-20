using System;
using System.Text;
using MarsRover.Core;

namespace MarsRover
{
    class Program
    {
        static void Main()
        {
            InputReader reader = new InputReader();

            var rovers = reader.Parse(ReadInput());

            string output = new OutputWriter().Write(rovers);

            Console.WriteLine(output);
        }

        private static string ReadInput()
        {
            StringBuilder sb = new StringBuilder();

            if (Console.IsInputRedirected)
            {
                String input;

                while ((input = Console.ReadLine()) != null) {
                    sb.AppendLine(input);
                }
            }

            return sb.ToString();
        }
    }
}
