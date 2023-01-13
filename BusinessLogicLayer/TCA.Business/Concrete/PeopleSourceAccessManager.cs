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
using TCA.Entities.Models.HR_Models;

namespace TCA.Business.Concrete
{
    public class PeopleSourceAccessManager : IPeoplesSourceAccessService
    {
        public IUnitOfWork _unitOfWork;
        public IHttpGenericService<PeopleSourceAccess> _httpGenericService;
        public PeopleSourceAccessManager(IUnitOfWork unitOfWork, IHttpGenericService<PeopleSourceAccess> httpGenericService)
        {
            _unitOfWork = unitOfWork;
            _httpGenericService = httpGenericService;
        }

        public void Add(HR_IK_Yetki entity)
        {
            _unitOfWork.peopleSourceAccessRepository.Add(entity);
        }

        public void Delete(HR_IK_Yetki entity)
        {
            _unitOfWork.peopleSourceAccessRepository.Delete(entity);
        }

        public async Task<List<PeopleSourceAccess>> GetAllModel(string userName, string password)
        {
            return await _httpGenericService.GetAllModel(userName, password);
        }

        public async Task<List<PeopleSourceAccess>> GetValuesAndBrevityAllModel(string userName, string password)
        {
            return await _httpGenericService.GetValuesAndBrevityAllModel(userName, password);
        }
    }
}
