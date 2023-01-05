using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Net;
using System.Net.Http.Headers;
using System.Reflection.PortableExecutable;
using System.Text;
using TCA.Business.Interface;
using TCA.DataAccess.Dtos;
using TCA.Entities.Models;

namespace TCA.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PeoplesSourceAccessController : ControllerBase
    {
        private readonly IPeoplesSourceAccessService _peoplesSourceAccessService;
        public PeoplesSourceAccessController(IPeoplesSourceAccessService peoplesSourceAccessService)
        {
            _peoplesSourceAccessService = peoplesSourceAccessService;
        }

        [HttpGet]
        public Task<List<PeopleSourceAccess>> GetPeopleSourceAccess(string userName, string password)
        {
            return _peoplesSourceAccessService.GetAllModel(userName,password);
        }
    }
}
