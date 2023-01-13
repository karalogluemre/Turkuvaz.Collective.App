using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TCA.Business.Interface;
using TCA.Entities.Models;

namespace TCA.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrganizationLewelInfoHoldingController : ControllerBase
    {
        public IOrganizationLewelHoldingService _lewelHolding;
        public OrganizationLewelInfoHoldingController(IOrganizationLewelHoldingService lewelHolding)
        {
            _lewelHolding = lewelHolding;
        }

        [HttpGet]
        public async Task<List<OrganizationLewelHolding>> GetOrganizationLewelInfoHolding(string userName, string password)
        {
            return await _lewelHolding.GetAllModel(userName, password);
        }
    }
}
