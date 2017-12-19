using MarsRover.Core;
using Xunit;

namespace MarsRover.Tests 
{
    public class About_Rover 
    {
        [Fact]
        public void when_initialised_with_valid_position_input() 
        {
            Rover rover = new Rover("3 2 E");

            Assert.Equal(3, rover.Position.X);
            Assert.Equal(2, rover.Position.Y);
            Assert.Equal(Direction.E, rover.Position.Direction);
        }

    }
}