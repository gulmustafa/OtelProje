namespace OtelProje.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class güncelleme2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Ilces", "OlusturanKisi", c => c.String(maxLength: 50));
            AlterColumn("dbo.Ilces", "GuncelleyenKisi", c => c.String(maxLength: 50));
            AlterColumn("dbo.Mahalles", "OlusturanKisi", c => c.String(maxLength: 50));
            AlterColumn("dbo.Mahalles", "GuncelleyenKisi", c => c.String(maxLength: 50));
            AlterColumn("dbo.Ils", "OlusturanKisi", c => c.String(maxLength: 50));
            AlterColumn("dbo.Ils", "GuncelleyenKisi", c => c.String(maxLength: 50));
            AlterColumn("dbo.Musteris", "OlusturanKisi", c => c.String(maxLength: 50));
            AlterColumn("dbo.Musteris", "GuncelleyenKisi", c => c.String(maxLength: 50));
            AlterColumn("dbo.Odas", "OlusturanKisi", c => c.String(maxLength: 50));
            AlterColumn("dbo.Odas", "GuncelleyenKisi", c => c.String(maxLength: 50));
            AlterColumn("dbo.Otels", "OlusturanKisi", c => c.String(maxLength: 50));
            AlterColumn("dbo.Otels", "GuncelleyenKisi", c => c.String(maxLength: 50));
            AlterColumn("dbo.Yildizs", "OlusturanKisi", c => c.String(maxLength: 50));
            AlterColumn("dbo.Yildizs", "GuncelleyenKisi", c => c.String(maxLength: 50));
            AlterColumn("dbo.Yorums", "OlusturanKisi", c => c.String(maxLength: 50));
            AlterColumn("dbo.Yorums", "GuncelleyenKisi", c => c.String(maxLength: 50));
            AlterColumn("dbo.OtelOzelligis", "OlusturanKisi", c => c.String(maxLength: 50));
            AlterColumn("dbo.OtelOzelligis", "GuncelleyenKisi", c => c.String(maxLength: 50));
            AlterColumn("dbo.Ozelliks", "OlusturanKisi", c => c.String(maxLength: 50));
            AlterColumn("dbo.Ozelliks", "GuncelleyenKisi", c => c.String(maxLength: 50));
            AlterColumn("dbo.OtelResimleris", "OlusturanKisi", c => c.String(maxLength: 50));
            AlterColumn("dbo.OtelResimleris", "GuncelleyenKisi", c => c.String(maxLength: 50));
            AlterColumn("dbo.Rezervasyons", "OlusturanKisi", c => c.String(maxLength: 50));
            AlterColumn("dbo.Rezervasyons", "GuncelleyenKisi", c => c.String(maxLength: 50));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Rezervasyons", "GuncelleyenKisi", c => c.String());
            AlterColumn("dbo.Rezervasyons", "OlusturanKisi", c => c.String());
            AlterColumn("dbo.OtelResimleris", "GuncelleyenKisi", c => c.String());
            AlterColumn("dbo.OtelResimleris", "OlusturanKisi", c => c.String());
            AlterColumn("dbo.Ozelliks", "GuncelleyenKisi", c => c.String());
            AlterColumn("dbo.Ozelliks", "OlusturanKisi", c => c.String());
            AlterColumn("dbo.OtelOzelligis", "GuncelleyenKisi", c => c.String());
            AlterColumn("dbo.OtelOzelligis", "OlusturanKisi", c => c.String());
            AlterColumn("dbo.Yorums", "GuncelleyenKisi", c => c.String());
            AlterColumn("dbo.Yorums", "OlusturanKisi", c => c.String());
            AlterColumn("dbo.Yildizs", "GuncelleyenKisi", c => c.String());
            AlterColumn("dbo.Yildizs", "OlusturanKisi", c => c.String());
            AlterColumn("dbo.Otels", "GuncelleyenKisi", c => c.String());
            AlterColumn("dbo.Otels", "OlusturanKisi", c => c.String());
            AlterColumn("dbo.Odas", "GuncelleyenKisi", c => c.String());
            AlterColumn("dbo.Odas", "OlusturanKisi", c => c.String());
            AlterColumn("dbo.Musteris", "GuncelleyenKisi", c => c.String());
            AlterColumn("dbo.Musteris", "OlusturanKisi", c => c.String());
            AlterColumn("dbo.Ils", "GuncelleyenKisi", c => c.String());
            AlterColumn("dbo.Ils", "OlusturanKisi", c => c.String());
            AlterColumn("dbo.Mahalles", "GuncelleyenKisi", c => c.String());
            AlterColumn("dbo.Mahalles", "OlusturanKisi", c => c.String());
            AlterColumn("dbo.Ilces", "GuncelleyenKisi", c => c.String());
            AlterColumn("dbo.Ilces", "OlusturanKisi", c => c.String());
        }
    }
}
