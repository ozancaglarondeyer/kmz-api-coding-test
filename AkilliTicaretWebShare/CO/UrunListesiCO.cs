using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkilliTicaretWebShare.CO
{
    public class UrunListesiCO
    {
        public UrunListesiCO()
        {
            KategoriIds = new long[0];
            MarkaIds = new long[0];
        }
        public long[] KategoriIds { get; set; }
        public long[] MarkaIds { get; set; }
        public bool FiyaraGoreSirala { get; set; }
    }
}
