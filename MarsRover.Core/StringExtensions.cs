namespace MarsRover.Core {
    public static class StringExtensions
    {
        public static int ParseNonNegativeInteger(this string input, string paramName) 
        {
            int theValue;
            try {
                theValue = int.Parse(input);
            }
            catch (System.FormatException ex) {
                throw new System.ArgumentException("Could not read " + paramName, ex);
            }

            if (theValue < 0)
                throw new System.ArgumentException("Value must not be less than 0: " + paramName);

            return theValue;
        }
    }
}