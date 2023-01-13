using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TCA.Business.Interface;
using TCA.Entities.Models;

namespace TCA.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AllPersonsInfoController : ControllerBase
    {
        public IAllPersonsInfoService _allPersonsInfoService;
        public AllPersonsInfoController(IAllPersonsInfoService allPersonsInfoService)
        {
            _allPersonsInfoService = allPersonsInfoService;
        }

        [HttpGet]
        public async Task<List<AllPersonsInfo>> GetAdresses(string userName, string password)
        {
            return await _allPersonsInfoService.GetAllModel(userName, password);
        }
    }
}
