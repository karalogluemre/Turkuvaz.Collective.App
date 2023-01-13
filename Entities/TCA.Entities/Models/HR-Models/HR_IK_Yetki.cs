using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace TCA.Entities.Models.HR_Models
{
    public class HR_IK_Yetki : BaseEntity, IEntity
    {
        public int Sicil { get; set; }
        public string OrganizasyonAnahtari { get; set; }
        public string AdiSoyadi { get; set; }

    }
}
