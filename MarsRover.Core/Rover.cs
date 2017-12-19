namespace MarsRover.Core
{
    public class Rover {
        
        public Rover(string position) {
            Position = new Vector(position);
        }

        public Vector Position { get; private set; }

        public void Move(string instructions)
        {
            if (string.IsNullOrWhiteSpace(instructions))
                return;

            foreach (char instruction in instructions)
                this.Position.Move(instruction);
        }
    }
}
