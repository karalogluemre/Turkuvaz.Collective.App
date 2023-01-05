using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TCA.Business.GenericService;
using TCA.Business.Interface;
using TCA.DataAccess.DataContracts;
using TCA.DataAccess.Interface;
using TCA.Entities.Models;

namespace TCA.Business.Concrete
{
    public class PeopleSourceAccessManager : IPeoplesSourceAccessService,IHttpGenericService<PeopleSourceAccess>
    {
        public IUnitOfWork _unitOfWork;
        public IHttpGenericService<PeopleSourceAccess> _httpGenericService;
        public PeopleSourceAccessManager(IUnitOfWork unitOfWork, IHttpGenericService<PeopleSourceAccess> httpGenericService)
        {
            _unitOfWork = unitOfWork;
            _httpGenericService = httpGenericService;
        }

        public async Task<List<PeopleSourceAccess>> GetAllModel(string userName, string password)
        {
            return await _httpGenericService.GetAllModel(userName, password);
        }
    }
}
