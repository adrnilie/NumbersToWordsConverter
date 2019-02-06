using System;
using System.Threading.Tasks;
using System.Web.Http;
using NumbersToWordsConverter.Services.Repositories;
using NumbersToWordsConverter.Services.View_Model;

namespace NumbersToWordsConverter.Services.Controllers
{
    [AllowAnonymous]
    public class NumbersConverterController : ApiController
    {
        private readonly IConverterRepository converterRepository;

        public NumbersConverterController(IConverterRepository converterRepository)
        {
            this.converterRepository = converterRepository ?? throw new ArgumentNullException(nameof(converterRepository));
        }

        [HttpGet]
        [Route("api/convert/{number:int}")]
        public async Task<IHttpActionResult> GetNumberInWords([FromUri]int number)
        {
            var result = await this.converterRepository.ConvertToWords(number.ToString());

            return Ok(new ResultViewModel
            {
                Input = number,
                Output = result.Trim()
            });
        }
    }
}
