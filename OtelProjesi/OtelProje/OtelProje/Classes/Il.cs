using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelProje.Classes
{
    [Table("Iller")]
    public class Il : DbObject
    {
        [MaxLength(50)]
        public string IlAdi { get; set; }
        public List<Ilce> Ilceler { get; set; }

        public Il()
        {
            Ilceler = new List<Ilce>();
        }
        public Il(string adi)
        {
            IlAdi = adi;
            Ilceler = new List<Ilce>();
        }

        public override string ToString()
        {
            return "İl Adı: " + IlAdi + "İlçe Adı: " + Ilceler;
        }
    }
}
