using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libraries.Core.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<Depo> Depo { get; set; }
        public DbSet<DepoStok> DepoStok { get; set; }
        public DbSet<Envanter> Envanter { get; set; }
        public DbSet<Kategori> Kategori { get; set; }
        public DbSet<Marka> Marka { get; set; }
        public DbSet<SatisBirimi> SatisBirimi { get; set; }
        public DbSet<SatisFiyati> SatisFiyati { get; set; }
        public DbSet<UrunEnvanter> UrunEnvanter { get; set; }
        public DbSet<Urun> Urun { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.ApplyConfiguration(new OrganizasyonSemasiMap());


            
            modelBuilder.Entity<SatisBirimi>().HasData(
               new SatisBirimi() { Id = 1, SatisBirimiAdi = "Adet", Miktar = 1, KayitTarih = DateTime.Now },
               new SatisBirimi() { Id = 2, SatisBirimiAdi = "Koli 24", Miktar = 24, KayitTarih = DateTime.Now },
               new SatisBirimi() { Id = 3, SatisBirimiAdi = "Koli 50", Miktar = 50, KayitTarih = DateTime.Now },
               new SatisBirimi() { Id = 4, SatisBirimiAdi = "Deste", Miktar = 10, KayitTarih = DateTime.Now },
               new SatisBirimi() { Id = 5, SatisBirimiAdi = "Düzine", Miktar = 12, KayitTarih = DateTime.Now },
               new SatisBirimi() { Id = 6, SatisBirimiAdi = "Koli 10", Miktar = 10, KayitTarih = DateTime.Now }
               );

            

            modelBuilder.Entity<Depo>().HasData(
                new Depo() { Id = 1, Ad = "İzmir Depo", KayitTarih = DateTime.Now },
                new Depo() { Id = 2, Ad = "İstanbul Depo", KayitTarih = DateTime.Now },
                new Depo() { Id = 3, Ad = "Bursa Depo", KayitTarih = DateTime.Now },
                new Depo() { Id = 4, Ad = "Ankara Depo", KayitTarih = DateTime.Now },
                new Depo() { Id = 5, Ad = "Balıkesir Depo", KayitTarih = DateTime.Now }
                );


            modelBuilder.Entity<DepoStok>().HasData(
                new DepoStok() { Id = 1, DepoId = 1, EnvanterId = 1, StokAdedi = 180, KayitTarih = DateTime.Now },
                new DepoStok() { Id = 2, DepoId = 4, EnvanterId = 1, StokAdedi = 200, KayitTarih = DateTime.Now },
                new DepoStok() { Id = 3, DepoId = 1, EnvanterId = 2, StokAdedi = 350, KayitTarih = DateTime.Now },
                new DepoStok() { Id = 4, DepoId = 2, EnvanterId = 2, StokAdedi = 25, KayitTarih = DateTime.Now },
                new DepoStok() { Id = 5, DepoId = 4, EnvanterId = 2, StokAdedi = 48, KayitTarih = DateTime.Now },
                new DepoStok() { Id = 6, DepoId = 5, EnvanterId = 2, StokAdedi = 96, KayitTarih = DateTime.Now },
                new DepoStok() { Id = 7, DepoId = 1, EnvanterId = 3, StokAdedi = 50, KayitTarih = DateTime.Now },
                new DepoStok() { Id = 8, DepoId = 4, EnvanterId = 5, StokAdedi = 400, KayitTarih = DateTime.Now },
                new DepoStok() { Id = 9, DepoId = 2, EnvanterId = 5, StokAdedi = 83, KayitTarih = DateTime.Now },
                new DepoStok() { Id = 10, DepoId = 3, EnvanterId = 6, StokAdedi = 60, KayitTarih = DateTime.Now }
                );

            modelBuilder.Entity<Marka>().HasData(
                new Marka() { Id = 1, Ad = "Lenovo", KayitTarih = DateTime.Now },
                new Marka() { Id = 2, Ad = "Hp", KayitTarih = DateTime.Now },
                new Marka() { Id = 3, Ad = "Huawei", KayitTarih = DateTime.Now },
                new Marka() { Id = 4, Ad = "Monster", KayitTarih = DateTime.Now },
                new Marka() { Id = 5, Ad = "Asus", KayitTarih = DateTime.Now },
                new Marka() { Id = 6, Ad = "MSI", KayitTarih = DateTime.Now },
                new Marka() { Id = 7, Ad = "Casper", KayitTarih = DateTime.Now },
                new Marka() { Id = 8, Ad = "Acer", KayitTarih = DateTime.Now },
                new Marka() { Id = 9, Ad = "Classone", KayitTarih = DateTime.Now },
                new Marka() { Id = 10, Ad = "TX", KayitTarih = DateTime.Now }

                );

            modelBuilder.Entity<Envanter>().HasData(
                new Envanter() { Id = 1, SKU = "82V700A8TX", EnvanterAdi = "Lenovo IdeaPad 1 Intel Celeron N4020 4GB 128GB SSD Freedos 15.6 \" Taşınabilir Bilgisayar", SatisBirimiId = 1, KayitTarih = DateTime.Now },
                new Envanter() { Id = 2, SKU = "7Z588EA", EnvanterAdi = "Hp Victus 16-S0022NT Amd R7 7840HS 16GB 512GB SSD RTX4050-6GB Freedos 16.1\" 144 Hz Taşınabilir Bilgisayar", SatisBirimiId = 1, KayitTarih = DateTime.Now },
                new Envanter() { Id = 3, SKU = "73V700A8TX", EnvanterAdi = "Huawei MateBook D15 Intel Core i7 1195G7 16GB 512GB SSD Windows 11 Home 15.6\" FHD Taşınabilir Bilgisayar", SatisBirimiId = 1, KayitTarih = DateTime.Now },
                new Envanter() { Id = 4, SKU = "E65H.114F-BVH0X-0FC", EnvanterAdi = "Casper Excalibur Intel Core i5 11400F 16GB 500GB SSD GTX1650 Freedos Masaüstü Bilgisayar", SatisBirimiId = 1, KayitTarih = DateTime.Now },
                new Envanter() { Id = 5, SKU = "PR-R174", EnvanterAdi = "Roma Serisi Su Geçirmez Kumaş 17\" Laptop ,notebook Sırt Çantası-Gri", SatisBirimiId = 6, KayitTarih = DateTime.Now },
                new Envanter() { Id = 6, SKU = "TX-AC-U01", EnvanterAdi = "TX Type-C - USB 3.0 OTG USB Flash Dönüştürücü", SatisBirimiId = 2, KayitTarih = DateTime.Now }
                );



            modelBuilder.Entity<UrunEnvanter>().HasData(
                new UrunEnvanter() { Id = 1, UrunId = 3, Ad = "Lenovo IdeaPad 1 Intel Celeron N4020 4GB 128GB SSD Freedos 15.6 \"", MarkaId = 1, EnvanterId = 1, KategoriId = 19, Adet = 1, KayitTarih = DateTime.Now },
                new UrunEnvanter() { Id = 2, UrunId = 1, Ad = "Lenovo IdeaPad 1 Intel Celeron N4020 4GB 128GB SSD Freedos 15.6 \"", MarkaId = 1, EnvanterId = 1, KategoriId = 19, Adet = 1, KayitTarih = DateTime.Now },
                new UrunEnvanter() { Id = 3, UrunId = 1, Ad = "TX Type-C - USB 3.0 OTG USB Flash Dönüştürücü", MarkaId = 10, EnvanterId = 6, KategoriId = 27, Adet = 1, KayitTarih = DateTime.Now },
                new UrunEnvanter() { Id = 4, UrunId = 1, Ad = "Roma Serisi Su Geçirmez Kumaş 17\" Laptop ,notebook Sırt Çantası-Gri", MarkaId = 9, EnvanterId = 5, KategoriId = 26, Adet = 2, KayitTarih = DateTime.Now },
                new UrunEnvanter() { Id = 5, UrunId = 4, Ad = "TX Type-C - USB 3.0 OTG USB Flash Dönüştürücü", MarkaId = 10, EnvanterId = 6, KategoriId = 27, Adet = 1, KayitTarih = DateTime.Now },
                new UrunEnvanter() { Id = 6, UrunId = 5, Ad = "Casper Excalibur Intel Core i5 11400F 16GB 500GB SSD GTX1650 Freedos", MarkaId = 7, EnvanterId = 4, KategoriId = 23, Adet = 1, KayitTarih = DateTime.Now },
                new UrunEnvanter() { Id = 7, UrunId = 6, Ad = "Huawei MateBook D15 Intel Core i7 1195G7 16GB 512GB SSD Windows 11 Home 15.6\"", MarkaId = 3, EnvanterId = 3, KategoriId = 19, Adet = 1, KayitTarih = DateTime.Now },
                new UrunEnvanter() { Id = 8, UrunId = 2, Ad = "Hp Victus 16-S0022NT Amd R7 7840HS 16GB 512GB SSD RTX4050-6GB Freedos 16.1\" 144 Hz", MarkaId = 2, EnvanterId = 1, KategoriId = 19, Adet = 2, KayitTarih = DateTime.Now },
                new UrunEnvanter() { Id = 9, UrunId = 2, Ad = "TX Type-C - USB 3.0 OTG USB Flash Dönüştürücü", MarkaId = 10, EnvanterId = 6, KategoriId = 27, Adet = 1, KayitTarih = DateTime.Now },
                new UrunEnvanter() { Id = 10, UrunId = 7, Ad = "Hp Victus 16-S0022NT Amd R7 7840HS 16GB 512GB SSD RTX4050-6GB Freedos 16.1\" 144 Hz", MarkaId = 2, EnvanterId = 2, KategoriId = 19, Adet = 1, KayitTarih = DateTime.Now },
                new UrunEnvanter() { Id = 11, UrunId = 8, Ad = "Roma Serisi Su Geçirmez Kumaş 17\" Laptop ,notebook Sırt Çantası-Gri", MarkaId = 9, EnvanterId = 5, KategoriId = 26, Adet = 1, KayitTarih = DateTime.Now }
                );

            modelBuilder.Entity<Urun>().HasData(
                new Urun() { Id = 1, UrunAdi = "Lenovo laptop + TX Type-C - USB 3.0 OTG USB Flash Dönüştürücü + Sırt Çantası", KayitTarih = DateTime.Now },
                new Urun() { Id = 2, UrunAdi = "Hp Victus Bilgisayar + TX Type-C - USB 3.0 OTG USB Flash Dönüştürücü", KayitTarih = DateTime.Now },
                new Urun() { Id = 3, UrunAdi = "Lenovo IdeaPad 1 Intel Celeron N4020 4GB 128GB SSD Freedos 15.6 \"", KayitTarih = DateTime.Now },
                new Urun() { Id = 4, UrunAdi = "TX Type-C - USB 3.0 OTG USB Flash Dönüştürücü", KayitTarih = DateTime.Now },
                new Urun() { Id = 5, UrunAdi = "Casper Excalibur Intel Core i5 11400F 16GB 500GB SSD GTX1650 Freedos", KayitTarih = DateTime.Now },
                new Urun() { Id = 6, UrunAdi = "Huawei MateBook D15 Intel Core i7 1195G7 16GB 512GB SSD Windows 11 Home 15.6\"", KayitTarih = DateTime.Now },
                new Urun() { Id = 7, UrunAdi = "Hp Victus 16-S0022NT Amd R7 7840HS 16GB 512GB SSD RTX4050-6GB Freedos 16.1\" 144 Hz", KayitTarih = DateTime.Now },
                new Urun() { Id = 8, UrunAdi = "Roma Serisi Su Geçirmez Kumaş 17\" Laptop ,notebook Sırt Çantası-Gri", KayitTarih = DateTime.Now }
                );

            modelBuilder.Entity<SatisFiyati>().HasData(
                new SatisFiyati() { Id = 1, UrunId = 3, Fiyat = 12999.99m, SatisBirimiId = 1, KayitTarih = DateTime.Now },
                new SatisFiyati() { Id = 2, UrunId = 4, Fiyat = 600.99m, SatisBirimiId = 6, KayitTarih = DateTime.Now },
                new SatisFiyati() { Id = 3, UrunId = 5, Fiyat = 17599.99m, SatisBirimiId = 1, KayitTarih = DateTime.Now },
                new SatisFiyati() { Id = 4, UrunId = 6, Fiyat = 16000m, SatisBirimiId = 1, KayitTarih = DateTime.Now },
                new SatisFiyati() { Id = 5, UrunId = 7, Fiyat = 22999.99m, SatisBirimiId = 1, KayitTarih = DateTime.Now },
                new SatisFiyati() { Id = 6, UrunId = 8, Fiyat = 299.99m, SatisBirimiId = 1, KayitTarih = DateTime.Now },
                new SatisFiyati() { Id = 7, UrunId = 1, Fiyat = 13500m, SatisBirimiId = 1, KayitTarih = DateTime.Now },
                new SatisFiyati() { Id = 8, UrunId = 2 ,Fiyat = 23500m, SatisBirimiId = 1, KayitTarih = DateTime.Now },
                new SatisFiyati() { Id = 10, UrunId = 4, Fiyat = 70.99m, SatisBirimiId = 1, KayitTarih = DateTime.Now }
                );

            modelBuilder.Entity<Kategori>().HasData(
                new Kategori() { Id = 1, Ad = "Elektronik", ParentId = 0, KayitTarih = DateTime.Now},

                new Kategori() { Id = 2, Ad = "Bilgisayar/Tablet", ParentId = 1, KayitTarih = DateTime.Now },
                new Kategori() { Id = 3, Ad = "Yazıcılar & Projecksiyon", ParentId = 1, KayitTarih = DateTime.Now },
                new Kategori() { Id = 4, Ad = "TV, Görüntü & Ses Sistemleri", ParentId = 1, KayitTarih = DateTime.Now },
                new Kategori() { Id = 5, Ad = "Beyaz Eşya", ParentId = 1, KayitTarih = DateTime.Now },
                new Kategori() { Id = 6, Ad = "Klima ve Isıtıcılar", ParentId = 1, KayitTarih = DateTime.Now },
                new Kategori() { Id = 7, Ad = "Elektrikli Ev Aletleri", ParentId = 1, KayitTarih = DateTime.Now },
                new Kategori() { Id = 8, Ad = "Foto & Kamera", ParentId = 1, KayitTarih = DateTime.Now },
                new Kategori() { Id = 9, Ad = "Oyun & Oyun Konsolları", ParentId = 1, KayitTarih = DateTime.Now },

                new Kategori() { Id = 10, Ad = "Dizüstü Bilgisayar", ParentId = 2, KayitTarih = DateTime.Now },
                new Kategori() { Id = 11, Ad = "Tablet", ParentId = 2, KayitTarih = DateTime.Now },
                new Kategori() { Id = 12, Ad = "Masaüstü Bilgisayar", ParentId = 2, KayitTarih = DateTime.Now },

                new Kategori() { Id = 13, Ad = "Yazıcılar", ParentId = 3, KayitTarih = DateTime.Now },
                new Kategori() { Id = 14, Ad = "Projecksiyon Cihazı", ParentId = 3, KayitTarih = DateTime.Now },
                new Kategori() { Id = 15, Ad = "Sarf Malzemeleri", ParentId = 3, KayitTarih = DateTime.Now },

                new Kategori() { Id = 16, Ad = "Televizyon", ParentId = 4, KayitTarih = DateTime.Now },
                new Kategori() { Id = 17, Ad = "Ev Sinama Sistemleri", ParentId = 4, KayitTarih = DateTime.Now },
                new Kategori() { Id = 18, Ad = "Uydu Alıcıları", ParentId = 4, KayitTarih = DateTime.Now },

                new Kategori() { Id = 19, Ad = "Notebook", ParentId = 10, KayitTarih = DateTime.Now },
                new Kategori() { Id = 20, Ad = "Oyun Bilgisayarları", ParentId = 10, KayitTarih = DateTime.Now },
                new Kategori() { Id = 21, Ad = "İkisi Bir Arada", ParentId = 10, KayitTarih = DateTime.Now },

                new Kategori() { Id = 22, Ad = "All in One", ParentId = 12, KayitTarih = DateTime.Now },
                new Kategori() { Id = 23, Ad = "Masaüstü", ParentId = 12, KayitTarih = DateTime.Now },
                new Kategori() { Id = 24, Ad = "Mini Masaüstü", ParentId = 12, KayitTarih = DateTime.Now },

                new Kategori() { Id = 25, Ad = "Aksesuarlar", ParentId = 2, KayitTarih = DateTime.Now },

                new Kategori() { Id = 26, Ad = "Notebook Çantası", ParentId = 25, KayitTarih = DateTime.Now },
                new Kategori() { Id = 27, Ad = "Kablolar Çoklayıcılar", ParentId = 25, KayitTarih = DateTime.Now }
                );

        }




    }
}
