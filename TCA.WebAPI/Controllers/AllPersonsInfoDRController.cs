using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TCA.Business.Interface;
using TCA.Entities.Models;

namespace TCA.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AllPersonsInfoDRController : ControllerBase
    {
        public IAllPersonsInfoDRServices _allPersonsInfoDrService;
        public AllPersonsInfoDRController(IAllPersonsInfoDRServices allPersonsInfoDrService)
        {
            _allPersonsInfoDrService = allPersonsInfoDrService;
        }

        [HttpGet]
        public async Task<List<AllPersonsInfoDR>> GetAdresses(string userName, string password)
        {
            return await _allPersonsInfoDrService.GetAllModel(userName, password);
        }
    }
}
