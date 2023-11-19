using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AkilliTicaretWebApi.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Depo",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KayitTarih = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GuncellemeTarih = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SilinmeTarih = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Depo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DepoStok",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DepoId = table.Column<long>(type: "bigint", nullable: false),
                    EnvanterId = table.Column<long>(type: "bigint", nullable: false),
                    StokAdedi = table.Column<int>(type: "int", nullable: false),
                    KayitTarih = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GuncellemeTarih = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SilinmeTarih = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DepoStok", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Envanter",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SKU = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EnvanterAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SatisBirimiId = table.Column<long>(type: "bigint", nullable: false),
                    KayitTarih = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GuncellemeTarih = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SilinmeTarih = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Envanter", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Kategori",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ParentId = table.Column<long>(type: "bigint", nullable: false),
                    KayitTarih = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GuncellemeTarih = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SilinmeTarih = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kategori", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Marka",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KayitTarih = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GuncellemeTarih = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SilinmeTarih = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Marka", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SatisBirimi",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SatisBirimiAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Miktar = table.Column<int>(type: "int", nullable: false),
                    KayitTarih = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GuncellemeTarih = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SilinmeTarih = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SatisBirimi", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SatisFiyati",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Fiyat = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    UrunId = table.Column<long>(type: "bigint", nullable: false),
                    SatisBirimiId = table.Column<long>(type: "bigint", nullable: false),
                    KayitTarih = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GuncellemeTarih = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SilinmeTarih = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SatisFiyati", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Urun",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UrunAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KayitTarih = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GuncellemeTarih = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SilinmeTarih = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Urun", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UrunEnvanter",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UrunId = table.Column<long>(type: "bigint", nullable: false),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MarkaId = table.Column<long>(type: "bigint", nullable: false),
                    KategoriId = table.Column<long>(type: "bigint", nullable: false),
                    EnvanterId = table.Column<long>(type: "bigint", nullable: false),
                    Adet = table.Column<int>(type: "int", nullable: false),
                    KayitTarih = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GuncellemeTarih = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SilinmeTarih = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UrunEnvanter", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Depo",
                columns: new[] { "Id", "Ad", "GuncellemeTarih", "KayitTarih", "SilinmeTarih" },
                values: new object[,]
                {
                    { 1L, "İzmir Depo", null, new DateTime(2023, 11, 19, 22, 50, 35, 699, DateTimeKind.Local).AddTicks(5673), null },
                    { 2L, "İstanbul Depo", null, new DateTime(2023, 11, 19, 22, 50, 35, 699, DateTimeKind.Local).AddTicks(5674), null },
                    { 3L, "Bursa Depo", null, new DateTime(2023, 11, 19, 22, 50, 35, 699, DateTimeKind.Local).AddTicks(5675), null },
                    { 4L, "Ankara Depo", null, new DateTime(2023, 11, 19, 22, 50, 35, 699, DateTimeKind.Local).AddTicks(5676), null },
                    { 5L, "Balıkesir Depo", null, new DateTime(2023, 11, 19, 22, 50, 35, 699, DateTimeKind.Local).AddTicks(5677), null }
                });

            migrationBuilder.InsertData(
                table: "DepoStok",
                columns: new[] { "Id", "DepoId", "EnvanterId", "GuncellemeTarih", "KayitTarih", "SilinmeTarih", "StokAdedi" },
                values: new object[,]
                {
                    { 1L, 1L, 1L, null, new DateTime(2023, 11, 19, 22, 50, 35, 699, DateTimeKind.Local).AddTicks(5705), null, 180 },
                    { 2L, 4L, 1L, null, new DateTime(2023, 11, 19, 22, 50, 35, 699, DateTimeKind.Local).AddTicks(5706), null, 200 },
                    { 3L, 1L, 2L, null, new DateTime(2023, 11, 19, 22, 50, 35, 699, DateTimeKind.Local).AddTicks(5746), null, 350 },
                    { 4L, 2L, 2L, null, new DateTime(2023, 11, 19, 22, 50, 35, 699, DateTimeKind.Local).AddTicks(5747), null, 25 },
                    { 5L, 4L, 2L, null, new DateTime(2023, 11, 19, 22, 50, 35, 699, DateTimeKind.Local).AddTicks(5748), null, 48 },
                    { 6L, 5L, 2L, null, new DateTime(2023, 11, 19, 22, 50, 35, 699, DateTimeKind.Local).AddTicks(5749), null, 96 },
                    { 7L, 1L, 3L, null, new DateTime(2023, 11, 19, 22, 50, 35, 699, DateTimeKind.Local).AddTicks(5750), null, 50 },
                    { 8L, 4L, 5L, null, new DateTime(2023, 11, 19, 22, 50, 35, 699, DateTimeKind.Local).AddTicks(5751), null, 400 },
                    { 9L, 2L, 5L, null, new DateTime(2023, 11, 19, 22, 50, 35, 699, DateTimeKind.Local).AddTicks(5752), null, 83 },
                    { 10L, 3L, 6L, null, new DateTime(2023, 11, 19, 22, 50, 35, 699, DateTimeKind.Local).AddTicks(5753), null, 60 }
                });

            migrationBuilder.InsertData(
                table: "Envanter",
                columns: new[] { "Id", "EnvanterAdi", "GuncellemeTarih", "KayitTarih", "SKU", "SatisBirimiId", "SilinmeTarih" },
                values: new object[,]
                {
                    { 1L, "Lenovo IdeaPad 1 Intel Celeron N4020 4GB 128GB SSD Freedos 15.6 \" Taşınabilir Bilgisayar", null, new DateTime(2023, 11, 19, 22, 50, 35, 699, DateTimeKind.Local).AddTicks(5807), "82V700A8TX", 1L, null },
                    { 2L, "Hp Victus 16-S0022NT Amd R7 7840HS 16GB 512GB SSD RTX4050-6GB Freedos 16.1\" 144 Hz Taşınabilir Bilgisayar", null, new DateTime(2023, 11, 19, 22, 50, 35, 699, DateTimeKind.Local).AddTicks(5809), "7Z588EA", 1L, null },
                    { 3L, "Huawei MateBook D15 Intel Core i7 1195G7 16GB 512GB SSD Windows 11 Home 15.6\" FHD Taşınabilir Bilgisayar", null, new DateTime(2023, 11, 19, 22, 50, 35, 699, DateTimeKind.Local).AddTicks(5811), "73V700A8TX", 1L, null },
                    { 4L, "Casper Excalibur Intel Core i5 11400F 16GB 500GB SSD GTX1650 Freedos Masaüstü Bilgisayar", null, new DateTime(2023, 11, 19, 22, 50, 35, 699, DateTimeKind.Local).AddTicks(5812), "E65H.114F-BVH0X-0FC", 1L, null },
                    { 5L, "Roma Serisi Su Geçirmez Kumaş 17\" Laptop ,notebook Sırt Çantası-Gri", null, new DateTime(2023, 11, 19, 22, 50, 35, 699, DateTimeKind.Local).AddTicks(5813), "PR-R174", 6L, null },
                    { 6L, "TX Type-C - USB 3.0 OTG USB Flash Dönüştürücü", null, new DateTime(2023, 11, 19, 22, 50, 35, 699, DateTimeKind.Local).AddTicks(5814), "TX-AC-U01", 2L, null }
                });

            migrationBuilder.InsertData(
                table: "Kategori",
                columns: new[] { "Id", "Ad", "GuncellemeTarih", "KayitTarih", "ParentId", "SilinmeTarih" },
                values: new object[,]
                {
                    { 1L, "Elektronik", null, new DateTime(2023, 11, 19, 22, 50, 35, 699, DateTimeKind.Local).AddTicks(6105), 0L, null },
                    { 2L, "Bilgisayar/Tablet", null, new DateTime(2023, 11, 19, 22, 50, 35, 699, DateTimeKind.Local).AddTicks(6106), 1L, null },
                    { 3L, "Yazıcılar & Projecksiyon", null, new DateTime(2023, 11, 19, 22, 50, 35, 699, DateTimeKind.Local).AddTicks(6149), 1L, null },
                    { 4L, "TV, Görüntü & Ses Sistemleri", null, new DateTime(2023, 11, 19, 22, 50, 35, 699, DateTimeKind.Local).AddTicks(6150), 1L, null },
                    { 5L, "Beyaz Eşya", null, new DateTime(2023, 11, 19, 22, 50, 35, 699, DateTimeKind.Local).AddTicks(6151), 1L, null },
                    { 6L, "Klima ve Isıtıcılar", null, new DateTime(2023, 11, 19, 22, 50, 35, 699, DateTimeKind.Local).AddTicks(6152), 1L, null },
                    { 7L, "Elektrikli Ev Aletleri", null, new DateTime(2023, 11, 19, 22, 50, 35, 699, DateTimeKind.Local).AddTicks(6153), 1L, null },
                    { 8L, "Foto & Kamera", null, new DateTime(2023, 11, 19, 22, 50, 35, 699, DateTimeKind.Local).AddTicks(6154), 1L, null },
                    { 9L, "Oyun & Oyun Konsolları", null, new DateTime(2023, 11, 19, 22, 50, 35, 699, DateTimeKind.Local).AddTicks(6155), 1L, null },
                    { 10L, "Dizüstü Bilgisayar", null, new DateTime(2023, 11, 19, 22, 50, 35, 699, DateTimeKind.Local).AddTicks(6156), 2L, null },
                    { 11L, "Tablet", null, new DateTime(2023, 11, 19, 22, 50, 35, 699, DateTimeKind.Local).AddTicks(6157), 2L, null },
                    { 12L, "Masaüstü Bilgisayar", null, new DateTime(2023, 11, 19, 22, 50, 35, 699, DateTimeKind.Local).AddTicks(6158), 2L, null },
                    { 13L, "Yazıcılar", null, new DateTime(2023, 11, 19, 22, 50, 35, 699, DateTimeKind.Local).AddTicks(6159), 3L, null },
                    { 14L, "Projecksiyon Cihazı", null, new DateTime(2023, 11, 19, 22, 50, 35, 699, DateTimeKind.Local).AddTicks(6160), 3L, null },
                    { 15L, "Sarf Malzemeleri", null, new DateTime(2023, 11, 19, 22, 50, 35, 699, DateTimeKind.Local).AddTicks(6161), 3L, null },
                    { 16L, "Televizyon", null, new DateTime(2023, 11, 19, 22, 50, 35, 699, DateTimeKind.Local).AddTicks(6162), 4L, null },
                    { 17L, "Ev Sinama Sistemleri", null, new DateTime(2023, 11, 19, 22, 50, 35, 699, DateTimeKind.Local).AddTicks(6163), 4L, null },
                    { 18L, "Uydu Alıcıları", null, new DateTime(2023, 11, 19, 22, 50, 35, 699, DateTimeKind.Local).AddTicks(6164), 4L, null },
                    { 19L, "Notebook", null, new DateTime(2023, 11, 19, 22, 50, 35, 699, DateTimeKind.Local).AddTicks(6165), 10L, null },
                    { 20L, "Oyun Bilgisayarları", null, new DateTime(2023, 11, 19, 22, 50, 35, 699, DateTimeKind.Local).AddTicks(6166), 10L, null },
                    { 21L, "İkisi Bir Arada", null, new DateTime(2023, 11, 19, 22, 50, 35, 699, DateTimeKind.Local).AddTicks(6167), 10L, null }
                });

            migrationBuilder.InsertData(
                table: "Kategori",
                columns: new[] { "Id", "Ad", "GuncellemeTarih", "KayitTarih", "ParentId", "SilinmeTarih" },
                values: new object[,]
                {
                    { 22L, "All in One", null, new DateTime(2023, 11, 19, 22, 50, 35, 699, DateTimeKind.Local).AddTicks(6168), 12L, null },
                    { 23L, "Masaüstü", null, new DateTime(2023, 11, 19, 22, 50, 35, 699, DateTimeKind.Local).AddTicks(6169), 12L, null },
                    { 24L, "Mini Masaüstü", null, new DateTime(2023, 11, 19, 22, 50, 35, 699, DateTimeKind.Local).AddTicks(6170), 12L, null },
                    { 25L, "Aksesuarlar", null, new DateTime(2023, 11, 19, 22, 50, 35, 699, DateTimeKind.Local).AddTicks(6171), 2L, null },
                    { 26L, "Notebook Çantası", null, new DateTime(2023, 11, 19, 22, 50, 35, 699, DateTimeKind.Local).AddTicks(6172), 25L, null },
                    { 27L, "Kablolar Çoklayıcılar", null, new DateTime(2023, 11, 19, 22, 50, 35, 699, DateTimeKind.Local).AddTicks(6173), 25L, null }
                });

            migrationBuilder.InsertData(
                table: "Marka",
                columns: new[] { "Id", "Ad", "GuncellemeTarih", "KayitTarih", "SilinmeTarih" },
                values: new object[,]
                {
                    { 1L, "Lenovo", null, new DateTime(2023, 11, 19, 22, 50, 35, 699, DateTimeKind.Local).AddTicks(5775), null },
                    { 2L, "Hp", null, new DateTime(2023, 11, 19, 22, 50, 35, 699, DateTimeKind.Local).AddTicks(5776), null },
                    { 3L, "Huawei", null, new DateTime(2023, 11, 19, 22, 50, 35, 699, DateTimeKind.Local).AddTicks(5777), null },
                    { 4L, "Monster", null, new DateTime(2023, 11, 19, 22, 50, 35, 699, DateTimeKind.Local).AddTicks(5778), null },
                    { 5L, "Asus", null, new DateTime(2023, 11, 19, 22, 50, 35, 699, DateTimeKind.Local).AddTicks(5779), null },
                    { 6L, "MSI", null, new DateTime(2023, 11, 19, 22, 50, 35, 699, DateTimeKind.Local).AddTicks(5780), null },
                    { 7L, "Casper", null, new DateTime(2023, 11, 19, 22, 50, 35, 699, DateTimeKind.Local).AddTicks(5781), null },
                    { 8L, "Acer", null, new DateTime(2023, 11, 19, 22, 50, 35, 699, DateTimeKind.Local).AddTicks(5781), null },
                    { 9L, "Classone", null, new DateTime(2023, 11, 19, 22, 50, 35, 699, DateTimeKind.Local).AddTicks(5783), null },
                    { 10L, "TX", null, new DateTime(2023, 11, 19, 22, 50, 35, 699, DateTimeKind.Local).AddTicks(5784), null }
                });

            migrationBuilder.InsertData(
                table: "SatisBirimi",
                columns: new[] { "Id", "GuncellemeTarih", "KayitTarih", "Miktar", "SatisBirimiAdi", "SilinmeTarih" },
                values: new object[,]
                {
                    { 1L, null, new DateTime(2023, 11, 19, 22, 50, 35, 699, DateTimeKind.Local).AddTicks(5474), 1, "Adet", null },
                    { 2L, null, new DateTime(2023, 11, 19, 22, 50, 35, 699, DateTimeKind.Local).AddTicks(5491), 24, "Koli 24", null },
                    { 3L, null, new DateTime(2023, 11, 19, 22, 50, 35, 699, DateTimeKind.Local).AddTicks(5492), 50, "Koli 50", null },
                    { 4L, null, new DateTime(2023, 11, 19, 22, 50, 35, 699, DateTimeKind.Local).AddTicks(5493), 10, "Deste", null },
                    { 5L, null, new DateTime(2023, 11, 19, 22, 50, 35, 699, DateTimeKind.Local).AddTicks(5494), 12, "Düzine", null },
                    { 6L, null, new DateTime(2023, 11, 19, 22, 50, 35, 699, DateTimeKind.Local).AddTicks(5495), 10, "Koli 10", null }
                });

            migrationBuilder.InsertData(
                table: "SatisFiyati",
                columns: new[] { "Id", "Fiyat", "GuncellemeTarih", "KayitTarih", "SatisBirimiId", "SilinmeTarih", "UrunId" },
                values: new object[,]
                {
                    { 1L, 12999.99m, null, new DateTime(2023, 11, 19, 22, 50, 35, 699, DateTimeKind.Local).AddTicks(5918), 1L, null, 3L },
                    { 2L, 600.99m, null, new DateTime(2023, 11, 19, 22, 50, 35, 699, DateTimeKind.Local).AddTicks(5920), 6L, null, 4L },
                    { 3L, 17599.99m, null, new DateTime(2023, 11, 19, 22, 50, 35, 699, DateTimeKind.Local).AddTicks(5921), 1L, null, 5L },
                    { 4L, 16000m, null, new DateTime(2023, 11, 19, 22, 50, 35, 699, DateTimeKind.Local).AddTicks(6080), 1L, null, 6L },
                    { 5L, 22999.99m, null, new DateTime(2023, 11, 19, 22, 50, 35, 699, DateTimeKind.Local).AddTicks(6081), 1L, null, 7L },
                    { 6L, 299.99m, null, new DateTime(2023, 11, 19, 22, 50, 35, 699, DateTimeKind.Local).AddTicks(6082), 1L, null, 8L },
                    { 7L, 13500m, null, new DateTime(2023, 11, 19, 22, 50, 35, 699, DateTimeKind.Local).AddTicks(6083), 1L, null, 1L },
                    { 8L, 23500m, null, new DateTime(2023, 11, 19, 22, 50, 35, 699, DateTimeKind.Local).AddTicks(6084), 1L, null, 2L },
                    { 10L, 70.99m, null, new DateTime(2023, 11, 19, 22, 50, 35, 699, DateTimeKind.Local).AddTicks(6085), 1L, null, 4L }
                });

            migrationBuilder.InsertData(
                table: "Urun",
                columns: new[] { "Id", "GuncellemeTarih", "KayitTarih", "SilinmeTarih", "UrunAdi" },
                values: new object[,]
                {
                    { 1L, null, new DateTime(2023, 11, 19, 22, 50, 35, 699, DateTimeKind.Local).AddTicks(5873), null, "Lenovo laptop + TX Type-C - USB 3.0 OTG USB Flash Dönüştürücü + Sırt Çantası" },
                    { 2L, null, new DateTime(2023, 11, 19, 22, 50, 35, 699, DateTimeKind.Local).AddTicks(5882), null, "Hp Victus Bilgisayar + TX Type-C - USB 3.0 OTG USB Flash Dönüştürücü" },
                    { 3L, null, new DateTime(2023, 11, 19, 22, 50, 35, 699, DateTimeKind.Local).AddTicks(5889), null, "Lenovo IdeaPad 1 Intel Celeron N4020 4GB 128GB SSD Freedos 15.6 \"" },
                    { 4L, null, new DateTime(2023, 11, 19, 22, 50, 35, 699, DateTimeKind.Local).AddTicks(5890), null, "TX Type-C - USB 3.0 OTG USB Flash Dönüştürücü" },
                    { 5L, null, new DateTime(2023, 11, 19, 22, 50, 35, 699, DateTimeKind.Local).AddTicks(5891), null, "Casper Excalibur Intel Core i5 11400F 16GB 500GB SSD GTX1650 Freedos" },
                    { 6L, null, new DateTime(2023, 11, 19, 22, 50, 35, 699, DateTimeKind.Local).AddTicks(5892), null, "Huawei MateBook D15 Intel Core i7 1195G7 16GB 512GB SSD Windows 11 Home 15.6\"" },
                    { 7L, null, new DateTime(2023, 11, 19, 22, 50, 35, 699, DateTimeKind.Local).AddTicks(5893), null, "Hp Victus 16-S0022NT Amd R7 7840HS 16GB 512GB SSD RTX4050-6GB Freedos 16.1\" 144 Hz" },
                    { 8L, null, new DateTime(2023, 11, 19, 22, 50, 35, 699, DateTimeKind.Local).AddTicks(5894), null, "Roma Serisi Su Geçirmez Kumaş 17\" Laptop ,notebook Sırt Çantası-Gri" }
                });

            migrationBuilder.InsertData(
                table: "UrunEnvanter",
                columns: new[] { "Id", "Ad", "Adet", "EnvanterId", "GuncellemeTarih", "KategoriId", "KayitTarih", "MarkaId", "SilinmeTarih", "UrunId" },
                values: new object[,]
                {
                    { 1L, "Lenovo IdeaPad 1 Intel Celeron N4020 4GB 128GB SSD Freedos 15.6 \"", 1, 1L, null, 19L, new DateTime(2023, 11, 19, 22, 50, 35, 699, DateTimeKind.Local).AddTicks(5836), 1L, null, 3L },
                    { 2L, "Lenovo IdeaPad 1 Intel Celeron N4020 4GB 128GB SSD Freedos 15.6 \"", 1, 1L, null, 19L, new DateTime(2023, 11, 19, 22, 50, 35, 699, DateTimeKind.Local).AddTicks(5838), 1L, null, 1L },
                    { 3L, "TX Type-C - USB 3.0 OTG USB Flash Dönüştürücü", 1, 6L, null, 27L, new DateTime(2023, 11, 19, 22, 50, 35, 699, DateTimeKind.Local).AddTicks(5839), 10L, null, 1L }
                });

            migrationBuilder.InsertData(
                table: "UrunEnvanter",
                columns: new[] { "Id", "Ad", "Adet", "EnvanterId", "GuncellemeTarih", "KategoriId", "KayitTarih", "MarkaId", "SilinmeTarih", "UrunId" },
                values: new object[,]
                {
                    { 4L, "Roma Serisi Su Geçirmez Kumaş 17\" Laptop ,notebook Sırt Çantası-Gri", 2, 5L, null, 26L, new DateTime(2023, 11, 19, 22, 50, 35, 699, DateTimeKind.Local).AddTicks(5840), 9L, null, 1L },
                    { 5L, "TX Type-C - USB 3.0 OTG USB Flash Dönüştürücü", 1, 6L, null, 27L, new DateTime(2023, 11, 19, 22, 50, 35, 699, DateTimeKind.Local).AddTicks(5842), 10L, null, 4L },
                    { 6L, "Casper Excalibur Intel Core i5 11400F 16GB 500GB SSD GTX1650 Freedos", 1, 4L, null, 23L, new DateTime(2023, 11, 19, 22, 50, 35, 699, DateTimeKind.Local).AddTicks(5843), 7L, null, 5L },
                    { 7L, "Huawei MateBook D15 Intel Core i7 1195G7 16GB 512GB SSD Windows 11 Home 15.6\"", 1, 3L, null, 19L, new DateTime(2023, 11, 19, 22, 50, 35, 699, DateTimeKind.Local).AddTicks(5846), 3L, null, 6L },
                    { 8L, "Hp Victus 16-S0022NT Amd R7 7840HS 16GB 512GB SSD RTX4050-6GB Freedos 16.1\" 144 Hz", 2, 1L, null, 19L, new DateTime(2023, 11, 19, 22, 50, 35, 699, DateTimeKind.Local).AddTicks(5847), 2L, null, 2L },
                    { 9L, "TX Type-C - USB 3.0 OTG USB Flash Dönüştürücü", 1, 6L, null, 27L, new DateTime(2023, 11, 19, 22, 50, 35, 699, DateTimeKind.Local).AddTicks(5848), 10L, null, 2L },
                    { 10L, "Hp Victus 16-S0022NT Amd R7 7840HS 16GB 512GB SSD RTX4050-6GB Freedos 16.1\" 144 Hz", 1, 2L, null, 19L, new DateTime(2023, 11, 19, 22, 50, 35, 699, DateTimeKind.Local).AddTicks(5850), 2L, null, 7L },
                    { 11L, "Roma Serisi Su Geçirmez Kumaş 17\" Laptop ,notebook Sırt Çantası-Gri", 1, 5L, null, 26L, new DateTime(2023, 11, 19, 22, 50, 35, 699, DateTimeKind.Local).AddTicks(5851), 9L, null, 8L }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Depo");

            migrationBuilder.DropTable(
                name: "DepoStok");

            migrationBuilder.DropTable(
                name: "Envanter");

            migrationBuilder.DropTable(
                name: "Kategori");

            migrationBuilder.DropTable(
                name: "Marka");

            migrationBuilder.DropTable(
                name: "SatisBirimi");

            migrationBuilder.DropTable(
                name: "SatisFiyati");

            migrationBuilder.DropTable(
                name: "Urun");

            migrationBuilder.DropTable(
                name: "UrunEnvanter");
        }
    }
}
