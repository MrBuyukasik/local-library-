using System;
using System.Collections;
using System.IO;
using System.Windows.Forms;

namespace Library
{
    class Kategori
    {
        public static ArrayList kategoriAdi = new ArrayList();
        public Kategori()
        {
            SetKategoriAdi();
        }
        void SetKategoriAdi()
        {
            foreach (string item in Program.dir)
            {
                kategoriAdi.Add(item.Substring(item.LastIndexOf('\\') + 1));
            }
        }
        public void KategoriEkle(string ad)
        {
            if (ad == string.Empty)      //İlgili dizine eklenen dosyayı oluşturma
            {
                MessageBox.Show("Lütfen boş bırakmayınız.");
            }
            else
            {
                try
                {
                    Directory.CreateDirectory(@"..\DB\Library\" + ad);
                    kategoriAdi.Add(ad);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Bir Hatayla Karşılaşıldı.", MessageBoxButtons.OK);
                }
                finally
                {
                    MessageBox.Show("Kategori Başarıyla Eklendi");
                }
            }
        }
    }
}
