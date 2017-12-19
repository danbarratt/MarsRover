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
        public void when_initialised_with_valid_size(string input, int maxX, int maxY) 
        {
            Plateau plateau = new Plateau(input);

            Assert.Equal(maxX, plateau.MaxX);
            Assert.Equal(maxY, plateau.MaxY);
        }


    }
}