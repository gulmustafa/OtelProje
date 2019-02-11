using OtelProje.Entities.DbObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelProje.Classes
{
    public class OtelOzellik:DbOjects
    {
        public OtelOzellik()
        {

        }
        public OtelOzellik(Otel otel, Ozellik ozellik)
        {
            Otel = otel;
            Ozellik = ozellik;
        }

        public Otel Otel { get; set; }
        public Ozellik Ozellik { get; set; }
        public override string ToString()
        {
            return Otel.OtelAdi;
        }
    }
}
