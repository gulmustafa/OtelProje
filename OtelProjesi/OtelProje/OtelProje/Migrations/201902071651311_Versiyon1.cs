namespace OtelProje.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Versiyon1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Ilces",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        IlceAdi = c.String(),
                        OlusturanKisi = c.String(),
                        OlusturmaTarihi = c.DateTime(nullable: false),
                        GuncelleyenKisi = c.String(),
                        GuncellemeTarihi = c.DateTime(nullable: false),
                        Il_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Ils", t => t.Il_Id)
                .Index(t => t.Il_Id);
            
            CreateTable(
                "dbo.Mahalles",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Mahalleadi = c.String(),
                        OlusturanKisi = c.String(),
                        OlusturmaTarihi = c.DateTime(nullable: false),
                        GuncelleyenKisi = c.String(),
                        GuncellemeTarihi = c.DateTime(nullable: false),
                        Ilce_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Ilces", t => t.Ilce_Id)
                .Index(t => t.Ilce_Id);
            
            CreateTable(
                "dbo.Ils",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        IlAdi = c.String(),
                        OlusturanKisi = c.String(),
                        OlusturmaTarihi = c.DateTime(nullable: false),
                        GuncelleyenKisi = c.String(),
                        GuncellemeTarihi = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Musteris",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        MusteriAdi = c.String(),
                        MusteriSoyadi = c.String(),
                        Sifre = c.String(),
                        KullaniciAdi = c.String(),
                        MusteriTelefon = c.String(),
                        MusteriEmail = c.String(),
                        TcKimlik = c.Int(nullable: false),
                        OlusturanKisi = c.String(),
                        OlusturmaTarihi = c.DateTime(nullable: false),
                        GuncelleyenKisi = c.String(),
                        GuncellemeTarihi = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Odas",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        OdaTipi = c.Int(nullable: false),
                        Ucret = c.Double(nullable: false),
                        BosMu = c.Boolean(nullable: false),
                        OdaNo = c.String(),
                        OlusturanKisi = c.String(),
                        OlusturmaTarihi = c.DateTime(nullable: false),
                        GuncelleyenKisi = c.String(),
                        GuncellemeTarihi = c.DateTime(nullable: false),
                        Otel_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Otels", t => t.Otel_Id)
                .Index(t => t.Otel_Id);
            
            CreateTable(
                "dbo.Otels",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        OtelAdi = c.String(),
                        OtelAdresi = c.String(),
                        VergiNo = c.String(),
                        OtelResmiAdi = c.String(),
                        OlusturanKisi = c.String(),
                        OlusturmaTarihi = c.DateTime(nullable: false),
                        GuncelleyenKisi = c.String(),
                        GuncellemeTarihi = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Yildizs",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        BegenmeSayisi = c.Int(nullable: false),
                        BegenmemeSayisi = c.Int(nullable: false),
                        OlusturanKisi = c.String(),
                        OlusturmaTarihi = c.DateTime(nullable: false),
                        GuncelleyenKisi = c.String(),
                        GuncellemeTarihi = c.DateTime(nullable: false),
                        Otel_Id = c.String(maxLength: 128),
                        Yorum_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Otels", t => t.Otel_Id)
                .ForeignKey("dbo.Yorums", t => t.Yorum_Id)
                .Index(t => t.Otel_Id)
                .Index(t => t.Yorum_Id);
            
            CreateTable(
                "dbo.Yorums",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        YorumBasligi = c.String(),
                        YorumIcerigi = c.String(),
                        OlusturanKisi = c.String(),
                        OlusturmaTarihi = c.DateTime(nullable: false),
                        GuncelleyenKisi = c.String(),
                        GuncellemeTarihi = c.DateTime(nullable: false),
                        Musteri_Id = c.String(maxLength: 128),
                        Otel_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Musteris", t => t.Musteri_Id)
                .ForeignKey("dbo.Otels", t => t.Otel_Id)
                .Index(t => t.Musteri_Id)
                .Index(t => t.Otel_Id);
            
            CreateTable(
                "dbo.OtelOzelliks",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        OlusturanKisi = c.String(),
                        OlusturmaTarihi = c.DateTime(nullable: false),
                        GuncelleyenKisi = c.String(),
                        GuncellemeTarihi = c.DateTime(nullable: false),
                        Otel_Id = c.String(maxLength: 128),
                        Ozellik_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Otels", t => t.Otel_Id)
                .ForeignKey("dbo.Ozelliks", t => t.Ozellik_Id)
                .Index(t => t.Otel_Id)
                .Index(t => t.Ozellik_Id);
            
            CreateTable(
                "dbo.Ozelliks",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        OzellikAdi = c.String(),
                        OlusturanKisi = c.String(),
                        OlusturmaTarihi = c.DateTime(nullable: false),
                        GuncelleyenKisi = c.String(),
                        GuncellemeTarihi = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.OtelResimleris",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Resim = c.Binary(),
                        OlusturanKisi = c.String(),
                        OlusturmaTarihi = c.DateTime(nullable: false),
                        GuncelleyenKisi = c.String(),
                        GuncellemeTarihi = c.DateTime(nullable: false),
                        Otel_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Otels", t => t.Otel_Id)
                .Index(t => t.Otel_Id);
            
            CreateTable(
                "dbo.Rezervasyons",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        KisiSayisi = c.Int(nullable: false),
                        CheckInDate = c.DateTime(nullable: false),
                        CheckOutDate = c.DateTime(nullable: false),
                        OdemeZamani = c.Int(nullable: false),
                        OlusturanKisi = c.String(),
                        OlusturmaTarihi = c.DateTime(nullable: false),
                        GuncelleyenKisi = c.String(),
                        GuncellemeTarihi = c.DateTime(nullable: false),
                        Musteri_Id = c.String(maxLength: 128),
                        Oda_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Musteris", t => t.Musteri_Id)
                .ForeignKey("dbo.Odas", t => t.Oda_Id)
                .Index(t => t.Musteri_Id)
                .Index(t => t.Oda_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Rezervasyons", "Oda_Id", "dbo.Odas");
            DropForeignKey("dbo.Rezervasyons", "Musteri_Id", "dbo.Musteris");
            DropForeignKey("dbo.OtelResimleris", "Otel_Id", "dbo.Otels");
            DropForeignKey("dbo.OtelOzelliks", "Ozellik_Id", "dbo.Ozelliks");
            DropForeignKey("dbo.OtelOzelliks", "Otel_Id", "dbo.Otels");
            DropForeignKey("dbo.Odas", "Otel_Id", "dbo.Otels");
            DropForeignKey("dbo.Yorums", "Otel_Id", "dbo.Otels");
            DropForeignKey("dbo.Yildizs", "Yorum_Id", "dbo.Yorums");
            DropForeignKey("dbo.Yorums", "Musteri_Id", "dbo.Musteris");
            DropForeignKey("dbo.Yildizs", "Otel_Id", "dbo.Otels");
            DropForeignKey("dbo.Ilces", "Il_Id", "dbo.Ils");
            DropForeignKey("dbo.Mahalles", "Ilce_Id", "dbo.Ilces");
            DropIndex("dbo.Rezervasyons", new[] { "Oda_Id" });
            DropIndex("dbo.Rezervasyons", new[] { "Musteri_Id" });
            DropIndex("dbo.OtelResimleris", new[] { "Otel_Id" });
            DropIndex("dbo.OtelOzelliks", new[] { "Ozellik_Id" });
            DropIndex("dbo.OtelOzelliks", new[] { "Otel_Id" });
            DropIndex("dbo.Yorums", new[] { "Otel_Id" });
            DropIndex("dbo.Yorums", new[] { "Musteri_Id" });
            DropIndex("dbo.Yildizs", new[] { "Yorum_Id" });
            DropIndex("dbo.Yildizs", new[] { "Otel_Id" });
            DropIndex("dbo.Odas", new[] { "Otel_Id" });
            DropIndex("dbo.Mahalles", new[] { "Ilce_Id" });
            DropIndex("dbo.Ilces", new[] { "Il_Id" });
            DropTable("dbo.Rezervasyons");
            DropTable("dbo.OtelResimleris");
            DropTable("dbo.Ozelliks");
            DropTable("dbo.OtelOzelliks");
            DropTable("dbo.Yorums");
            DropTable("dbo.Yildizs");
            DropTable("dbo.Otels");
            DropTable("dbo.Odas");
            DropTable("dbo.Musteris");
            DropTable("dbo.Ils");
            DropTable("dbo.Mahalles");
            DropTable("dbo.Ilces");
        }
    }
}
