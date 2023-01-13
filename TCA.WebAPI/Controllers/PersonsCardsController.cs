using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TCA.Business.Interface;
using TCA.Entities.Models;

namespace TCA.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //[Authorize]
    public class PersonsCardsController : ControllerBase
    {
        public IAdressesHoldingService _adressesHoldingService;
        public PersonsCardsController(IAdressesHoldingService adressesHoldingService)
        {
            _adressesHoldingService = adressesHoldingService;
        }

        [HttpGet]
        public Task<List<PersonsCards>> GetAdresses(string userName, string password)
        {
            return _adressesHoldingService.GetValuesAndBrevityAllModel(userName, password);
        }
    }
}
