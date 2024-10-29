using Microsoft.AspNetCore.Mvc;
using StanNaDan;
using StanNaDan.Entiteti;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ParkingController : ControllerBase
    {
        [HttpGet]
        [Route("PreuzmiParking/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public IActionResult GetParking(int id)
        {
            (bool isError, ParkingPregled parking, ErrorMessage? error) = DataProvider.vratiParking(id);

            if (isError)
            {
                return StatusCode(error?.StatusCode ?? 400, error?.Message);
            }

            return Ok(parking);
        }

        [HttpPost]
        [Route("DodajParking")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public async Task<IActionResult> AddParking([FromBody] ParkingBasic nb, int idN)
        {
            var data = await DataProvider.dodajParking(nb, idN);

            if (data.IsError)
            {
                return StatusCode(data.Error.StatusCode, data.Error.Message);
            }

            return StatusCode(201, $"Uspešno dodat parking. Javni?: {nb.Javni}");
        }

        [HttpPut]
        [Route("PromeniParking")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public async Task<IActionResult> ChangeParking([FromBody] ParkingBasic kb)
        {
            (bool isError, var parking, ErrorMessage? error) = await DataProvider.azurirajParkingAsync(kb);

            if (isError)
            {
                return StatusCode(error?.StatusCode ?? 400, error?.Message);
            }

            if (parking == null)
            {
                return BadRequest("Parking nije validan.");
            }

            return Ok($"Uspešno ažuriran parking. Javni?: {kb.Javni}");
        }


        [HttpDelete]
        [Route("IzbrisiParking/{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public async Task<IActionResult> DeleteParking(int id)
        {
            var data = await DataProvider.obrisiParkingAsync(id);

            if (data.IsError)
            {
                return StatusCode(data.Error.StatusCode, data.Error.Message);
            }

            return StatusCode(204, $"Uspešno obrisan parking. ID: {id}");
        }

    }
}
