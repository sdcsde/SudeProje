using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SudeProje.Migrations
{
    /// <inheritdoc />
    public partial class deneme : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Derss",
                columns: table => new
                {
                    DersID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DersAd = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DersDetay = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DersOgretmen = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Derss", x => x.DersID);
                });

            migrationBuilder.CreateTable(
                name: "Kullanicis",
                columns: table => new
                {
                    KullaniciID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nickname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sifre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KullaniciAd = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KullaniciSoyad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KayitTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DersID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kullanicis", x => x.KullaniciID);
                    table.ForeignKey(
                        name: "FK_Kullanicis_Derss_DersID",
                        column: x => x.DersID,
                        principalTable: "Derss",
                        principalColumn: "DersID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Uygulamalis",
                columns: table => new
                {
                    UygulamaliID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UygulamaliAd = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UygulamaliDetay = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UygulamaliOgretmen = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DersID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Uygulamalis", x => x.UygulamaliID);
                    table.ForeignKey(
                        name: "FK_Uygulamalis_Derss_DersID",
                        column: x => x.DersID,
                        principalTable: "Derss",
                        principalColumn: "DersID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Sertfikas",
                columns: table => new
                {
                    SertfikaID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SertfikaAd = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VerilisTarih = table.Column<DateTime>(type: "datetime2", nullable: false),
                    KullaniciID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sertfikas", x => x.SertfikaID);
                    table.ForeignKey(
                        name: "FK_Sertfikas_Kullanicis_KullaniciID",
                        column: x => x.KullaniciID,
                        principalTable: "Kullanicis",
                        principalColumn: "KullaniciID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Kullanicis_DersID",
                table: "Kullanicis",
                column: "DersID");

            migrationBuilder.CreateIndex(
                name: "IX_Sertfikas_KullaniciID",
                table: "Sertfikas",
                column: "KullaniciID");

            migrationBuilder.CreateIndex(
                name: "IX_Uygulamalis_DersID",
                table: "Uygulamalis",
                column: "DersID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Sertfikas");

            migrationBuilder.DropTable(
                name: "Uygulamalis");

            migrationBuilder.DropTable(
                name: "Kullanicis");

            migrationBuilder.DropTable(
                name: "Derss");
        }
    }
}
