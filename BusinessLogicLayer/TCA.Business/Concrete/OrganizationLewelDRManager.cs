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
    public class OrganizationLewelDRManager : IOrganizationLewelDrService
    {
        public IHttpGenericService<OrganizationLewelDR> _htppGenericService;
        public OrganizationLewelDRManager(IHttpGenericService<OrganizationLewelDR> htppGenericService)
        {
            _htppGenericService = htppGenericService;
        }
        public async Task<List<OrganizationLewelDR>> GetAllModel(string userName, string password)
        {
            return await _htppGenericService.GetAllModel(userName, password);
        }

        public async Task<List<OrganizationLewelDR>> GetValuesAndBrevityAllModel(string userName, string password)
        {
            return await _htppGenericService.GetValuesAndBrevityAllModel(userName, password);
        }
    }
}
