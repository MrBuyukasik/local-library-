using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace Library
{
    public partial class Form3 : Form
    {
        public static string gonderilecekVeri;
        public Form3()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            gonderilecekVeri = textBox1.Text; 
            if (textBox1.Text == string.Empty)      //İlgili dizine eklenen dosyayı oluşturma
            {
                MessageBox.Show("Lütfen boş bırakmayınız.");

            }
            else
            {
                
                try
                {
                    Directory.CreateDirectory(@"..\DB\Library\" + textBox1.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Bir Hatayla Karşılaşıldı.", MessageBoxButtons.OK);
                }
                MessageBox.Show("Kategori Başarıyla Eklendi");
            }
           
            Close();
        }
    }
}
