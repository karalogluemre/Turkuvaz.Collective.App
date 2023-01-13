using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TCA.Business.Interface;
using TCA.Entities.Models;

namespace TCA.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrganizationLewelInfoDRController : ControllerBase
    {
        public IOrganizationLewelDrService _lewelInfoDr;
        public OrganizationLewelInfoDRController(IOrganizationLewelDrService lewelInfoDr)
        {
            _lewelInfoDr = lewelInfoDr;
        }

        [HttpGet]
        public async Task<List<OrganizationLewelDR>> GetOrganizationLewelInfoDR(string userName, string password)
        {
            return await _lewelInfoDr.GetAllModel(userName, password);
        }
    }
}
