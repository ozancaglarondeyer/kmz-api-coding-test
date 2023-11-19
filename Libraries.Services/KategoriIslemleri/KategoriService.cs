using AkilliTicaretWebShare.DTO;
using Libraries.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libraries.Services.KategoriIslemleri
{
    public class KategoriService : IKategoriService
    {
        private readonly ApplicationDbContext _dbContext;
        public KategoriService(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public long[] AltKategoriIdsGetir(long[] kategoriIds)
        {
            List<long> tumAltKategoriIdList = new List<long>();
            foreach (long kategoriId in kategoriIds)
            {   
                Kategori kategori = _dbContext.Kategori.FirstOrDefault(k => k.Id == kategoriId);
                if (kategori == null)
                {
                    throw new Exception("Kategori bulunamadı");
                }
                tumAltKategoriIdList.Add(kategoriId);
                long[] altKategoriIds = altKategoriGetir(kategoriId);
                tumAltKategoriIdList.AddRange(altKategoriIds);
                while (altKategoriIds.Length > 0)
                {
                    List<long> yeniAltKategoriIds = new List<long>();

                    foreach (long altKategoriId in altKategoriIds)
                    {
                        long[] altKategoriler = altKategoriGetir(altKategoriId);
                        yeniAltKategoriIds.AddRange(altKategoriler);
                    }

                    altKategoriIds = yeniAltKategoriIds.ToArray();
                    tumAltKategoriIdList.AddRange(altKategoriIds);
                }
            }
            tumAltKategoriIdList = tumAltKategoriIdList.Distinct().ToList();
            return tumAltKategoriIdList.ToArray();
        }
        private long[] altKategoriGetir(long kategoriId)
        {   
            Kategori[] kategoriList = _dbContext.Kategori.Where(k => k.ParentId == kategoriId).ToArray();
            long[] kategoriIds = kategoriList.Select(k => k.Id).ToArray();
            return kategoriIds;
        }

        public KategoriUstHiyerarsiDTO KategoriUstHiyerarsiGetir(long kategoriId)
        {
            try
            {

                Kategori kategori = _dbContext.Kategori.Where(k => k.Id == kategoriId).FirstOrDefault();
                if (kategori == null)
                {
                    throw new Exception("Kategori Bulunamadı");
                }

                KategoriUstHiyerarsiDTO kategoriUstHiyerarsi = new KategoriUstHiyerarsiDTO();
                kategoriUstHiyerarsi.KategoriId = kategori.Id;
                kategoriUstHiyerarsi.KategoriAdi = kategori.Ad;
                kategoriUstHiyerarsi.ParentKaregoriId = kategori.ParentId;


                long parentId = kategori.ParentId;



                KategoriUstHiyerarsiDTO tempKategoriUstHiyerarsi = new KategoriUstHiyerarsiDTO();
                tempKategoriUstHiyerarsi = kategoriUstHiyerarsi;
                while (parentId > 0)
                {
                    Kategori altKategori = _dbContext.Kategori.Where(k => k.Id == parentId).FirstOrDefault();
                    if (kategori == null)
                    {
                        throw new Exception("Kategori Bulunamadı");
                    }
                    KategoriUstHiyerarsiDTO kategoriUstHiyerarsiAltKategori = new KategoriUstHiyerarsiDTO();
                    kategoriUstHiyerarsiAltKategori.KategoriId = altKategori.Id;
                    kategoriUstHiyerarsiAltKategori.KategoriAdi = altKategori.Ad;
                    kategoriUstHiyerarsiAltKategori.ParentKaregoriId = altKategori.ParentId;
                    tempKategoriUstHiyerarsi.ParentKategori = kategoriUstHiyerarsiAltKategori;
                    tempKategoriUstHiyerarsi = kategoriUstHiyerarsiAltKategori;
                    parentId = altKategori.ParentId;
                }
                return kategoriUstHiyerarsi;
            }
            catch (Exception ex)
            {
                throw new Exception("Kategori Hiyerarsisi Getirilemedi " + ex.Message);
            }
        }





    }
}
