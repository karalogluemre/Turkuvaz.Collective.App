using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TCA.Business.Interface;
using TCA.Entities.Models;

namespace TCA.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonsPozinationsHoldingController : ControllerBase
    {
        private readonly IPersonsPositionsHolding _personsPositionHolding;
        public PersonsPozinationsHoldingController(IPersonsPositionsHolding personsPositionHolding)
        {
            _personsPositionHolding = personsPositionHolding;
        }
        [HttpGet]
        public Task<List<PersonsPositionsHolding>> GetPersonsPozinationsDR(string userName, string password)
        {
            return _personsPositionHolding.GetAllModel(userName, password);
        }
    }
}
