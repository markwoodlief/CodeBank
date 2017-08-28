namespace CodeBank
{
    public static class Helpers
    {
        public static bool Between(this int num, int lower, int upper, bool inclusive = false)
        {
            return inclusive
                       ? lower <= num && num <= upper
                       : lower < num && num < upper;
        }

        public static bool Between(this double num, double lower, double upper, bool inclusive = false)
        {
            return inclusive
                       ? lower <= num && num <= upper
                       : lower < num && num < upper;
        }

        public static bool Between(this float num, float lower, float upper, bool inclusive = false)
        {
            return inclusive
                       ? lower <= num && num <= upper
                       : lower < num && num < upper;
        }

       
    }
}