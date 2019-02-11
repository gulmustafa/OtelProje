using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelProje.Classes
{
    [Table("Ozellikler")]
    public class Ozellik : DbObject
    {
        [MaxLength(50)]
        public string OzellikAdi { get; set; }

        public Ozellik()
        {

        }
        public Ozellik(string ozellikAdi)
        {
            OzellikAdi = ozellikAdi;
        }

        public override string ToString()
        {
            return "Özellik: " + OzellikAdi;
        }
    }
}
