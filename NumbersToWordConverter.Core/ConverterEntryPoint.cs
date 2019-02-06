using NumbersToWordConverter.Core.Converters;

namespace NumbersToWordConverter.Core
{
    public class ConverterEntryPoint
    {
        public static string ConvertNumbers(string number)
        {
            return NumbersConverter.ConvertNumberToWords(number);
        }
    }
}