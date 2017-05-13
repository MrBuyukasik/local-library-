using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryOOP
{
    class Yazar : Kategori
    {
        public List<string> yazar = new List<string>();
        public void SetYazar(string adi)
        {
            if (!yazar.Contains(adi)) yazar.Add(adi);
        }
    }
}
