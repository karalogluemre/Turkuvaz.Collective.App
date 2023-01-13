using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCA.Entities
{
    public class BaseEntity
    {
        [Key]
        public int ID { get; set; }
        public int Durum { get; set; } = 0;
        public DateTime CreateDatetime { get; set; } = DateTime.UtcNow;
        public int CreateUserID { get; set; } = 0;
        [Required]
        public int APIStatus { get; set; }
    }
}
