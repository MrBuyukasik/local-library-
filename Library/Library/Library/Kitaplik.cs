using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class Kitaplik
    {
        public string[] kategori = Directory.GetDirectories(@"..\DB\Library\");
        int[] slashIndex;
        public Kitaplik()
        {
            SetKategori();
        }
        void SetKategori()
        {
            slashIndex = new int[kategori.Length];
            for (int i = 0; i < kategori.Length; i++) // kategori ismini split ediyoruz
            {
                slashIndex[i] = kategori[i].LastIndexOf('\\');
                kategori[i] = kategori[i].Substring(slashIndex[i] + 1);
            }
        }
        
    }
}
