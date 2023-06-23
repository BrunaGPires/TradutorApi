using Microsoft.AspNetCore.Mvc;
using System.Globalization;
using TradutorMacro.Service;

namespace TradutorMacro.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TraducaoController : ControllerBase
    {
        private readonly TraducaoService _traducaoService;
        public TraducaoController(TraducaoService traducaoService)
        {
            _traducaoService = traducaoService;
        }

        [HttpGet("{palavra}/{idioma}")]
        public IActionResult GetTraducao(string palavra, string idioma)
        {
            var palavraTraduzida = _traducaoService.Traduz(palavra, idioma);

            return Ok(palavraTraduzida);
        }
    }
}
