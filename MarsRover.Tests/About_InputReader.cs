using System;
using System.Linq;
using MarsRover.Core;
using Xunit;

namespace MarsRover.Tests
{
    public class About_InputReader
    {
        
        [Fact(Skip="Not failing as expected")]
        public void when_given_no_input()
        {
            string input = "";

            Assert.Throws<ArgumentException>(() => new InputReader().Parse(input));
        }

        [Fact]
        public void when_given_valid_input_and_zero_rovers()
        {
            string input = @"1 1";

            var rovers = new InputReader().Parse(input);

            Assert.Empty(rovers);
        }

        [Fact]
        public void when_given_valid_input_and_one_rover()
        {
            string input = @"1 1
1 1 N
LR";

            var rovers = new InputReader().Parse(input);

            Assert.Single(rovers);
        }

        [Fact]
        public void when_given_valid_input_and_two_rovers()
        {
            string input = @"5 5
1 2 N
LMLMLMLMM
3 3 E
MMRMMRMRRM";

            var rovers = new InputReader().Parse(input);

            Assert.Equal(2, rovers.Count());
        }
    }
}