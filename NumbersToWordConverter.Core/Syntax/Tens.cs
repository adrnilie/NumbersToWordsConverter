namespace NumbersToWordConverter.Core.Syntax
{
    internal class Tens
    {
        protected internal static string GetTens(string number)
        {
            int.TryParse(number, out var numberToInteger);
            var value = string.Empty;
            switch (numberToInteger)
            {
                case 10:
                    value = "Ten";
                    break;
                case 11:
                    value = "Eleven";
                    break;
                case 12:
                    value = "Twelve";
                    break;
                case 13:
                    value = "Thirteen";
                    break;
                case 14:
                    value = "Fourteen";
                    break;
                case 15:
                    value = "Fifteen";
                    break;
                case 16:
                    value = "Sixteen";
                    break;
                case 17:
                    value = "Seventeen";
                    break;
                case 18:
                    value = "Eighteen";
                    break;
                case 19:
                    value = "Nineteen";
                    break;
                case 20:
                    value = "Twenty";
                    break;
                case 30:
                    value = "Thirty";
                    break;
                case 40:
                    value = "Fourty";
                    break;
                case 50:
                    value = "Fifty";
                    break;
                case 60:
                    value = "Sixty";
                    break;
                case 70:
                    value = "Seventy";
                    break;
                case 80:
                    value = "Eighty";
                    break;
                case 90:
                    value = "Ninety";
                    break;
                default:
                    if (numberToInteger > 0)
                    {
                        value = GetTens(number.Substring(0, 1) + "0") + " " + Units.GetUnits(number.Substring(1));
                    }
                    break;
            }
            return value;
        }
    }
}