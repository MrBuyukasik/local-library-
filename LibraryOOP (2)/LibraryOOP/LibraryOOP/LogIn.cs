using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace LibraryOOP
{
    public partial class LogIn : Form
    {
        Kullanici kul;
        List<Kullanici> kListe;
        List<Yonetici> yListe;
        public LogIn()
        {
            InitializeComponent();
            kul = new Kullanici();
            kListe = new List<Kullanici>();
            yListe = new List<Yonetici>();
            SetKullanici();
            SetYonetici();
        }
        void SetKullanici()
        {
            try
            {
                string path = @"..\Database\Kullanicilar\list.txt";
                string[] lines = File.ReadAllLines(path);
                foreach (string line in lines)
                {
                    string[] tempLine = line.Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries);
                    Kullanici k = new Kullanici();
                    k.kadi = tempLine[0];
                    k.kparola = tempLine[1];
                    kListe.Add(k);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: "+ex.ToString(), "Ters Giden Bir Şeyler Var!!!",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        }

        void SetYonetici()
        {
            try
            {
                string path = @"..\Database\Kullanicilar\Yoneticiler\list.txt";
                string[] lines = File.ReadAllLines(path);
                foreach (string line in lines)
                {
                    string[] tempLine = line.Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries);
                    Yonetici y = new Yonetici();
                    y.kadi = tempLine[0];
                    y.kparola = tempLine[1];
                    yListe.Add(y);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: "+ex.ToString(),"Ters Giden Bir Şeyler Var!!!",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panel1.Location = new Point(12,163);
            panel1.Enabled = false;

            panel2.Location = new Point(12,12);
            panel2.Enabled = true;
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panel1.Location = new Point(12,12);
            panel1.Enabled = true;

            panel2.Location = new Point(12, 163);
            panel2.Enabled = false;
        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0 && textBox2.Text.Length > 0)
            {
                bool flag = false;
                if (radioButton1.Checked)
                {
                    foreach (var item in kListe)
                    {
                        if (item.kadi.Equals(textBox1.Text) && item.kparola.Equals(textBox2.Text))
                        {
                            flag = true;
                            Main main = new Main();
                            this.Hide();
                            main.Show();
                        }
                    }
                }
                else if (radioButton2.Checked)
                {
                    foreach (var item in yListe)
                    {
                        if (item.kadi.Equals(textBox1.Text) && item.kparola.Equals(textBox2.Text))
                        {
                            flag = true;
                            Main main = new Main();
                            this.Hide();
                            main.Show();
                        }
                    }
                }
                if (!flag)
                {
                    MessageBox.Show("Kullanıcı adı veya parola yanlış.","Lütfen girdileri kontrol edin.",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Boş alan bırakmayın.","Dikkat",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                bool flag = false;
                string path = @"..\Database\Kullanicilar\list.txt";
                string[] lines = File.ReadAllLines(path);
                foreach (string line in lines)
                {
                    string[] tempLine = line.Split(new[] { " " },StringSplitOptions.RemoveEmptyEntries);
                    if (tempLine[0] == textBox3.Text)
                    {
                        flag = true; 
                    }
                }
                if (flag)
                {
                    MessageBox.Show("Kullanıcı adı zaten kullanılıyor.","Hata",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }else
                {
                    using (StreamWriter w = File.AppendText(path))
                    {
                        w.WriteLine(textBox3.Text + " "+textBox4.Text);
                    }
                    Kullanici k = new Kullanici();
                    k.kadi = textBox3.Text;
                    k.kparola = textBox4.Text;
                    kListe.Add(k);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: "+ex.ToString(),"Hata",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
