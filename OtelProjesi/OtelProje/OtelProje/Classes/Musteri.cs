using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelProje.Classes
{
    [Table("Musteriler")]
    public class Musteri : DbObject
    {
        [MaxLength(50)]
        public string Adi { get; set; }
        [MaxLength(50)]
        public string Soyadi { get; set; }
        [MaxLength(50)]
        public string Sifre { get; set; }
        [MaxLength(50)]
        public string KullaniciAdi { get; set; }
        [MaxLength(20)]
        public string Telefon { get; set; }
        [MaxLength(50)]
        public string Email { get; set; }
        [MaxLength(11)]
        public string TcKimlik { get; set; }

        public Musteri()
        {

        }
        public Musteri(string adi, string soyadi, string sifre, string kullaniciAdi, string telefon, string email, string tcKimlik)
        {
            Adi = adi;
            Soyadi = soyadi;
            Sifre = sifre;
            KullaniciAdi = kullaniciAdi;
            Telefon = telefon;
            Email = email;
            TcKimlik = tcKimlik;
        }

        public override string ToString()
        {
            return "Müşteri Adı: " + Adi + "Müsteri Soyadı: " + Soyadi;
        }


    }
}
