using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryOOP
{
    public partial class PopupTB : Form
    {
        public string Ad {get;set;}
        public PopupTB()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ad = textBox1.Text.Trim();
            Close();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Ad = textBox1.Text.Trim();
                Close();
            }else if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }
    }
}
