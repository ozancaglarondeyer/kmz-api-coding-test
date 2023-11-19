using AkilliTicaretWebShare.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libraries.Services.KategoriIslemleri
{
    public interface IKategoriService
    {
        KategoriUstHiyerarsiDTO KategoriUstHiyerarsiGetir(long kategoriId);
        long[] AltKategoriIdsGetir(long[] kategoriIds);
    }
}
