using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libraries.Core.Models
{
    public class DepoStok : BaseEntity
    {
        public long DepoId { get; set; }
        public long EnvanterId { get; set; }
        public int StokAdedi { get; set; }
        //public Depo Depo { get; set; }
        //public Envanter Envanter { get; set; }
    }
}
