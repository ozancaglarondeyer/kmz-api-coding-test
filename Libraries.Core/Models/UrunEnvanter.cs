using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libraries.Core.Models
{
    public class UrunEnvanter : BaseEntity
    {
        public long UrunId { get; set; }
        public string Ad { get; set; }
        public long MarkaId { get; set; }
        public long KategoriId { get; set; }
        public long EnvanterId { get; set; }
        public int Adet { get; set; }

    }
}
