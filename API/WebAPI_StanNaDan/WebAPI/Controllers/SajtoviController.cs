using Microsoft.AspNetCore.Mvc;
using StanNaDan;
using StanNaDan.Entiteti;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SajtoviController : ControllerBase
    {
        [HttpGet]
        [Route("PreuzmiSajtove/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public IActionResult GetSajtovi(int id)
        {
            (bool isError, List<SajtoviPregled> sajtovi, ErrorMessage? error) = DataProvider.vratiSajtoveNekretnine(id);

            if (isError)
            {
                return StatusCode(error?.StatusCode ?? 400, error?.Message);
            }

            return Ok(sajtovi);
        }

        [HttpPost]
        [Route("DodajSajt")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public async Task<IActionResult> AddSajt([FromBody] SajtoviBasic nb)
        {
            var data = await DataProvider.DodajSajtoveBasic(nb);

            if (data.IsError)
            {
                return StatusCode(data.Error.StatusCode, data.Error.Message);
            }

            return StatusCode(201, $"Uspešno dodat sajt. Sajt: {nb.Sajt}");
        }

        [HttpPut]
        [Route("PromeniSajt")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public async Task<IActionResult> ChangeSajt([FromBody] SajtoviBasic kb)
        {
            (bool isError, var sajt, ErrorMessage? error) = await DataProvider.izmeniSajt(kb);

            if (isError)
            {
                return StatusCode(error?.StatusCode ?? 400, error?.Message);
            }

            if (sajt == null)
            {
                return BadRequest("Sajt nije validan.");
            }

            return Ok($"Uspešno ažuriran sajt. Sajt: {kb.Sajt}");
        }


        [HttpDelete]
        [Route("IzbrisiSajt/{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public async Task<IActionResult> DeleteSajt(int id)
        {
            var data = await DataProvider.obrisiSajt(id);

            if (data.IsError)
            {
                return StatusCode(data.Error.StatusCode, data.Error.Message);
            }

            return StatusCode(204, $"Uspešno obrisan sajt. ID: {id}");
        }

    }
}
