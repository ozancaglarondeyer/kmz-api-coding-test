using AkilliTicaretWebShare.CO;
using AkilliTicaretWebShare.DTO;
using Libraries.Core.Models;
using Libraries.Services.KategoriIslemleri;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libraries.Services.UrunIslemleri
{
    public class UrunService : IUrunService
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly IKategoriService _kategoriService;

        public UrunService(ApplicationDbContext dbContext, IKategoriService kategoriService)
        {
            _dbContext = dbContext;
            _kategoriService = kategoriService;
        }

        public UrunAyrintiDTO UrunGetir(long urunId)
        {
            try
            {
                Urun urun = _dbContext.Urun.Where(u => u.Id == urunId).FirstOrDefault();
                if (urun == null)
                {
                    throw new Exception("Ürün Bulunamadı.");
                }
                UrunAyrintiDTO urunAyrinti = new UrunAyrintiDTO();
                urunAyrinti.UrunId = urun.Id;
                urunAyrinti.UrunAdi = urun.UrunAdi;
                var urunEnvanterBilgiList = (from ue in _dbContext.UrunEnvanter 
                                             join m in _dbContext.Marka on ue.MarkaId equals m.Id
                                             where m.SilinmeTarih == null && ue.SilinmeTarih == null &&
                                             ue.UrunId == urunId
                                             select new
                                             {   
                                                 urunEnvanterId = ue.Id,
                                                 envanterId = ue.EnvanterId,
                                                 urunEnvanterAdi = ue.Ad,
                                                 urunMarkasi = m.Ad,
                                                 kategoriId = ue.KategoriId
                                             }).ToArray();
                List<UrunAyrintEnvanterDTO> urunEnvanterList = new List<UrunAyrintEnvanterDTO>();
                foreach (var urunEnvanterBilgi in urunEnvanterBilgiList)
                {
                    UrunAyrintEnvanterDTO urunEnvanter = new UrunAyrintEnvanterDTO();
                    urunEnvanter.UrunEnvanterId = urunEnvanterBilgi.urunEnvanterId;
                    urunEnvanter.UrunAdi = urunEnvanterBilgi.urunEnvanterAdi;
                    urunEnvanter.UrunMarkaAdi = urunEnvanterBilgi.urunMarkasi;

                    StokDTO[] stokList = (from ds in _dbContext.DepoStok
                                          join d in _dbContext.Depo on ds.DepoId equals d.Id
                                          where ds.SilinmeTarih == null && d.SilinmeTarih == null &&
                                          ds.EnvanterId == urunEnvanterBilgi.envanterId
                                          select new StokDTO()
                                          {
                                              DepoId = d.Id,
                                              DepoAdi = d.Ad,
                                              StokAdedi = ds.StokAdedi
                                          }).ToArray();
                    urunEnvanter.StokList = stokList;
                    KategoriUstHiyerarsiDTO ustHiyerarsi = _kategoriService.KategoriUstHiyerarsiGetir(urunEnvanterBilgi.kategoriId);
                    urunEnvanter.KategoriHiyerarsi = ustHiyerarsi;
                    urunEnvanterList.Add(urunEnvanter);
                }
                urunAyrinti.BagliUrunList = urunEnvanterList.ToArray();

                SatisBirimFiyatDTO[] satisBirimFiyatList = (from sf in _dbContext.SatisFiyati
                                                            join sb in _dbContext.SatisBirimi on sf.SatisBirimiId equals sb.Id
                                                            where sf.UrunId == urunId
                                                            select new SatisBirimFiyatDTO()
                                                            {
                                                                SatisFiyatId = sf.Id,
                                                                SatisBirimId = sb.Id,
                                                                BirimAdi = sb.SatisBirimiAdi,
                                                                BirimAdedi = sb.Miktar,
                                                                SatisFiyati = sf.Fiyat
                                                            }).ToArray();
                urunAyrinti.SatisBirimFiyatList = satisBirimFiyatList;
                return urunAyrinti;

            }
            catch (Exception ex)
            {
                throw new Exception("Ürün Getirilemedi.");
            }
        }

        public UrunListeDTO[] UrunListesiGetir(UrunListesiCO kriter)
        {
            try
            {
                if (kriter == null)
                {
                    return new UrunListeDTO[0];
                }
                bool isEmptyKategoriIds = kriter.KategoriIds == null || kriter.KategoriIds.Length == 0;
                kriter.KategoriIds = kriter.KategoriIds ?? new long[0];
                bool isEmptyMarkaIds = kriter.MarkaIds == null || kriter.MarkaIds.Length == 0;
                kriter.MarkaIds = kriter.MarkaIds ?? new long[0];
                if (kriter.KategoriIds.Length > 0)
                {
                    kriter.KategoriIds = _kategoriService.AltKategoriIdsGetir(kriter.KategoriIds);
                }

                var urunList = (from u in _dbContext.Urun
                                join ue in _dbContext.UrunEnvanter on u.Id equals ue.UrunId
                                join m in _dbContext.Marka on ue.MarkaId equals m.Id
                                where u.SilinmeTarih == null && m.SilinmeTarih == null && ue.SilinmeTarih == null &&
                                (isEmptyKategoriIds || kriter.KategoriIds.Contains(ue.KategoriId)) &&
                                (isEmptyMarkaIds || kriter.KategoriIds.Contains(ue.MarkaId))
                                select new
                                {
                                    urunId = u.Id,
                                    urunAdi = u.UrunAdi,
                                    urunEnvanterId = ue.Id,
                                    envanterId = ue.EnvanterId,
                                    urunEnvanterAdi = ue.Ad,
                                    urunMarkasi = m.Ad
                                }).ToArray();
                List<UrunListeDTO> urunListesi = new List<UrunListeDTO>();
                var urunGrupList = urunList.GroupBy(u => u.urunId).ToArray();
                foreach (var urunGrup in urunGrupList)
                {
                    var urunBilgi = urunGrup.FirstOrDefault();

                    UrunListeDTO urun = new UrunListeDTO();
                    urunListesi.Add(urun);

                    urun.UrunId = urunBilgi.urunId;
                    urun.UrunAdi = urunBilgi.urunAdi;

                    SatisBirimFiyatDTO[] satisBirimFiyatList = (from sf in _dbContext.SatisFiyati
                                                                join sb in _dbContext.SatisBirimi on sf.SatisBirimiId equals sb.Id
                                                                where sf.UrunId == urunBilgi.urunId
                                                                select new SatisBirimFiyatDTO()
                                                                {
                                                                    SatisFiyatId = sf.Id,
                                                                    SatisBirimId = sb.Id,
                                                                    BirimAdi = sb.SatisBirimiAdi,
                                                                    BirimAdedi = sb.Miktar,
                                                                    SatisFiyati = sf.Fiyat
                                                                }).ToArray();


                    SatisBirimFiyatDTO enDusuksatisFiyati = satisBirimFiyatList.OrderBy(sf => sf.BirimAdedi).FirstOrDefault();
                    if (enDusuksatisFiyati != null)
                    {
                        urun.EnDusukBirimdekiSatisFiyati = enDusuksatisFiyati.SatisFiyati;
                    }
                    List<UrunEnvanterDTO> urunEnvanterList = new List<UrunEnvanterDTO>();
                    foreach (var bagliUrun in urunGrup)
                    {
                        UrunEnvanterDTO urunEnvanter = new UrunEnvanterDTO();
                        urunEnvanter.UrunEnvanterId = bagliUrun.urunEnvanterId;
                        urunEnvanter.UrunAdi = bagliUrun.urunEnvanterAdi;
                        urunEnvanter.UrunMarkaAdi = bagliUrun.urunMarkasi;

                        StokDTO[] stokList = (from ds in _dbContext.DepoStok
                                              join d in _dbContext.Depo on ds.DepoId equals d.Id
                                              where ds.SilinmeTarih == null && d.SilinmeTarih == null &&
                                              ds.EnvanterId == bagliUrun.envanterId
                                              select new StokDTO()
                                              {
                                                  DepoId = d.Id,
                                                  DepoAdi = d.Ad,
                                                  StokAdedi = ds.StokAdedi
                                              }).ToArray();
                        urunEnvanter.StokList = stokList;
                        urunEnvanterList.Add(urunEnvanter);
                    }
                    urun.BagliUrunList = urunEnvanterList.ToArray();
                }
                if (kriter.FiyaraGoreSirala)
                {
                    // TODO: descending durumu

                    urunListesi = urunListesi.OrderBy(u => u.EnDusukBirimdekiSatisFiyati).ToList();
                }
                return urunListesi.ToArray();

            }
            catch (Exception ex)
            {

                throw new Exception("Ürün Listesi Getirilemedi. " + ex.Message);
            }

        }
    }
}
