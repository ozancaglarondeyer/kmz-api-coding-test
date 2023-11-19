using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libraries.Core.Models
{
    public class SatisFiyati : BaseEntity
    {
        public decimal Fiyat { get; set; }
        public long UrunId { get; set; }
        public long SatisBirimiId { get; set; }
    }
}
