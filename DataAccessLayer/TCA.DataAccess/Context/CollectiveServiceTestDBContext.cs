using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TCA.Entities.Models;
using TCA.Entities.Models.HR_Models;

namespace TCA.DataAccess.Context
{
    public class CollectiveServiceTestDBContext : DbContext
    {
        public CollectiveServiceTestDBContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<HR_Birim> HR_Birim { get; set; }
        public DbSet<HR_Bolum> HR_Bolum { get; set; }
        public DbSet<HR_Gorev> HR_Gorev { get; set; }
        public DbSet<HR_Grup> HR_Grup { get; set; }
        public DbSet<HR_IsAlani> HR_IsAlani { get; set; }
        public DbSet<HR_IK_Yetki> HR_IK_Yetki { get; set; }
        public DbSet<HR_Lokasyon> HR_Lokasyon { get; set; }
        public DbSet<HR_MasrafYeri> HR_MasrafYeri { get; set; }
        public DbSet<HR_MobilUsers> HR_MobilUsers { get; set; }
        public DbSet<HR_Organizasyon> HR_Organizasyon { get; set; }
        public DbSet<HR_Personel> HR_Personel { get; set; }
        public DbSet<HR_Personel_Taseron> HR_Personel_Taseron { get; set; }
        public DbSet<HR_Sirketler> HR_Sirketler { get; set; }
        public DbSet<HR_Sozlesme> HR_Sozlesme { get; set; }
        public DbSet<HR_Unvan> HR_Unvan { get; set; }
        public DbSet<HR_OrganizasyonAnahtar> HR_OrganizasyonAnahtar { get; set; }
        public DbSet<HR_Seviye> HR_Seviye { get; set; }
    }
}
