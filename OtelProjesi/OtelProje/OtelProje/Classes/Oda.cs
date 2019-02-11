using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelProje.Classes
{
    [Table("Odalar")]
    public class Oda : DbObject
    {
        public Otel otel { get; set; }
        public Yorum YorumIcerigi { get; set; }
        public bool OdaBosMu { get; set; }

        public Oda()
        {

        }
        public Oda(Yorum yorumIcerigi, bool odaBosMu)
        {
            YorumIcerigi = yorumIcerigi;
            OdaBosMu = odaBosMu;
        }

        public override string ToString()
        {
            return "Yorum İçeriği: " + YorumIcerigi + "Oda Bos Mu? " + OdaBosMu;
        }


    }
}
