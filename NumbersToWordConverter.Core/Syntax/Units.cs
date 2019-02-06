namespace NumbersToWordConverter.Core.Syntax
{
    internal class Units
    {
        protected internal static string GetUnits(string number)
        {
            int.TryParse(number, out var numberToInteger);
            var value = string.Empty;
            switch (numberToInteger)
            {

                case 1:
                    value = "One";
                    break;
                case 2:
                    value = "Two";
                    break;
                case 3:
                    value = "Three";
                    break;
                case 4:
                    value = "Four";
                    break;
                case 5:
                    value = "Five";
                    break;
                case 6:
                    value = "Six";
                    break;
                case 7:
                    value = "Seven";
                    break;
                case 8:
                    value = "Eight";
                    break;
                case 9:
                    value = "Nine";
                    break;
            }
            return value;
        }
    }
}