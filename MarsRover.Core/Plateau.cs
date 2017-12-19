namespace MarsRover.Core
{
    public class Plateau {
        
        public Plateau(string input) 
        {
            string[] inputParts = input.Split(' ');
            MaxX = StringExtensions.ParseNonNegativeInteger(inputParts[0], "X");
            MaxY = StringExtensions.ParseNonNegativeInteger(inputParts[1], "Y");
        }

        public int MaxX { get ; private set; }
        public int MaxY { get; private set; }
    }
}
