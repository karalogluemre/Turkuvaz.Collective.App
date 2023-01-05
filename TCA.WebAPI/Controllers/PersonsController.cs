using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TCA.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class PersonsController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetAllPersons()
        {
            return Ok();
        }

        [HttpGet]
        [Route("GetByPersons")]
        public async Task<IActionResult> GetPersons(string a)
        {
            string[] data;
            return Ok(data = new string[] { "Vesile", "YAVASCİ", "31", "YAZILIM UZMANI" });
        }
    }
}
