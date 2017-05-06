using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class Yazar
    {
        public static ArrayList yazarAdi = new ArrayList();
        public Yazar()
        {
            SetYazarAdi();
        }
        void SetYazarAdi()
        {
            for (int i = 0; i < Program.bookDir.Count; i++)
            {
                string temp = File.ReadLines(Program.bookDir[i].ToString()).Skip(1).Take(1).First();
                bool flag = true;
                foreach (string item in yazarAdi) // Aynı yazarı tekrar kaydetmemek için yapılan kontrol
                {
                    if (item == temp)
                    {
                        flag = false;
                    }
                }
                if (flag)
                {
                    yazarAdi.Add(temp);
                }
            }
        }
    }
}
