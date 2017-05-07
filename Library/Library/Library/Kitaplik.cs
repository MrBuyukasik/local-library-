using System;
using System.Collections;

namespace Library
{
    class Kitaplik
    {
        public static ArrayList yazarAdi = new ArrayList();
        public static ArrayList KategoriAdi = new ArrayList();
        public Kitaplik()
        {
            Setyk();
        }
        public static void Setyk()
        {
            for (int i = 0; i < Kitap.kitapAdi.Count; i++)
            {
                int tempYazar = Convert.ToInt32(Kitap.yazarNo[i]);
                yazarAdi.Add(Yazar.yazarAdi[tempYazar]);
                int tempKategori = Convert.ToInt32(Kitap.kategoriNo[i]);
                KategoriAdi.Add(Kategori.kategoriAdi[tempKategori]);
            }
        }
    }
}
