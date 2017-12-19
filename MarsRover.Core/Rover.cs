namespace MarsRover.Core
{
    public class Rover {
        
        public Rover(string position) {
            Position = new Vector(position);
        }

        public Vector Position { get; private set; }

    }
}
