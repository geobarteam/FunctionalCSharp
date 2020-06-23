using static System.Math;

namespace FunctionalCSharp
{
    public static class Math
    {
        public static Either<string, double> Calc(double x, double y)
        {
            if (y == 0) return "y cannot be 0";
            if (x != 0 && Sign(x) != Sign(y)) return "x / y cannot be negative";

            return Sqrt(x / y);
        }
    }

}