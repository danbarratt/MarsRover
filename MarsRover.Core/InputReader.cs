using System;
using System.Collections.Generic;
using System.Linq;

namespace MarsRover.Core
{
    public class InputReader
    {
        public IEnumerable<Rover> Parse(string input)
        {
            var inputLines = SplitOn(input, Environment.NewLine);

            if (inputLines.Any() == false)
                yield break;

            Plateau plateau = new Plateau(inputLines.Dequeue());

            while (inputLines.Count > 0)
            {
                Rover rover = new Rover(inputLines.Dequeue());
                rover.Move(inputLines.Dequeue());
                yield return rover;
            }
        }

        private Queue<string> SplitOn(string input, string separator)
        {
            Queue<string> toReturn = new Queue<string>();

            if (string.IsNullOrWhiteSpace(input))
                return toReturn;

            int index;

            while ((index = input.IndexOf(separator)) > -1)
            {
                toReturn.Enqueue(input.Substring(0, index));
                input = input.Substring(index + separator.Length);
            }

            if (string.IsNullOrWhiteSpace(input) == false)
                toReturn.Enqueue(input);

            return toReturn;
        }
    }
}