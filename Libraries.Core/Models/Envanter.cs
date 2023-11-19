using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libraries.Core.Models
{
    public class Envanter : BaseEntity
    {
        public string SKU { get; set; }
        public string EnvanterAdi { get; set; }
        public long SatisBirimiId { get; set; }
    }
}
