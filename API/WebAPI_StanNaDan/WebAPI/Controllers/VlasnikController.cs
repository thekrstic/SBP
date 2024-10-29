using Microsoft.AspNetCore.Mvc;
using StanNaDan;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class VlasnikController : ControllerBase
    {
        [HttpGet]
        [Route("PreuzmiVlasnike")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public IActionResult GetNekretnine()
        {
            (bool isError, List<VlasnikPregled> vlasnici, ErrorMessage? error) = DataProvider.GetVlasnikePregled();

            if (isError)
            {
                return StatusCode(error?.StatusCode ?? 400, error?.Message);
            }

            return Ok(vlasnici);
        }

        [HttpPost]
        [Route("DodajPravnoLice")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public async Task<IActionResult> AddPravnoLice([FromBody] PravnoLiceBasic plb)
        {
            var data = await DataProvider.DodajPravnoLiceAsync(plb);

            if (data.IsError)
            {
                return StatusCode(data.Error.StatusCode, data.Error.Message);
            }

            return StatusCode(201, $"Uspešno dodato pravno lice. PIB: {plb.PIB}");
        }

        [HttpPost]
        [Route("DodajFizickoLice")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public async Task<IActionResult> AddFizickoLice([FromBody] FizickoLiceBasic flb)
        {
            var data = await DataProvider.DodajFizickoLiceAsync(flb);

            if (data.IsError)
            {
                return StatusCode(data.Error.StatusCode, data.Error.Message);
            }

            return StatusCode(201, $"Uspešno dodato fizicko lice. JMBG: {flb.JMBG}");
        }

        [HttpPost]
        [Route("DodajBankovniRacunPravnoLice/{brb}")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public async Task<IActionResult> AddBankovniPravnoLice(BankovniRacunBasic brb, int id)
        {
            var data = await DataProvider.DodajBankovniRacunPravnoLiceAsync(brb, id);

            if (data.IsError)
            {
                return StatusCode(data.Error.StatusCode, data.Error.Message);
            }

            return StatusCode(201, $"Uspešno dodat bankovni racun. BRB: {brb.BrojRacuna}");
        }

        [HttpPost]
        [Route("DodajBankovniRacunFizickoLice/{brb}")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public async Task<IActionResult> AddBankovniFizickoLice(BankovniRacunBasic brb, int id)
        {
            var data = await DataProvider.DodajBankovniRacunFizickoLiceAsync(brb, id);

            if (data.IsError)
            {
                return StatusCode(data.Error.StatusCode, data.Error.Message);
            }

            return StatusCode(201, $"Uspešno dodat bankovni racun. BRB: {brb.BrojRacuna}");
        }

        [HttpPut]
        [Route("PromeniPravnoLice")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public async Task<IActionResult> ChangePLice([FromBody] PravnoLiceBasic kb, int nId)
        {
            (bool isError, var pravno, ErrorMessage? error) = await DataProvider.AzurirajPravnoLiceAsync(kb, nId);

            if (isError)
            {
                return StatusCode(error?.StatusCode ?? 400, error?.Message);
            }

            if (pravno == null)
            {
                return BadRequest("Lice nije validno.");
            }

            return Ok($"Uspešno ažurirano pravno lice. PIB: {pravno.PIB}");
        }

        [HttpPut]
        [Route("PromeniFizickoLice")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public async Task<IActionResult> ChangeFLice([FromBody] FizickoLiceBasic kb, int nId)
        {
            (bool isError, var fizicko, ErrorMessage? error) = await DataProvider.AzurirajFizickoLiceAsync(kb, nId);

            if (isError)
            {
                return StatusCode(error?.StatusCode ?? 400, error?.Message);
            }

            if (fizicko == null)
            {
                return BadRequest("Lice nije validno.");
            }

            return Ok($"Uspešno ažurirano fizicko lice. JMBG: {fizicko.JMBG}");
        }

        [HttpDelete]
        [Route("IzbrisiPravnoLice/{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public async Task<IActionResult> DeletePravnoLice(int id)
        {
            var data = await DataProvider.ObrisiPravnoLiceAsync(id);

            if (data.IsError)
            {
                return StatusCode(data.Error.StatusCode, data.Error.Message);
            }

            return StatusCode(204, $"Uspešno obrisano pravno lice. ID: {id}");
        }

        [HttpDelete]
        [Route("IzbrisiFizickoLice/{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public async Task<IActionResult> DeleteFizickoLice(int id)
        {
            var data = await DataProvider.ObrisiFizickoLiceAsync(id);

            if (data.IsError)
            {
                return StatusCode(data.Error.StatusCode, data.Error.Message);
            }

            return StatusCode(204, $"Uspešno obrisano fizicko lice. ID: {id}");
        }

    }
}
