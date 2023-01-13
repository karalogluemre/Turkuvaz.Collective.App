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
    public class ActivePassiveUsersManager : IActivePassiveUsersService
    {
        public IHttpGenericService<ActivePassiveUsers> _httpGenericService;
        public ActivePassiveUsersManager(IHttpGenericService<ActivePassiveUsers> httpGenericService)
        {
            _httpGenericService = httpGenericService;
        }
        public Task<List<ActivePassiveUsers>> GetAllModel(string userName, string password)
        {
            return _httpGenericService.GetAllModel(userName, password);
        }

        public async Task<List<ActivePassiveUsers>> GetValuesAndBrevityAllModel(string userName, string password)
        {
            return await _httpGenericService.GetValuesAndBrevityAllModel(userName, password);
        }
    }
}
