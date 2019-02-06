using System;

namespace NumbersToWordsConverter.Services.Utils
{
    public static class NumberChecker
    {
        public static bool StartsWithZero(this string value)
        {
            return value.StartsWith("0");
        }

        public static bool StartsWithPoint(this string value)
        {
            return value.StartsWith(".");
        }

        public static bool IsNegative(this string value)
        {
            return value.StartsWith("-");
        }

        public static bool IsNegativeAndStartsWithZero(this string value)
        {
            return value.IsNegative() && value.Substring(1, 1).StartsWithZero();
        }

        public static bool IsNegativeAndStartsWithPoint(this string value)
        {
            return value.IsNegative() && value.Substring(1, 1).StartsWithPoint();
        }

        public static bool IsInvalid(this string value)
        {
            var result = false;

            if (value.LastIndexOf("-", StringComparison.Ordinal) > 0)
            {
                result = true;
            }
            else if (value.StartsWithPoint())
            {
                result = true;
            }
            else if (value.StartsWithZero())
            {
                result = true;
            } else if (value.IsNegativeAndStartsWithZero())
            {
                result = true;
            }
            else if (value.IsNegativeAndStartsWithPoint())
            {
                result = true;
            }
            return result;
        }
    }
}