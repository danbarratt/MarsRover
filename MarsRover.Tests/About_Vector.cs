using MarsRover.Core;
using System;
using Xunit;

namespace MarsRover.Tests
{
    public class About_Vector
    {
        [Theory]
        [InlineData("")]
        [InlineData(null)]
        [InlineData(" ")]
        public void when_initialisd_with_no_input(string input)
        {
            Vector vector = new Vector(input);

            Assert.Equal(0, vector.X);
            Assert.Equal(0, vector.Y);
            Assert.Equal(Direction.N, vector.Direction);
        }

        [Theory]
        [InlineData("1 1 S", 1, 1, Direction.S)]
        [InlineData("99 45 E", 99, 45, Direction.E)]
        public void when_initialised_with_input(string input, int expectedX, int expectedY, Direction expectedDirection)
        {
            Vector vector = new Vector(input);

            Assert.Equal(expectedX, vector.X);
            Assert.Equal(expectedY, vector.Y);
            Assert.Equal(expectedDirection, vector.Direction);
        }

        [Theory]
        [InlineData("X X X")]
        [InlineData("-1 -1 N")]
        [InlineData("1 1 X")]
        public void when_initialised_with_bad_input(string input)
        {
            Assert.Throws<ArgumentException>(() => new Vector(input));
        }
    }
}
