using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TCA.Business.Interface;
using TCA.Entities.Models;

namespace TCA.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonsPozinationsDRController : ControllerBase
    {
        private readonly IPersonsPositionsDR _personsPositionDr;
        public PersonsPozinationsDRController(IPersonsPositionsDR personsPositionDr)
        {
            _personsPositionDr = personsPositionDr;
        }
        [HttpGet]
        public Task<List<PersonsPositionsDR>> GetPersonsPozinationsDR(string userName, string password)
        {
            return _personsPositionDr.GetAllModel(userName, password);
        }
    }
}
