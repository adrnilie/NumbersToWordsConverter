using System.Threading.Tasks;

namespace NumbersToWordsConverter.Services.Repositories
{
    public interface IConverterRepository
    {
        Task<string> ConvertToWords(string number);
    }
}