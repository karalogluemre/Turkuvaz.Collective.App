using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TCA.Business.GenericService;
using TCA.Business.Interface;
using TCA.Entities.Models;

namespace TCA.Business.Concrete
{
    public class AllPersonsInfoManager : IAllPersonsInfoService
    {
        public IHttpGenericService<AllPersonsInfo> _htppGenericService;
        public AllPersonsInfoManager(IHttpGenericService<AllPersonsInfo> htppGenericService)
        {
            _htppGenericService = htppGenericService;
        }
        public async Task<List<AllPersonsInfo>> GetAllModel(string userName, string password)
        {
            return await _htppGenericService.GetAllModel(userName, password);
        }

        public async Task<List<AllPersonsInfo>> GetValuesAndBrevityAllModel(string userName, string password)
        {
            throw new NotImplementedException();
        }
    }
}
