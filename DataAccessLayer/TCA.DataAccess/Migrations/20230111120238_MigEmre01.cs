using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TCA.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class MigEmre01 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "HR_Birim",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BirimKodu = table.Column<int>(type: "int", nullable: true),
                    Tanim = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Durum = table.Column<int>(type: "int", nullable: false),
                    CreateDatetime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateUserID = table.Column<int>(type: "int", nullable: false),
                    APIStatus = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HR_Birim", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "HR_Bolum",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BolumKodu = table.Column<int>(type: "int", nullable: true),
                    Tanim = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Durum = table.Column<int>(type: "int", nullable: false),
                    CreateDatetime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateUserID = table.Column<int>(type: "int", nullable: false),
                    APIStatus = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HR_Bolum", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "HR_Gorev",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GorevKodu = table.Column<int>(type: "int", nullable: true),
                    Tanim = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Durum = table.Column<int>(type: "int", nullable: false),
                    CreateDatetime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateUserID = table.Column<int>(type: "int", nullable: false),
                    APIStatus = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HR_Gorev", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "HR_Grup",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GrupKodu = table.Column<int>(type: "int", nullable: true),
                    Tanim = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Durum = table.Column<int>(type: "int", nullable: false),
                    CreateDatetime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateUserID = table.Column<int>(type: "int", nullable: false),
                    APIStatus = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HR_Grup", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "HR_IK_Yetki",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Sicil = table.Column<int>(type: "int", nullable: false),
                    OrganizasyonAnahtari = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AdiSoyadi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Durum = table.Column<int>(type: "int", nullable: false),
                    CreateDatetime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateUserID = table.Column<int>(type: "int", nullable: false),
                    APIStatus = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HR_IK_Yetki", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "HR_IsAlani",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsAlaniKodu = table.Column<int>(type: "int", nullable: true),
                    Tanim = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Durum = table.Column<int>(type: "int", nullable: false),
                    CreateDatetime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateUserID = table.Column<int>(type: "int", nullable: false),
                    APIStatus = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HR_IsAlani", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "HR_Lokasyon",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LokasyonKodu = table.Column<int>(type: "int", nullable: true),
                    Tanim = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Durum = table.Column<int>(type: "int", nullable: false),
                    CreateDatetime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateUserID = table.Column<int>(type: "int", nullable: false),
                    APIStatus = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HR_Lokasyon", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "HR_MasrafYeri",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MasrafKodu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tanim = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Durum = table.Column<int>(type: "int", nullable: false),
                    CreateDatetime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateUserID = table.Column<int>(type: "int", nullable: false),
                    APIStatus = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HR_MasrafYeri", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "HR_MobilUsers",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Sicil = table.Column<int>(type: "int", nullable: true),
                    AdSoyad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CepTel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Durum = table.Column<int>(type: "int", nullable: false),
                    CreateDatetime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateUserID = table.Column<int>(type: "int", nullable: false),
                    APIStatus = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HR_MobilUsers", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "HR_Organizasyon",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrganizasyonKodu = table.Column<int>(type: "int", nullable: true),
                    Tanim = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Durum = table.Column<int>(type: "int", nullable: false),
                    CreateDatetime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateUserID = table.Column<int>(type: "int", nullable: false),
                    APIStatus = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HR_Organizasyon", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "HR_OrganizasyonAnahtar",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AnahtarKodu = table.Column<int>(type: "int", nullable: true),
                    Tanim = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IKSicil = table.Column<int>(type: "int", nullable: false),
                    AdSoyad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Durum = table.Column<int>(type: "int", nullable: false),
                    CreateDatetime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateUserID = table.Column<int>(type: "int", nullable: false),
                    APIStatus = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HR_OrganizasyonAnahtar", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "HR_Personel",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Sicil = table.Column<int>(type: "int", nullable: false),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Soyad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SirketKodu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SirketTanim = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MasrafKodu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MasrafTanim = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OrganizasyonKodu = table.Column<int>(type: "int", nullable: true),
                    OrganizasyonTanim = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OrganizasyonMasterKodu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GrupKodu = table.Column<int>(type: "int", nullable: true),
                    GrupTanim = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BolumKodu = table.Column<int>(type: "int", nullable: true),
                    BolumTanim = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BirimKodu = table.Column<int>(type: "int", nullable: true),
                    BirimTanim = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UnvanKodu = table.Column<int>(type: "int", nullable: true),
                    UnvanTanim = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GorevKodu = table.Column<int>(type: "int", nullable: true),
                    GorevTanim = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OrganizasyonAnahtarKodu = table.Column<int>(type: "int", nullable: true),
                    OrganizasyonAnahtarTanim = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OrganizasyonAnahtarIK = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Domain = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Mail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ZzMailBox = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OrganizasyonAmirSicil = table.Column<int>(type: "int", nullable: true),
                    Onayci1 = table.Column<int>(type: "int", nullable: true),
                    Onayci2 = table.Column<int>(type: "int", nullable: true),
                    Onayci3 = table.Column<int>(type: "int", nullable: true),
                    Onayci4 = table.Column<int>(type: "int", nullable: true),
                    Onayci5 = table.Column<int>(type: "int", nullable: true),
                    EkOnayci = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CepNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Dahili = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LokasyonKodu = table.Column<int>(type: "int", nullable: true),
                    LokasyonTanim = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SozlesmeKodu = table.Column<int>(type: "int", nullable: true),
                    SozlesmeTanim = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SirketGenelID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SirketGenelTanim = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TCKN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DogumTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Yaka = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsAlaniKodu = table.Column<int>(type: "int", nullable: true),
                    IsAlaniTanim = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PersonelAltAlan = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CalisanGrubu = table.Column<int>(type: "int", nullable: true),
                    CalisanAltGrup = table.Column<int>(type: "int", nullable: true),
                    KisiselMail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Baslangic = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Aciklama = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DurumPasif = table.Column<DateTime>(type: "datetime2", nullable: true),
                    hrsapmanuel = table.Column<int>(name: "hr_sap_manuel", type: "int", nullable: false),
                    DurumEba = table.Column<int>(type: "int", nullable: true),
                    Durum = table.Column<int>(type: "int", nullable: false),
                    CreateDatetime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateUserID = table.Column<int>(type: "int", nullable: false),
                    APIStatus = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HR_Personel", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "HR_Personel_Taseron",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Sicil = table.Column<int>(type: "int", nullable: false),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Soyad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SirketKodu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SirketTanim = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MasrafKodu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MasrafTanim = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OrganizasyonKodu = table.Column<int>(type: "int", nullable: true),
                    OrganizasyonTanim = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OrganizasyonMasterKodu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GrupKodu = table.Column<int>(type: "int", nullable: true),
                    GrupTanim = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BolumKodu = table.Column<int>(type: "int", nullable: true),
                    BolumTanim = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BirimKodu = table.Column<int>(type: "int", nullable: true),
                    BirimTanim = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UnvanKodu = table.Column<int>(type: "int", nullable: true),
                    UnvanTanim = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GorevKodu = table.Column<int>(type: "int", nullable: true),
                    GorevTanim = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OrganizasyonAnahtarKodu = table.Column<int>(type: "int", nullable: true),
                    OrganizasyonAnahtarTanim = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OrganizasyonAnahtarIK = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Domain = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Mail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ZzMailBox = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OrganizasyonAmirSicil = table.Column<int>(type: "int", nullable: true),
                    Onayci1 = table.Column<int>(type: "int", nullable: true),
                    Onayci2 = table.Column<int>(type: "int", nullable: true),
                    Onayci3 = table.Column<int>(type: "int", nullable: true),
                    Onayci4 = table.Column<int>(type: "int", nullable: true),
                    Onayci5 = table.Column<int>(type: "int", nullable: true),
                    EkOnayci = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CepNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Dahili = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LokasyonKodu = table.Column<int>(type: "int", nullable: true),
                    LokasyonTanim = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SozlesmeKodu = table.Column<int>(type: "int", nullable: true),
                    SozlesmeTanim = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SirketGenelID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SirketGenelTanim = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TCKN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DogumTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Yaka = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsAlaniKodu = table.Column<int>(type: "int", nullable: true),
                    IsAlaniTanim = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PersonelAltAlan = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CalisanGrubu = table.Column<int>(type: "int", nullable: true),
                    CalisanAltGrup = table.Column<int>(type: "int", nullable: true),
                    KisiselMail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Baslangic = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Aciklama = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DurumPasif = table.Column<DateTime>(type: "datetime2", nullable: true),
                    hrsapmanuel = table.Column<int>(name: "hr_sap_manuel", type: "int", nullable: false),
                    Durum = table.Column<int>(type: "int", nullable: false),
                    CreateDatetime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateUserID = table.Column<int>(type: "int", nullable: false),
                    APIStatus = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HR_Personel_Taseron", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "HR_Seviye",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OBJID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ORGTX = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UPOBJID = table.Column<string>(name: "UP_OBJID", type: "nvarchar(max)", nullable: false),
                    SEVIYE = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SEVIYENO = table.Column<string>(name: "SEVIYE_NO", type: "nvarchar(max)", nullable: false),
                    POZISYON = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UNVAN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ONAYCI = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MASRAFYERI = table.Column<string>(name: "MASRAF_YERI", type: "nvarchar(max)", nullable: false),
                    SIRKETKODU = table.Column<string>(name: "SIRKET_KODU", type: "nvarchar(max)", nullable: false),
                    HIZMETTURU = table.Column<int>(name: "HIZMET_TURU", type: "int", nullable: false),
                    ALTHIZMETTURU = table.Column<string>(name: "ALTHIZMET_TURU", type: "nvarchar(max)", nullable: false),
                    Durum = table.Column<int>(type: "int", nullable: false),
                    CreateDatetime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateUserID = table.Column<int>(type: "int", nullable: false),
                    APIStatus = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HR_Seviye", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "HR_Sirketler",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SirketKodu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tanim = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Durum = table.Column<int>(type: "int", nullable: false),
                    CreateDatetime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateUserID = table.Column<int>(type: "int", nullable: false),
                    APIStatus = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HR_Sirketler", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "HR_Sozlesme",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SozlesmeKodu = table.Column<int>(type: "int", nullable: true),
                    Tanim = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Durum = table.Column<int>(type: "int", nullable: false),
                    CreateDatetime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateUserID = table.Column<int>(type: "int", nullable: false),
                    APIStatus = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HR_Sozlesme", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "HR_Unvan",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UnvanKodu = table.Column<int>(type: "int", nullable: true),
                    Tanim = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Durum = table.Column<int>(type: "int", nullable: false),
                    CreateDatetime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateUserID = table.Column<int>(type: "int", nullable: false),
                    APIStatus = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HR_Unvan", x => x.ID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HR_Birim");

            migrationBuilder.DropTable(
                name: "HR_Bolum");

            migrationBuilder.DropTable(
                name: "HR_Gorev");

            migrationBuilder.DropTable(
                name: "HR_Grup");

            migrationBuilder.DropTable(
                name: "HR_IK_Yetki");

            migrationBuilder.DropTable(
                name: "HR_IsAlani");

            migrationBuilder.DropTable(
                name: "HR_Lokasyon");

            migrationBuilder.DropTable(
                name: "HR_MasrafYeri");

            migrationBuilder.DropTable(
                name: "HR_MobilUsers");

            migrationBuilder.DropTable(
                name: "HR_Organizasyon");

            migrationBuilder.DropTable(
                name: "HR_OrganizasyonAnahtar");

            migrationBuilder.DropTable(
                name: "HR_Personel");

            migrationBuilder.DropTable(
                name: "HR_Personel_Taseron");

            migrationBuilder.DropTable(
                name: "HR_Seviye");

            migrationBuilder.DropTable(
                name: "HR_Sirketler");

            migrationBuilder.DropTable(
                name: "HR_Sozlesme");

            migrationBuilder.DropTable(
                name: "HR_Unvan");
        }
    }
}
