using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkilliTicaretWebShare.DTO
{
    public class KategoriUstHiyerarsiDTO
    {
        public long KategoriId { get; set; }
        public string KategoriAdi { get; set; }
        public long ParentKaregoriId { get; set; }
        public KategoriUstHiyerarsiDTO ParentKategori { get; set; }

    }
}
