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
using TCA.Entities.Models.HR_Models;

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
            return _peoplesSourceAccessService.GetAllModel(userName, password);
        }
        [HttpPost]
        public async Task<IActionResult> SavePeopleAccess(string username, string password)
        {
            List<PeopleSourceAccess> peopleSourceAccesses = await _peoplesSourceAccessService.GetAllModel(username, password);
            foreach (var item in peopleSourceAccesses)
            {
                _peoplesSourceAccessService.Add(new HR_IK_Yetki
                {
                    AdiSoyadi = String.IsNullOrEmpty(item.CNAME) ? "" : item.CNAME,
                    Sicil = String.IsNullOrEmpty(item.PERNR) ? 0 : Convert.ToInt32(item.PERNR),
                    OrganizasyonAnahtari = String.IsNullOrEmpty(item.VDSK1) ? "" : item.VDSK1,
                    APIStatus = 1,
                    CreateDatetime = DateTime.Now,
                    CreateUserID = 1,
                    Durum = 1,
                    //HR_IK_Yetki model da ID alanı da gönderilmeye çalışıldığı için hata alınıyor gibi :) 
                });
            }
            return Ok();
        }
    }
}
