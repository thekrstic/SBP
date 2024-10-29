using Microsoft.AspNetCore.Mvc;
using StanNaDan;
using StanNaDan.Entiteti;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class NekretninaController : ControllerBase
    {
        [HttpGet]
        [Route("PreuzmiNekretnine")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public IActionResult GetNekretnine()
        {
            (bool isError, List<NekretninaPregled> nekretnine, ErrorMessage? error) = DataProvider.GetNekretninaPregled();

            if (isError)
            {
                return StatusCode(error?.StatusCode ?? 400, error?.Message);
            }

            return Ok(nekretnine);
        }

        [HttpGet]
        [Route("PreuzmiVlasnikaNekretnine")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public IActionResult GetVlasnik([FromForm] int id)
        {
            (bool isError, VlasnikPregled vlasnik, ErrorMessage? error) = DataProvider.GetPregledVlasnikNekretnine(id);

            if (isError)
            {
                return StatusCode(error?.StatusCode ?? 400, error?.Message);
            }

            return Ok(vlasnik);
        }

        [HttpGet]
        [Route("PreuzmiKvartNekretnine")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public IActionResult GetKvart([FromForm] int id)
        {
            (bool isError, KvartPregled kvart, ErrorMessage? error) = DataProvider.GetPregledKvartNekretnine(id);

            if (isError)
            {
                return StatusCode(error?.StatusCode ?? 400, error?.Message);
            }

            return Ok(kvart);
        }

        [HttpPost]
        [Route("DodajKucu")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public async Task<IActionResult> AddKuca([FromForm] KucaBasic kb)
        {
            var data = await DataProvider.DodajKucuAsync(kb);

            if (data.IsError)
            {
                return StatusCode(data.Error.StatusCode, data.Error.Message);
            }

            return StatusCode(201, $"Uspešno dodata kuca. Ulica: {kb.ImeUlice}");
        }

        [HttpPost]
        [Route("DodajStan")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public async Task<IActionResult> AddStan([FromForm] StanBasic sb)
        {
            var data = await DataProvider.DodajStanAsync(sb);

            if (data.IsError)
            {
                return StatusCode(data.Error.StatusCode, data.Error.Message);
            }

            return StatusCode(201, $"Uspešno dodat stan. Ulica: {sb.ImeUlice}");
        }

        [HttpPost]
        [Route("DodajSobu")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public async Task<IActionResult> AddSoba([FromForm] SobaBasic sb)
        {
            var data = await DataProvider.DodajSobuAsync(sb);

            if (data.IsError)
            {
                return StatusCode(data.Error.StatusCode, data.Error.Message);
            }

            return StatusCode(201, $"Uspešno dodata soba. Ulica: {sb.ImeUlice}");
        }

        [HttpPut]
        [Route("PromeniKucu")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public async Task<IActionResult> ChangeKuca([FromBody] KucaBasic kb, int nId)
        {
            (bool isError, var nekretnine, ErrorMessage? error) = await DataProvider.AzurirajKucuAsync(kb, nId);

            if (isError)
            {
                return StatusCode(error?.StatusCode ?? 400, error?.Message);
            }

            if (nekretnine == null)
            {
                return BadRequest("Kuca nije validna.");
            }

            return Ok($"Uspešno ažurirana kuca. Ulica: {nekretnine.ImeUlice}");
        }

        [HttpPut]
        [Route("PromeniStan")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public async Task<IActionResult> ChangeStan([FromBody] StanBasic sb, int nId)
        {
            (bool isError, var nekretnine, ErrorMessage? error) = await DataProvider.AzurirajStanAsync(sb, nId);

            if (isError)
            {
                return StatusCode(error?.StatusCode ?? 400, error?.Message);
            }

            if (nekretnine == null)
            {
                return BadRequest("Stan nije validan.");
            }

            return Ok($"Uspešno ažuriran stan. Ulica: {nekretnine.ImeUlice}");
        }

        [HttpPut]
        [Route("PromeniSobu")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public async Task<IActionResult> ChangeSoba([FromBody] SobaBasic sb, int nId)
        {
            (bool isError, var nekretnine, ErrorMessage? error) = await DataProvider.AzurirajSobuAsync(sb, nId);

            if (isError)
            {
                return StatusCode(error?.StatusCode ?? 400, error?.Message);
            }

            if (nekretnine == null)
            {
                return BadRequest("Soba nije validna.");
            }

            return Ok($"Uspešno ažurirana soba. Ulica: {nekretnine.ImeUlice}");
        }

        [HttpDelete]
        [Route("IzbrisiNekretninu/{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public async Task<IActionResult> DeleteNekretnina(int id)
        {
            var data = await DataProvider.ObrisiNekretninuAsync(id);

            if (data.IsError)
            {
                return StatusCode(data.Error.StatusCode, data.Error.Message);
            }

            return StatusCode(204, $"Uspešno obrisana nekretnina. ID: {id}");
        }

    }
}
