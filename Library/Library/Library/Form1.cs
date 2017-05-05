using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {           
            Kitap book = new Kitap();
            for (int i = 0; i < book.kitapAdi.Count; i++)
            {
                dataGridView1.Rows.Add(1);
                dataGridView1.Rows[dataGridView1.Rows.Count - 2].Cells[0].Value = book.kitapAdi[i].ToString();
                dataGridView1.Rows[dataGridView1.Rows.Count - 2].Cells[1].Value = book.yazarAdi[i].ToString();
                dataGridView1.Rows[dataGridView1.Rows.Count - 2].Cells[2].Value = book.kategori[i].ToString();
            }
        }

        private void btnKitapEkle_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.Show();
        }
    }
}
