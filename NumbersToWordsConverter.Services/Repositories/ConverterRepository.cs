using System.Threading.Tasks;
using NumbersToWordConverter.Core;
using NumbersToWordsConverter.Services.Utils;

namespace NumbersToWordsConverter.Services.Repositories
{
    public class ConverterRepository: IConverterRepository
    {
        public async Task<string> ConvertToWords(string number)
        {
            if (number.IsInvalid())
            {
                return "The entered number is invalid!";
            }

            if (!number.IsNegative())
            {
                return await Task.Run(() => ConverterEntryPoint.ConvertNumbers(number));
            }

            number = number.Remove(0, 1);
            return $"Minus {await Task.Run(() => ConverterEntryPoint.ConvertNumbers(number))}";
        }
    }
}