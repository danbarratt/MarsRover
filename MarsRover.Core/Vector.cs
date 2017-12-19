using System;

namespace MarsRover.Core
{
    public class Vector
    {
        public Vector(string input) {

            if (string.IsNullOrWhiteSpace(input))
                return;

            string[] inputParts = input.Split(' ');
            X = StringExtensions.ParseNonNegativeInteger(inputParts[0], "X");
            Y = StringExtensions.ParseNonNegativeInteger(inputParts[1], "Y");
            Direction = (Direction) Enum.Parse(typeof(Direction), inputParts[2]);
        }
        

        public int X {get; private set;}

        public int Y {get; private set;}

        public Direction Direction {get; private set;}

        public void Move(char instruction)
        {
            switch (instruction) {
                case 'M':
                    MoveForward();
                    break;
                case 'L':
                    TurnLeft();
                    break;
                case 'R':
                    TurnRight();
                    break;
            }
        }

        public void MoveForward() {
            switch (this.Direction) {
                case Direction.N:
                    this.Y++;
                    return;
                case Direction.E:
                    this.X++;
                    return;
                case Direction.S:
                    this.Y--;
                    return;
                case Direction.W:
                    this.X--;
                    return;
            }
        }

        public void TurnRight(){
            switch (this.Direction) {
                case Direction.N:
                    this.Direction = Direction.E;
                    return;
                case Direction.E:
                    this.Direction = Direction.S;
                    return;
                case Direction.S:
                    this.Direction = Direction.W;
                    return;
                case Direction.W:
                    this.Direction = Direction.N;
                    return;
            }
        }

        public void TurnLeft() {
            switch (this.Direction) {
                case Direction.N:
                    this.Direction = Direction.W;
                    return;
                case Direction.E:
                    this.Direction = Direction.N;
                    return;
                case Direction.S:
                    this.Direction = Direction.E;
                    return;
                case Direction.W:
                    this.Direction = Direction.S;
                    return;
            }
        }

        public override string ToString() {
            return $"{X} {Y} {Direction}";
        }

    }
}
