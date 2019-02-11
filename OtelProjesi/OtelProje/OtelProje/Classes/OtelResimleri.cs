using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelProje.Classes
{
    [Table("OtelResimleri")]
    public class OtelResimleri : DbObject
    {
        public Otel Otel { get; set; }
        public byte[] Resim { get; set; }

        public OtelResimleri()
        {

        }
        public OtelResimleri(byte[] resim)
        {
            Resim = resim;
        }

        public override string ToString()
        {
            return "Otel Resim: " + Resim;
        }


    }
}
