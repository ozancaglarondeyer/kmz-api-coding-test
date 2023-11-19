using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkilliTicaretWebShare.DTO
{
    public class UrunListeDTO
    {
        public UrunListeDTO()
        {
            BagliUrunList = new UrunEnvanterDTO[0];
        }
        public long UrunId { get; set; }
        public string UrunAdi { get; set; }
        public decimal EnDusukBirimdekiSatisFiyati { get; set; }
        public UrunEnvanterDTO[] BagliUrunList { get; set; }
    }



}
