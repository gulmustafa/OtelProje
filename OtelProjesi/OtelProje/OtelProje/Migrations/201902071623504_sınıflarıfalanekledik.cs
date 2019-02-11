namespace OtelProje.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class sınıflarıfalanekledik : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Ilces",
                c => new
                    {
                        ID = c.String(nullable: false, maxLength: 128),
                        IlceAdi = c.String(),
                        OlusturmaTarihi = c.DateTime(nullable: false),
                        OlusturanKisi = c.String(),
                        GuncellemeTarihi = c.DateTime(nullable: false),
                        GuncelleyenKisi = c.String(),
                        Il_ID = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Ils", t => t.Il_ID)
                .Index(t => t.Il_ID);
            
            CreateTable(
                "dbo.Mahalles",
                c => new
                    {
                        ID = c.String(nullable: false, maxLength: 128),
                        MahalleAdi = c.String(),
                        OlusturmaTarihi = c.DateTime(nullable: false),
                        OlusturanKisi = c.String(),
                        GuncellemeTarihi = c.DateTime(nullable: false),
                        GuncelleyenKisi = c.String(),
                        Ilce_ID = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Ilces", t => t.Ilce_ID)
                .Index(t => t.Ilce_ID);
            
            CreateTable(
                "dbo.Ils",
                c => new
                    {
                        ID = c.String(nullable: false, maxLength: 128),
                        IlAdi = c.String(),
                        OlusturmaTarihi = c.DateTime(nullable: false),
                        OlusturanKisi = c.String(),
                        GuncellemeTarihi = c.DateTime(nullable: false),
                        GuncelleyenKisi = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Musteris",
                c => new
                    {
                        ID = c.String(nullable: false, maxLength: 128),
                        Adi = c.String(),
                        Soyadi = c.String(),
                        Sifre = c.String(),
                        KullaniciAdi = c.String(),
                        Telefon = c.String(),
                        Email = c.String(),
                        TcKimlik = c.String(),
                        OlusturmaTarihi = c.DateTime(nullable: false),
                        OlusturanKisi = c.String(),
                        GuncellemeTarihi = c.DateTime(nullable: false),
                        GuncelleyenKisi = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Odas",
                c => new
                    {
                        ID = c.String(nullable: false, maxLength: 128),
                        YorumIcerigi = c.String(),
                        OdaBosMu = c.Boolean(nullable: false),
                        OlusturmaTarihi = c.DateTime(nullable: false),
                        OlusturanKisi = c.String(),
                        GuncellemeTarihi = c.DateTime(nullable: false),
                        GuncelleyenKisi = c.String(),
                        otel_ID = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Otels", t => t.otel_ID)
                .Index(t => t.otel_ID);
            
            CreateTable(
                "dbo.Otels",
                c => new
                    {
                        ID = c.String(nullable: false, maxLength: 128),
                        Adi = c.String(),
                        AdresIl = c.String(),
                        Ilce = c.String(),
                        Mahalle = c.String(),
                        SirketAdi = c.String(),
                        Aciklama = c.String(),
                        YildizSayisi = c.Int(nullable: false),
                        OlusturmaTarihi = c.DateTime(nullable: false),
                        OlusturanKisi = c.String(),
                        GuncellemeTarihi = c.DateTime(nullable: false),
                        GuncelleyenKisi = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Yildizs",
                c => new
                    {
                        ID = c.String(nullable: false, maxLength: 128),
                        BegenmeSayisi = c.Int(nullable: false),
                        BegenmemeSayisi = c.Int(nullable: false),
                        OlusturmaTarihi = c.DateTime(nullable: false),
                        OlusturanKisi = c.String(),
                        GuncellemeTarihi = c.DateTime(nullable: false),
                        GuncelleyenKisi = c.String(),
                        Otel_ID = c.String(maxLength: 128),
                        Yorum_ID = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Otels", t => t.Otel_ID)
                .ForeignKey("dbo.Yorums", t => t.Yorum_ID)
                .Index(t => t.Otel_ID)
                .Index(t => t.Yorum_ID);
            
            CreateTable(
                "dbo.Yorums",
                c => new
                    {
                        ID = c.String(nullable: false, maxLength: 128),
                        YorumBasligi = c.String(),
                        YorumIcerigi = c.String(),
                        OlusturmaTarihi = c.DateTime(nullable: false),
                        OlusturanKisi = c.String(),
                        GuncellemeTarihi = c.DateTime(nullable: false),
                        GuncelleyenKisi = c.String(),
                        Musteri_ID = c.String(maxLength: 128),
                        Otel_ID = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Musteris", t => t.Musteri_ID)
                .ForeignKey("dbo.Otels", t => t.Otel_ID)
                .Index(t => t.Musteri_ID)
                .Index(t => t.Otel_ID);
            
            CreateTable(
                "dbo.OtelOzelligis",
                c => new
                    {
                        ID = c.String(nullable: false, maxLength: 128),
                        OlusturmaTarihi = c.DateTime(nullable: false),
                        OlusturanKisi = c.String(),
                        GuncellemeTarihi = c.DateTime(nullable: false),
                        GuncelleyenKisi = c.String(),
                        Otel_ID = c.String(maxLength: 128),
                        Ozellik_ID = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Otels", t => t.Otel_ID)
                .ForeignKey("dbo.Ozelliks", t => t.Ozellik_ID)
                .Index(t => t.Otel_ID)
                .Index(t => t.Ozellik_ID);
            
            CreateTable(
                "dbo.Ozelliks",
                c => new
                    {
                        ID = c.String(nullable: false, maxLength: 128),
                        OzellikAdi = c.String(),
                        OlusturmaTarihi = c.DateTime(nullable: false),
                        OlusturanKisi = c.String(),
                        GuncellemeTarihi = c.DateTime(nullable: false),
                        GuncelleyenKisi = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.OtelResimleris",
                c => new
                    {
                        ID = c.String(nullable: false, maxLength: 128),
                        Resim = c.Binary(),
                        OlusturmaTarihi = c.DateTime(nullable: false),
                        OlusturanKisi = c.String(),
                        GuncellemeTarihi = c.DateTime(nullable: false),
                        GuncelleyenKisi = c.String(),
                        Otel_ID = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Otels", t => t.Otel_ID)
                .Index(t => t.Otel_ID);
            
            CreateTable(
                "dbo.Rezervasyons",
                c => new
                    {
                        ID = c.String(nullable: false, maxLength: 128),
                        KisiSayisi = c.Int(nullable: false),
                        CheckInDate = c.DateTime(nullable: false),
                        CheckOutDate = c.DateTime(nullable: false),
                        OlusturmaTarihi = c.DateTime(nullable: false),
                        OlusturanKisi = c.String(),
                        GuncellemeTarihi = c.DateTime(nullable: false),
                        GuncelleyenKisi = c.String(),
                        Musteri_ID = c.String(maxLength: 128),
                        Oda_ID = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Musteris", t => t.Musteri_ID)
                .ForeignKey("dbo.Odas", t => t.Oda_ID)
                .Index(t => t.Musteri_ID)
                .Index(t => t.Oda_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Rezervasyons", "Oda_ID", "dbo.Odas");
            DropForeignKey("dbo.Rezervasyons", "Musteri_ID", "dbo.Musteris");
            DropForeignKey("dbo.OtelResimleris", "Otel_ID", "dbo.Otels");
            DropForeignKey("dbo.OtelOzelligis", "Ozellik_ID", "dbo.Ozelliks");
            DropForeignKey("dbo.OtelOzelligis", "Otel_ID", "dbo.Otels");
            DropForeignKey("dbo.Odas", "otel_ID", "dbo.Otels");
            DropForeignKey("dbo.Yorums", "Otel_ID", "dbo.Otels");
            DropForeignKey("dbo.Yildizs", "Yorum_ID", "dbo.Yorums");
            DropForeignKey("dbo.Yorums", "Musteri_ID", "dbo.Musteris");
            DropForeignKey("dbo.Yildizs", "Otel_ID", "dbo.Otels");
            DropForeignKey("dbo.Ilces", "Il_ID", "dbo.Ils");
            DropForeignKey("dbo.Mahalles", "Ilce_ID", "dbo.Ilces");
            DropIndex("dbo.Rezervasyons", new[] { "Oda_ID" });
            DropIndex("dbo.Rezervasyons", new[] { "Musteri_ID" });
            DropIndex("dbo.OtelResimleris", new[] { "Otel_ID" });
            DropIndex("dbo.OtelOzelligis", new[] { "Ozellik_ID" });
            DropIndex("dbo.OtelOzelligis", new[] { "Otel_ID" });
            DropIndex("dbo.Yorums", new[] { "Otel_ID" });
            DropIndex("dbo.Yorums", new[] { "Musteri_ID" });
            DropIndex("dbo.Yildizs", new[] { "Yorum_ID" });
            DropIndex("dbo.Yildizs", new[] { "Otel_ID" });
            DropIndex("dbo.Odas", new[] { "otel_ID" });
            DropIndex("dbo.Mahalles", new[] { "Ilce_ID" });
            DropIndex("dbo.Ilces", new[] { "Il_ID" });
            DropTable("dbo.Rezervasyons");
            DropTable("dbo.OtelResimleris");
            DropTable("dbo.Ozelliks");
            DropTable("dbo.OtelOzelligis");
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
