using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCA.Entities.Models
{
    public class Values<T> where T : class,new()
    {
        public List<T> VALUES { get; set; }
    }
}
