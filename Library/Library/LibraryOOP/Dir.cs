using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryOOP
{
    class Dir
    {
        public List<string> dirs = new List<string>();
        public List<string> bookDirs = new List<string>();
        public Dir()
        {
            SetDirs();
            SetBookDirs();
        }
        void SetDirs()
        {
            string[] tempdirs = Directory.GetDirectories(@"..\Database\Kitaplar\");
            foreach (string item in tempdirs)
            {
                dirs.Add(item);
            }
        }
        void SetBookDirs()
        {
            for (int i = 0; i < dirs.Count; i++)
            {
                string[] tempDir = Directory.GetFiles(dirs[i] + '\\');
                for (int j = 0; j < tempDir.Length; j++)
                    bookDirs.Add(tempDir[j]);
            }
        }
    }
}
