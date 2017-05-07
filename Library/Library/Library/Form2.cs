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
        }

        private void Form2_Load(object sender, EventArgs e)
        {
          if(string.IsNullOrEmpty(Form3.gonderilecekVeri))  // Dosya Null donduruyorsa Herhangi bir ekleme yapmaması durumu
            {

            }
            else
            {
                listBox1.Items.Add(Form3.gonderilecekVeri);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            if (listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen bir kategori seçiniz.");
            }else
            {
                OpenFileDialog of = new OpenFileDialog();
                of.InitialDirectory = "C:\\";
                of.Filter = "Text Dosyası (*.txt)|*.txt";
                if (of.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        int index = of.FileName.LastIndexOf('\\');
                        string fileName = of.FileName.Substring(index + 1);
                        string source = of.FileName;
                        string target = @"..\DB\Library\" + listBox1.SelectedItem.ToString() + "\\" + fileName;
                        File.Copy(source,target);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString(),"Bir Hatayla Karşılaşıldı.",MessageBoxButtons.OK);
                    }
                }
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
       
    }
}
