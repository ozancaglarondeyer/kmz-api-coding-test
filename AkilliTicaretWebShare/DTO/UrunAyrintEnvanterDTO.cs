using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkilliTicaretWebShare.DTO
{
    public class UrunAyrintEnvanterDTO
    {
        public UrunAyrintEnvanterDTO()
        {
            StokList = new StokDTO[0];
        }
        public long UrunEnvanterId { get; set; }
        public string UrunAdi { get; set; }
        public string UrunMarkaAdi { get; set; }
        public StokDTO[] StokList { get; set; }
        public KategoriUstHiyerarsiDTO KategoriHiyerarsi { get; set; }
    }
}
