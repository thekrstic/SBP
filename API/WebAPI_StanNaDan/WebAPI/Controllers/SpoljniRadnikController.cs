using Microsoft.AspNetCore.Mvc;
using StanNaDan;
using StanNaDan.Entiteti;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SpoljniRadnikController : ControllerBase
    {
        [HttpGet]
        [Route("PreuzmiRadnika/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public IActionResult GetRadnik(int id)
        {
            (bool isError, SpoljniRadnikPregled radnik, ErrorMessage? error) = DataProvider.vratiRadnika(id);

            if (isError)
            {
                return StatusCode(error?.StatusCode ?? 400, error?.Message);
            }

            return Ok(radnik);
        }

        [HttpPost]
        [Route("DodajRadnika")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public async Task<IActionResult> AddRadnik([FromBody] SpoljniRadnikBasic nb)
        {
            var data = await DataProvider.dodajSpoljnogRadnikaAsync(nb);

            if (data.IsError)
            {
                return StatusCode(data.Error.StatusCode, data.Error.Message);
            }

            return StatusCode(201, $"Uspešno dodat radnik. Datum: {nb.DatumAngazovanja}");
        }

        [HttpPut]
        [Route("PromeniRadnika")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public async Task<IActionResult> ChangeRadnik([FromBody] SpoljniRadnikBasic kb)
        {
            (bool isError, var radnik, ErrorMessage? error) = await DataProvider.azurirajRadnikaAsync(kb);

            if (isError)
            {
                return StatusCode(error?.StatusCode ?? 400, error?.Message);
            }

            if (radnik == null)
            {
                return BadRequest("Radnik nije validan.");
            }

            return Ok($"Uspešno ažuriran radnik. Datum: {kb.DatumAngazovanja}");
        }


        [HttpDelete]
        [Route("IzbrisiRadnika/{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public async Task<IActionResult> DeleteRadnik(int id)
        {
            var data = await DataProvider.ObrisiRadnikaAsync(id);

            if (data.IsError)
            {
                return StatusCode(data.Error.StatusCode, data.Error.Message);
            }

            return StatusCode(204, $"Uspešno obrisan radnik. ID: {id}");
        }

    }
}
