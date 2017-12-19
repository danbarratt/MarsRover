using System;
using System.Collections.Generic;
using MarsRover.Core;
using Xunit;

namespace MarsRover.Tests
{
    public class About_OutputWriter
    {
        [Fact]
        public void when_given_no_rovers() {
            
            IEnumerable<Rover> rovers = null;

            string output = new OutputWriter().Write(rovers);

            Assert.Empty(output);
        } 

        [Fact]
        public void when_given_one_rover() {
            
            var rovers = new List<Rover> { 
                new Rover("1 1 N") 
            };
            
            string output = new OutputWriter().Write(rovers);

            Assert.Equal("1 1 N", output);
        } 

        [Fact]
        public void when_given_two_rovers() {
            
            var rovers = new List<Rover> { 
                new Rover("1 1 N"), 
                new Rover("1 1 S") 
            };
            
            var output = new OutputWriter().Write(rovers);

            Assert.Equal(@"1 1 N" + Environment.NewLine + "1 1 S", output);
        } 
    }
}