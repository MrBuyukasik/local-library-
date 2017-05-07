using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Library
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]        
        static void Main()
        {
            SetDir();
            SetBookDir();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
        // Dizin ve Dosya İşleri
        public static string path=@"..\DB\Library\";
        public static string[] dir ;
        public static ArrayList bookDir = new ArrayList();   
        public static void SetDir()
        {
            path = @"..\DB\Library\";
            dir = Directory.GetDirectories(Program.path);
        } 
        public static void SetBookDir()
        {
            for (int i = 0; i < Program.dir.Length; i++)
            {
                string[] tempDir = Directory.GetFiles(Program.dir[i] + '\\');
                for (int j = 0; j < tempDir.Length; j++)
                {
                    bookDir.Add(tempDir[j]);
                }
            }
        } 
    }
}
