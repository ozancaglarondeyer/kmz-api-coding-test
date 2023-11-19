using AkilliTicaretWebShare.CO;
using AkilliTicaretWebShare.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libraries.Services.UrunIslemleri
{
    public interface IUrunService
    {
        UrunListeDTO[] UrunListesiGetir(UrunListesiCO kriter);
        UrunAyrintiDTO UrunGetir(long urunId);
    }
}
