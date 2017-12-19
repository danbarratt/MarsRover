using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MarsRover.Core
{
    public class OutputWriter
    {
        public string Write(IEnumerable<Rover> rovers)
        {
            if (rovers == null || rovers.Any() == false)
                return string.Empty;

            StringBuilder output = new StringBuilder(rovers.Count());

            foreach (var rover in rovers)
                output.AppendLine(rover.Position.ToString());

            return output.ToString().Trim();
        }
    }
}