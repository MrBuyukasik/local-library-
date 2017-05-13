using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryOOP
{
    class Kitaplik : Kitap
    {
        public List<Kitap> kitapListe = new List<Kitap>();
        public Kitap.Detay detay = new Kitap.Detay();
        int tempi = 0;
        public Kitaplik()
        {
            SetKitapListe();
            SetKitapDetay();
        }
        private void SetKitapListe()
        {

            foreach (string item in bookDirs)
            {
                Kitap kitap = new Kitap();
                kitap.Id = tempi;
                kitap.dir = item;
                kitapListe.Add(kitap);
                tempi++;
            }
        }
        private void SetKitapDetay()
        {
            foreach (Kitap item in kitapListe)
            {
                string tempAdi = item.dir.Substring(item.dir.LastIndexOf('\\') + 1);
                string tempKategori = Directory.GetParent(item.dir).ToString();
                string[] temp = File.ReadLines(item.dir).Take(2).ToArray();
                detay.KitapAdi = temp[0];
                detay.YazarAdi = temp[1];
                SetYazar(temp[1]);
                detay.KategoriAdi = tempKategori.Substring(tempKategori.LastIndexOf('\\') + 1);
                item.detayListe.Add(detay);
            }
        }
        public void KitapEkle(string katadi, string kitadi, string yol)
        {
            Kitap kitap = new Kitap();
            kitap.Id = tempi;
            kitap.dir = yol;
            kitapListe.Add(kitap);
            tempi++;

            string yazar = File.ReadLines(yol).Skip(1).First();
            detay.KitapAdi = kitadi;
            detay.YazarAdi = yazar;
            detay.KategoriAdi = katadi;

            SetYazar(yazar);
            kitap.detayListe.Add(detay);

        }
    }
}
