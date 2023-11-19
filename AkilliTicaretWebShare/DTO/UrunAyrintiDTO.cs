using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkilliTicaretWebShare.DTO
{
    public class UrunAyrintiDTO
    {
        public UrunAyrintiDTO()
        {
            BagliUrunList = new UrunAyrintEnvanterDTO[0];
            SatisBirimFiyatList = new SatisBirimFiyatDTO[0];
        }
        public long UrunId { get; set; }
        public string UrunAdi { get; set; }
        public UrunAyrintEnvanterDTO[] BagliUrunList { get; set; }
        public SatisBirimFiyatDTO[] SatisBirimFiyatList { get; set; }
    }
}
