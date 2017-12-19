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

        [Theory]
        [InlineData("",  "0 0 N")]
        [InlineData(" ", "0 0 N")]
        [InlineData("L", "0 0 W")]
        [InlineData("R", "0 0 E")]
        [InlineData("M", "0 1 N")]
        [InlineData("RML", "1 0 N")]
        [InlineData("MRML", "1 1 N")]
        public void when_given_valid_move_instructions(string instructions, string finalLocation) 
        {
            Rover rover = new Rover("0 0 N");

            rover.Move(instructions);

            Assert.Equal(finalLocation, rover.Position.ToString());
        }

    }
}