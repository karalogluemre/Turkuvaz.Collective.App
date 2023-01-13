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
    public class AdressesDRManager : IAdressesDrService
    {
        public IHttpGenericService<PersonsCardsDR> _htppGenericService;
        public AdressesDRManager(IHttpGenericService<PersonsCardsDR> htppGenericService)
        {
            _htppGenericService = htppGenericService;
        }
        public async Task<List<PersonsCardsDR>> GetAllModel(string userName, string password)
        {
            return await _htppGenericService.GetAllModel(userName, password);
        }

        public async Task<List<PersonsCardsDR>> GetValuesAndBrevityAllModel(string userName, string password)
        {
            return await _htppGenericService.GetValuesAndBrevityAllModel(userName, password);
        }
    }
}
