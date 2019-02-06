using System;
using NumbersToWordConverter.Core.Syntax;

namespace NumbersToWordConverter.Core.Converters
{
    internal class NumbersConverter
    {
        protected internal static string ConvertNumberToWords(string number)
        {
            var numberCopy = number;
            var separator = string.Empty;
            var rangeWord = string.Empty;

            var pointPosition = number.IndexOf(".", StringComparison.Ordinal);
            if (pointPosition > 0)
            {
                numberCopy = number.Substring(0, pointPosition);
                var range = number.Substring(pointPosition + 1);
                int.TryParse(range, out var rangeToInteger);

                if (rangeToInteger > 0)
                {
                    separator = "and";
                    rangeWord = GetConvertedDecimals(range);
                }
            }
            return $"{ConvertNumber(numberCopy).Trim()} {separator}{rangeWord}";
        }

        protected internal static string ConvertNumber(string number)
        {
            var value = string.Empty;
            var finished = false;
            double.TryParse(number, out var numberToDouble);

            if (numberToDouble > 0)
            {
                var units = number.Length;
                var position = 0;
                var range = string.Empty;
                switch (units)
                {
                    case 1:
                        value = Units.GetUnits(number);
                        finished = true;
                        break;
                    case 2:
                        value = Tens.GetTens(number);
                        finished = true;
                        break;
                    case 3:
                        position = (units % 3) + 1;
                        range = " Hundred ";
                        break;
                    case 4:
                    case 5:
                    case 6:
                        position = (units % 4) + 1;
                        range = " Thousand ";
                        break;
                    case 7:
                    case 8:
                    case 9:
                        position = (units % 7) + 1;
                        range = " Million ";
                        break;
                    case 10:
                    case 11:
                    case 12:
                        position = (units % 10) + 1;
                        range = " Billion ";
                        break;
                    default:
                        finished = true;
                        break;
                }
                if (!finished)
                {
                    if (number.Substring(0, position) != "0" && number.Substring(position) != "0")
                    {
                        value = ConvertNumber(number.Substring(0, position)) + range + ConvertNumber(number.Substring(position));

                    }
                    else
                    {
                        value = ConvertNumber(number.Substring(0, position)) + ConvertNumber(number.Substring(position));
                    }
                }
                if (value.Trim().Equals(range.Trim()))
                {
                    value = string.Empty;
                }
            }

            return value.Trim();
        }

        protected internal static string GetConvertedDecimals(string number)
        {
            var value = string.Empty;

            foreach (var c in number)
            {
                var unit = c.ToString();
                var unitWord = unit.Equals("0") ? "Zero" : Units.GetUnits(unit);
                value += " " + unitWord;
            }
            return value;
        }
    }
}