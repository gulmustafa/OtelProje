namespace OtelProje.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class güncelleme3 : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Ilces", newName: "Ilceler");
            RenameTable(name: "dbo.Mahalles", newName: "Mahalleler");
            RenameTable(name: "dbo.Ils", newName: "Iller");
            RenameTable(name: "dbo.Musteris", newName: "Musteriler");
            RenameTable(name: "dbo.Odas", newName: "Odalar");
            RenameTable(name: "dbo.Otels", newName: "Oteller");
            RenameTable(name: "dbo.Yildizs", newName: "Yildizlar");
            RenameTable(name: "dbo.Yorums", newName: "Yorumlar");
            RenameTable(name: "dbo.OtelOzelligis", newName: "OtelOzellikleri");
            RenameTable(name: "dbo.Ozelliks", newName: "Ozellikler");
            RenameTable(name: "dbo.OtelResimleris", newName: "OtelResimleri");
            RenameTable(name: "dbo.Rezervasyons", newName: "Rezervasyonlar");
            AddColumn("dbo.Odalar", "YorumIcerigi_ID", c => c.String(maxLength: 128));
            AddColumn("dbo.Oteller", "AdresIl_ID", c => c.String(maxLength: 128));
            AddColumn("dbo.Oteller", "Ilce_ID", c => c.String(maxLength: 128));
            AddColumn("dbo.Oteller", "Mahalle_ID", c => c.String(maxLength: 128));
            AlterColumn("dbo.Ilceler", "IlceAdi", c => c.String(maxLength: 50));
            AlterColumn("dbo.Mahalleler", "MahalleAdi", c => c.String(maxLength: 50));
            AlterColumn("dbo.Iller", "IlAdi", c => c.String(maxLength: 50));
            AlterColumn("dbo.Musteriler", "Adi", c => c.String(maxLength: 50));
            AlterColumn("dbo.Musteriler", "Soyadi", c => c.String(maxLength: 50));
            AlterColumn("dbo.Musteriler", "Sifre", c => c.String(maxLength: 50));
            AlterColumn("dbo.Musteriler", "KullaniciAdi", c => c.String(maxLength: 50));
            AlterColumn("dbo.Musteriler", "Telefon", c => c.String(maxLength: 20));
            AlterColumn("dbo.Musteriler", "Email", c => c.String(maxLength: 50));
            AlterColumn("dbo.Musteriler", "TcKimlik", c => c.String(maxLength: 11));
            AlterColumn("dbo.Oteller", "Adi", c => c.String(maxLength: 50));
            AlterColumn("dbo.Oteller", "Aciklama", c => c.String(maxLength: 200));
            AlterColumn("dbo.Yorumlar", "YorumBasligi", c => c.String(maxLength: 50));
            AlterColumn("dbo.Yorumlar", "YorumIcerigi", c => c.String(maxLength: 100));
            AlterColumn("dbo.Ozellikler", "OzellikAdi", c => c.String(maxLength: 50));
            CreateIndex("dbo.Odalar", "YorumIcerigi_ID");
            CreateIndex("dbo.Oteller", "AdresIl_ID");
            CreateIndex("dbo.Oteller", "Ilce_ID");
            CreateIndex("dbo.Oteller", "Mahalle_ID");
            AddForeignKey("dbo.Oteller", "AdresIl_ID", "dbo.Iller", "ID");
            AddForeignKey("dbo.Oteller", "Ilce_ID", "dbo.Ilceler", "ID");
            AddForeignKey("dbo.Oteller", "Mahalle_ID", "dbo.Mahalleler", "ID");
            AddForeignKey("dbo.Odalar", "YorumIcerigi_ID", "dbo.Yorumlar", "ID");
            DropColumn("dbo.Odalar", "YorumIcerigi");
            DropColumn("dbo.Oteller", "AdresIl");
            DropColumn("dbo.Oteller", "Ilce");
            DropColumn("dbo.Oteller", "Mahalle");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Oteller", "Mahalle", c => c.String());
            AddColumn("dbo.Oteller", "Ilce", c => c.String());
            AddColumn("dbo.Oteller", "AdresIl", c => c.String());
            AddColumn("dbo.Odalar", "YorumIcerigi", c => c.String());
            DropForeignKey("dbo.Odalar", "YorumIcerigi_ID", "dbo.Yorumlar");
            DropForeignKey("dbo.Oteller", "Mahalle_ID", "dbo.Mahalleler");
            DropForeignKey("dbo.Oteller", "Ilce_ID", "dbo.Ilceler");
            DropForeignKey("dbo.Oteller", "AdresIl_ID", "dbo.Iller");
            DropIndex("dbo.Oteller", new[] { "Mahalle_ID" });
            DropIndex("dbo.Oteller", new[] { "Ilce_ID" });
            DropIndex("dbo.Oteller", new[] { "AdresIl_ID" });
            DropIndex("dbo.Odalar", new[] { "YorumIcerigi_ID" });
            AlterColumn("dbo.Ozellikler", "OzellikAdi", c => c.String());
            AlterColumn("dbo.Yorumlar", "YorumIcerigi", c => c.String());
            AlterColumn("dbo.Yorumlar", "YorumBasligi", c => c.String());
            AlterColumn("dbo.Oteller", "Aciklama", c => c.String());
            AlterColumn("dbo.Oteller", "Adi", c => c.String());
            AlterColumn("dbo.Musteriler", "TcKimlik", c => c.String());
            AlterColumn("dbo.Musteriler", "Email", c => c.String());
            AlterColumn("dbo.Musteriler", "Telefon", c => c.String());
            AlterColumn("dbo.Musteriler", "KullaniciAdi", c => c.String());
            AlterColumn("dbo.Musteriler", "Sifre", c => c.String());
            AlterColumn("dbo.Musteriler", "Soyadi", c => c.String());
            AlterColumn("dbo.Musteriler", "Adi", c => c.String());
            AlterColumn("dbo.Iller", "IlAdi", c => c.String());
            AlterColumn("dbo.Mahalleler", "MahalleAdi", c => c.String());
            AlterColumn("dbo.Ilceler", "IlceAdi", c => c.String());
            DropColumn("dbo.Oteller", "Mahalle_ID");
            DropColumn("dbo.Oteller", "Ilce_ID");
            DropColumn("dbo.Oteller", "AdresIl_ID");
            DropColumn("dbo.Odalar", "YorumIcerigi_ID");
            RenameTable(name: "dbo.Rezervasyonlar", newName: "Rezervasyons");
            RenameTable(name: "dbo.OtelResimleri", newName: "OtelResimleris");
            RenameTable(name: "dbo.Ozellikler", newName: "Ozelliks");
            RenameTable(name: "dbo.OtelOzellikleri", newName: "OtelOzelligis");
            RenameTable(name: "dbo.Yorumlar", newName: "Yorums");
            RenameTable(name: "dbo.Yildizlar", newName: "Yildizs");
            RenameTable(name: "dbo.Oteller", newName: "Otels");
            RenameTable(name: "dbo.Odalar", newName: "Odas");
            RenameTable(name: "dbo.Musteriler", newName: "Musteris");
            RenameTable(name: "dbo.Iller", newName: "Ils");
            RenameTable(name: "dbo.Mahalleler", newName: "Mahalles");
            RenameTable(name: "dbo.Ilceler", newName: "Ilces");
        }
    }
}
