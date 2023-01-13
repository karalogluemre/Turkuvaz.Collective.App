using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TCA.Business.Interface;
using TCA.Entities.Models;

namespace TCA.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonsCardsDrController : ControllerBase
    {
        public IAdressesDrService _adressesdrService;
        public PersonsCardsDrController(IAdressesDrService adressesdrService)
        {
            _adressesdrService = adressesdrService;
        }

        [HttpGet]
        public Task<List<PersonsCardsDR>> GetAdresses(string userName, string password)
        {
            return _adressesdrService.GetValuesAndBrevityAllModel(userName, password);
        }
    }
}
