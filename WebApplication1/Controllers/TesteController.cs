using Microsoft.AspNetCore.Mvc;
using System.Globalization;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TesteController : ControllerBase
    {
        private readonly ILogger<TesteController> _logger;

        public TesteController(ILogger<TesteController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "teste")]
        public Teste Get()
        {
            var value1 = "100.00";
            var value2 = decimal.TryParse(value1, out var result) ? result : 0m;
            //var value2 = decimal.TryParse(value1, NumberStyles.Number, CultureInfo.InvariantCulture, out var result) ? result : 0m;

            return new Teste
            {
                Value1 = value1,
                Value2 = value2
            };

        }
    }
}
