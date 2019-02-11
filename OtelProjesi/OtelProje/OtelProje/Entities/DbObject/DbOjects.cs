using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelProje.Entities.DbObject
{
    public class DbOjects
    {
        public string Id  { get; set; }
        [MaxLength(50)]
        public string  OlusturanKisi { get; set; }
        public DateTime  OlusturmaTarihi { get; set; }
        [MaxLength(50)]
        public string  GuncelleyenKisi { get; set; }
        public DateTime GuncellemeTarihi { get; set; }
        public DbOjects()
        {
            Id = Guid.NewGuid().ToString();
            OlusturmaTarihi = DateTime.Now;
        }
    }
}
