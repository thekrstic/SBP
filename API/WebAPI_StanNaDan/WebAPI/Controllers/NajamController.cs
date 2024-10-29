using Microsoft.AspNetCore.Mvc;
using StanNaDan;
using StanNaDan.Entiteti;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class NajamController : ControllerBase
    {
        [HttpGet]
        [Route("PreuzmiNajmove")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public IActionResult GetNajmove()
        {
            (bool isError, List<NajamPregled> najmovi, ErrorMessage? error) = DataProvider.GetNajamPregled();

            if (isError)
            {
                return StatusCode(error?.StatusCode ?? 400, error?.Message);
            }

            return Ok(najmovi);
        }

        [HttpPost]
        [Route("DodajNajam")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public async Task<IActionResult> AddNajam([FromBody] NajamBasic nb)
        {
            var data = await DataProvider.DodajNajamAsync(nb);

            if (data.IsError)
            {
                return StatusCode(data.Error.StatusCode, data.Error.Message);
            }

            return StatusCode(201, $"Uspešno dodat najam. Cena: {nb.CenaPoDanu}");
        }

        [HttpPost]
        [Route("DodajImaNajam")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public async Task<IActionResult> AddImaNajam([FromBody] ImaNajamBasic inb)
        {
            var data = await DataProvider.DodajImaNajamAsync(inb);

            if (data.IsError)
            {
                return StatusCode(data.Error.StatusCode, data.Error.Message);
            }

            return StatusCode(201, $"Uspešno dodat najam nekretnini. Cena: {inb.Najam.CenaPoDanu}");
        }

        [HttpPut]
        [Route("PromeniNajam")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public async Task<IActionResult> ChangeNajam([FromBody] NajamBasic kb)
        {
            (bool isError, var najam, ErrorMessage? error) = await DataProvider.AzurirajNajamAsync(kb);

            if (isError)
            {
                return StatusCode(error?.StatusCode ?? 400, error?.Message);
            }

            if (najam == null)
            {
                return BadRequest("Najam nije validan.");
            }

            return Ok($"Uspešno ažuriran najam. Cena: {najam.CenaPoDanu}");
        }


        [HttpDelete]
        [Route("IzbrisiNajam/{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public async Task<IActionResult> DeleteNajam(int id)
        {
            var data = await DataProvider.ObrisiNajamAsync(id);

            if (data.IsError)
            {
                return StatusCode(data.Error.StatusCode, data.Error.Message);
            }

            return StatusCode(204, $"Uspešno obrisan najam. ID: {id}");
        }

    }
}
