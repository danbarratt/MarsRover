using System;
using MarsRover.Core;
using Xunit;

namespace MarsRover.Tests 
{
    public class About_Plateau
    {
        [Theory]
        [InlineData("1 1",  1, 1)]
        [InlineData("2 1",  2, 1)]
        [InlineData("1 2",  1, 2)]
        [InlineData("88 99",  88, 99)]
        public void when_initialised_with_valid_input(string input, int maxX, int maxY) 
        {
            Plateau plateau = new Plateau(input);

            Assert.Equal(maxX, plateau.MaxX);
            Assert.Equal(maxY, plateau.MaxY);
        }


        [Theory]
        [InlineData("0 0")]
        [InlineData("1 0")]
        [InlineData("0 1")]
        [InlineData("1 f")]
        [InlineData("f f")]
        [InlineData("xxx")]
        [InlineData(" ")]
        [InlineData("")]
        [InlineData(null)]
        public void when_initialised_with_invalid_input(string input) 
        {
            Assert.Throws<ArgumentException>(() => new Plateau(input));
        }


    }
}