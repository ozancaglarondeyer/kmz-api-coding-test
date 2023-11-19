using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkilliTicaretWebShare.DTO
{
    public class SatisBirimFiyatDTO
    {
        public long SatisBirimId { get; set; }
        public long SatisFiyatId { get; set; }
        public string BirimAdi { get; set; }
        public int BirimAdedi { get; set; }
        public decimal SatisFiyati { get; set; }
    }
}
