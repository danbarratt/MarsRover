using System;

namespace MarsRover.Core
{
    public class Vector
    {
        public Vector(string input) {

            if (string.IsNullOrWhiteSpace(input))
                return;

            string[] inputParts = input.Split(' ');
            X = ParseNonNegativeInteger(inputParts[0], "X");
            Y = ParseNonNegativeInteger(inputParts[1], "Y");
            Direction = (Direction) Enum.Parse(typeof(Direction), inputParts[2]);
        }

        private int ParseNonNegativeInteger(string input, string paramName) {
            int theValue;
            try {
                theValue = int.Parse(input);
            }
            catch (FormatException ex) {
                throw new System.ArgumentException("Could not read " + paramName, ex);
            }

            if (theValue < 0)
                throw new System.ArgumentException("Value must not be less than 0: " + paramName);

            return theValue;
        }

        public int X {get; private set;}

        public int Y {get; private set;}

        public Direction Direction {get; private set;}
    }

    public enum Direction {
        N,
        S,
        E,
        W
    }
}
