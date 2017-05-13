using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryOOP
{
    class Kitap : Yazar
    {
        public int Id { get; set; }
        public string dir;
        public struct Detay
        {
            public string KitapAdi { get; set; }
            public string YazarAdi { get; set; }
            public string KategoriAdi { get; set; }
        }
        public List<Detay> detayListe = new List<Detay>();
    }
}
