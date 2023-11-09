using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PlakDukkaniDAL.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Albumler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AlbumAdi = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    SanatciAdi = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CikisTarihi = table.Column<DateTime>(type: "date", nullable: false),
                    Fiyat = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IndirimOrani = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    SatisAktifMi = table.Column<bool>(type: "bit", nullable: false),
                    KayitTarihi = table.Column<DateTime>(type: "date", nullable: false),
                    GuncellemeTarihi = table.Column<DateTime>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Albumler", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Kullanicilar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KullaniciAdi = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Sifre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Unvan = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    KayitTarihi = table.Column<DateTime>(type: "date", nullable: false),
                    GuncellemeTarihi = table.Column<DateTime>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kullanicilar", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Albumler",
                columns: new[] { "Id", "AlbumAdi", "CikisTarihi", "Fiyat", "GuncellemeTarihi", "IndirimOrani", "KayitTarihi", "SanatciAdi", "SatisAktifMi" },
                values: new object[,]
                {
                    { 1, "Mançoloji", new DateTime(1997, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 250m, null, 20m, new DateTime(2023, 11, 9, 15, 17, 5, 433, DateTimeKind.Local).AddTicks(9416), "Barış Manço", true },
                    { 2, "Gülümse", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 230m, null, 0m, new DateTime(2023, 11, 9, 15, 17, 5, 433, DateTimeKind.Local).AddTicks(9432), "Sezen Aksu", false },
                    { 3, "Dil Yarası", new DateTime(1975, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 200m, null, 10m, new DateTime(2023, 11, 9, 15, 17, 5, 433, DateTimeKind.Local).AddTicks(9434), "Orhan Gencebay", false },
                    { 4, "Ölürüm Sana", new DateTime(1997, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 280m, null, 0m, new DateTime(2023, 11, 9, 15, 17, 5, 433, DateTimeKind.Local).AddTicks(9436), "Tarkan", true },
                    { 5, "O", new DateTime(1996, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 210m, null, 25m, new DateTime(2023, 11, 9, 15, 17, 5, 433, DateTimeKind.Local).AddTicks(9437), "Teoman", true },
                    { 6, "Ajda'97", new DateTime(1997, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 300m, null, 25m, new DateTime(2023, 11, 9, 15, 17, 5, 433, DateTimeKind.Local).AddTicks(9438), "Ajda Pekkan", false },
                    { 7, "Mavi Mavi", new DateTime(1983, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 300m, null, 0m, new DateTime(2023, 11, 9, 15, 17, 5, 433, DateTimeKind.Local).AddTicks(9439), "İbrahim Tatlıses", false },
                    { 8, "Gülümse (Yeşilçam Şarkıları)", new DateTime(1994, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 250m, null, 0m, new DateTime(2023, 11, 9, 15, 17, 5, 433, DateTimeKind.Local).AddTicks(9440), "Sezen Aksu", true },
                    { 9, "Kenan Doğulu 2", new DateTime(1994, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 250m, null, 10m, new DateTime(2023, 11, 9, 15, 17, 5, 433, DateTimeKind.Local).AddTicks(9442), "Kenan Doğulu", false },
                    { 10, "Sakla Samanı Gelir Zamanı", new DateTime(1979, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 210m, null, 10m, new DateTime(2023, 11, 9, 15, 17, 5, 433, DateTimeKind.Local).AddTicks(9443), "Barış Manço", false }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Kullanicilar_KullaniciAdi",
                table: "Kullanicilar",
                column: "KullaniciAdi",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Albumler");

            migrationBuilder.DropTable(
                name: "Kullanicilar");
        }
    }
}
