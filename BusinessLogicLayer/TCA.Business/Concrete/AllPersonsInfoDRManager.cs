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
    public class AllPersonsInfoDRManager : IAllPersonsInfoDRServices
    {
        public IHttpGenericService<AllPersonsInfoDR> _htppGenericService;
        public AllPersonsInfoDRManager(IHttpGenericService<AllPersonsInfoDR> htppGenericService)
        {
            _htppGenericService = htppGenericService;
        }
        public async Task<List<AllPersonsInfoDR>> GetAllModel(string userName, string password)
        {
            return await _htppGenericService.GetAllModel(userName, password);
        }

        public async Task<List<AllPersonsInfoDR>> GetValuesAndBrevityAllModel(string userName, string password)
        {
            return await _htppGenericService.GetValuesAndBrevityAllModel(userName, password);
        }
    }
}
