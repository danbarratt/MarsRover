using System;

namespace MarsRover.Core
{
    public class Plateau {
        
        public Plateau(string input) 
        {
            if (string.IsNullOrWhiteSpace(input))
                throw new ArgumentException("No plateau dimensions have been specified");

            string[] inputParts = input.Split(' ');

            MaxX = StringExtensions.ParsePositiveInteger(inputParts[0], "X");
            MaxY = StringExtensions.ParsePositiveInteger(inputParts[1], "Y");
        }


        public int MaxX { get ; private set; }
        public int MaxY { get; private set; }
    }
}
