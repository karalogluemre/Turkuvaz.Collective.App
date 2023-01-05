using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TCA.Business.Interface;

namespace TCA.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //[Authorize]
    public class ActivePassiveUsersControllers : ControllerBase
    {
        public IActivePassiveUsersService _activePassiveUsers;
        public ActivePassiveUsersControllers(IActivePassiveUsersService activePassiveUsers)
        {
            _activePassiveUsers = activePassiveUsers;
        }
        [HttpGet]
        public async Task<IActionResult> GetActivePassiveUsersDr(string username, string password)
        {
            return Ok(_activePassiveUsers.GetAllModel(username,password));
        }

    }
}
