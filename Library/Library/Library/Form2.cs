using System;
using System.IO;
using System.Windows.Forms;

namespace Library
{
    public partial class Form2 : Form
    {
        
        public Form2()
        {
            InitializeComponent();
            foreach (string item in Kategori.kategoriAdi)
                listBox1.Items.Add(item);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen bir kategori seçiniz.");
            }else
            {
                Kitap.KitapEkle(listBox1.SelectedItem.ToString());
            }
            Close();                   
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
