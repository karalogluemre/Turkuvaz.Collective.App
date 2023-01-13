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
    public class AdressesHoldingManager : IAdressesHoldingService
    {
        public IHttpGenericService<PersonsCards> _htppGenericService;
        public AdressesHoldingManager(IHttpGenericService<PersonsCards> htppGenericService)
        {
            _htppGenericService = htppGenericService;
        }
        public async Task<List<PersonsCards>> GetAllModel(string userName, string password)
        {
            return await _htppGenericService.GetAllModel(userName, password);
        }

        public async Task<List<PersonsCards>> GetValuesAndBrevityAllModel(string userName, string password)
        {
            return await _htppGenericService.GetValuesAndBrevityAllModel(userName, password);
        }
    }
}
