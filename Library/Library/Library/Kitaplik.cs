using System;
using System.Collections;

namespace Library
{
    class Kitaplik:Kitap
    {
        public ArrayList yazarAdi = new ArrayList();
        public ArrayList KategoriAdi = new ArrayList();
        public Kitaplik()
        {
            Set();
        }
        void Set()
        {
            for (int i = 0; i < kitapAdi.Count; i++)
            {
                int tempYazar = Convert.ToInt32(yazarNo[i]);
                yazarAdi.Add(Yazar.yazarAdi[tempYazar]);
                int tempKategori = Convert.ToInt32(kategoriNo[i]);
                KategoriAdi.Add(Kategori.kategoriAdi[tempKategori]);
            }
        }
    }
}
