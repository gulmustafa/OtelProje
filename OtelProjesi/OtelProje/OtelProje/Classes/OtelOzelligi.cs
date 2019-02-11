using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelProje.Classes
{
    [Table("OtelOzellikleri")]
    public class OtelOzelligi : DbObject
    {
        public Otel Otel { get; set; }
        public Ozellik Ozellik { get; set; }

        public OtelOzelligi()
        {

        }

        public override string ToString()
        {
            return "Otel: " + Otel + "Otel Ozelliği: " + Ozellik;
        }
    }
}
