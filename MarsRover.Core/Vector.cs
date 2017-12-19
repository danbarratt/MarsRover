using System;

namespace MarsRover.Core
{
    public class Vector
    {
        public Vector(string input) {

            if (string.IsNullOrWhiteSpace(input))
                return;

            string[] inputParts = input.Split(' ');
            X = int.Parse(inputParts[0]);
            Y = int.Parse(inputParts[1]);
            Direction = (Direction) Enum.Parse(typeof(Direction), inputParts[2]);
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
