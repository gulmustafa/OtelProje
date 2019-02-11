using OtelProje.Classes;
using OtelProje.CRUDFacade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelProje.Factory
{
    public class DbFactory
    {
        private static volatile OtelContext _db = null;
        public static OtelContext Db
        {
            get
            {
                if (_db == null)
                {
                    _db = new OtelContext();
                }
                return _db;
            }
        }

        private static volatile GenelCRUD<Il> _ilCRUD = null;
        public static GenelCRUD<Il> IlCRUD
        {
            get
            {
                if (_ilCRUD == null)
                {
                    _ilCRUD = new GenelCRUD<Il>(Db, Db.Iller);
                }
                return _ilCRUD;
            }
        }
        private static volatile GenelCRUD<Ilce> _ilceCRUD = null;
        public static GenelCRUD<Ilce> IlceCRUD
        {
            get
            {
                if (_ilceCRUD == null)
                {
                    _ilceCRUD = new GenelCRUD<Ilce>(Db, Db.Ilceler);
                }
                return _ilceCRUD;
            }
        }
        private static volatile GenelCRUD<Mahalle> _mahalleCRUD = null;
        public static GenelCRUD<Mahalle> MahalleCRUD
        {
            get
            {
                if (_mahalleCRUD == null)
                {
                    _mahalleCRUD = new GenelCRUD<Mahalle>(Db, Db.Mahalleler);
                }
                return _mahalleCRUD;
            }
        }
        private static volatile GenelCRUD<Musteri> _musteriCRUD = null;
        public static GenelCRUD<Musteri> MusteriCRUD
        {
            get
            {
                if (_musteriCRUD == null)
                {
                    _musteriCRUD = new GenelCRUD<Musteri>(Db, Db.Musteriler);
                }
                return _musteriCRUD;
            }
        }

        private static volatile GenelCRUD<Oda> _odaCRUD = null;
        public static GenelCRUD<Oda> OdaCRUD
        {
            get
            {
                if (_odaCRUD == null)
                {
                    _odaCRUD = new GenelCRUD<Oda>(Db, Db.Odalar);
                }
                return _odaCRUD;
            }
        }

        private static volatile GenelCRUD<Otel> _otelCRUD = null;
        public static GenelCRUD<Otel> OtelCRUD
        {
            get
            {
                if (_otelCRUD == null)
                {
                    _otelCRUD = new GenelCRUD<Otel>(Db, Db.Oteller);
                }
                return _otelCRUD;
            }
        }

        private static volatile GenelCRUD<OtelOzellik> _otelOzellikCRUD = null;
        public static GenelCRUD<OtelOzellik> OtelOzellikCRUD
        {
            get
            {
                if (_otelOzellikCRUD == null)
                {
                    _otelOzellikCRUD = new GenelCRUD<OtelOzellik>(Db, Db.OtelOzellikler);
                }
                return _otelOzellikCRUD;
            }
        }

        private static volatile GenelCRUD<OtelResimleri> _otelResimlerCRUD = null;
        public static GenelCRUD<OtelResimleri> OtelResimlerCRUD
        {
            get
            {
                if (_otelResimlerCRUD == null)
                {
                    _otelResimlerCRUD = new GenelCRUD<OtelResimleri>(Db, Db.OtelResimler);
                }
                return _otelResimlerCRUD;
            }
        }

        private static volatile GenelCRUD<Ozellik> _ozellikCRUD = null;
        public static GenelCRUD<Ozellik> OzellikCRUD
        {
            get
            {
                if (_ozellikCRUD == null)
                {
                    _ozellikCRUD = new GenelCRUD<Ozellik>(Db, Db.Ozellikler);
                }
                return _ozellikCRUD;
            }
        }

        private static volatile GenelCRUD<Rezervasyon> _rezervasyonCRUD = null;
        public static GenelCRUD<Rezervasyon> RezervasyonCRUD
        {
            get
            {
                if (_rezervasyonCRUD == null)
                {
                    _rezervasyonCRUD = new GenelCRUD<Rezervasyon>(Db, Db.Rezervasyonlar);
                }
                return _rezervasyonCRUD;
            }
        }

        private static volatile GenelCRUD<Yildiz> _yildizCRUD = null;
        public static GenelCRUD<Yildiz> YildizCRUD
        {
            get
            {
                if (_yildizCRUD == null)
                {
                    _yildizCRUD = new GenelCRUD<Yildiz>(Db, Db.Yildizlar);
                }
                return _yildizCRUD;
            }
        }

        private static volatile GenelCRUD<Yorum> _yorumCRUD = null;
        public static GenelCRUD<Yorum> YorumCRUD
        {
            get
            {
                if (_yorumCRUD == null)
                {
                    _yorumCRUD = new GenelCRUD<Yorum>(Db, Db.Yorumlar);
                }
                return _yorumCRUD;
            }
        }
    }
}
