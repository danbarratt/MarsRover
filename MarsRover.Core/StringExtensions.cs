namespace MarsRover.Core {
    public static class StringExtensions
    {
        private static int ParseInteger(string input, string paramName) 
        {
            try {
                return int.Parse(input);
            }
            catch (System.FormatException ex) {
                throw new System.ArgumentException("Could not read " + paramName, ex);
            }
        }

        public static int ParseNonNegativeInteger(string input, string paramName) 
        {
            int theValue = ParseInteger(input, paramName);

            if (theValue < 0)
                throw new System.ArgumentException("Value must not be less than 0: " + paramName);

            return theValue;
        }

        public static int ParsePositiveInteger(this string input, string paramName) 
        {
            int theValue = ParseInteger(input, paramName);
            
            if (theValue < 1)
                throw new System.ArgumentException("Value must not be less than 1: " + paramName);

            return theValue;
        }
    }
}