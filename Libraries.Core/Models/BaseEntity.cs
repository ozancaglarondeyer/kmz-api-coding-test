using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libraries.Core.Models
{
    public class BaseEntity
    {
        public long Id { get; set; }
        public DateTime KayitTarih { get; set; }
        public DateTime? GuncellemeTarih { get; set; }
        public DateTime? SilinmeTarih { get; set; }
    }
}
