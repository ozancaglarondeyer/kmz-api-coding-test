using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libraries.Core.Models
{
    public class SatisBirimi: BaseEntity
    {
        public string SatisBirimiAdi { get; set; }
        public int Miktar { get; set; }
    }
}
