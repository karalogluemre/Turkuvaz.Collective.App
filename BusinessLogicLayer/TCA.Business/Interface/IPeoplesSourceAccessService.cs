using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TCA.Business.GenericService;
using TCA.Entities.Models;
using TCA.Entities.Models.HR_Models;

namespace TCA.Business.Interface
{
    public interface IPeoplesSourceAccessService : IHttpGenericService<PeopleSourceAccess>,IBaseService<HR_IK_Yetki>
    {
    }
}
