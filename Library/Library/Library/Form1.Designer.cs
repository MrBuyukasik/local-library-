namespace Library
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnKategoriEkle = new System.Windows.Forms.Button();
            this.btnKitapEkle = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.kitapadi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yazar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kategori = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pnlKitaplik = new System.Windows.Forms.Panel();
            this.btnKitaplik = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.pnlKitap = new System.Windows.Forms.Panel();
            this.btnKitap = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.pnlYazar = new System.Windows.Forms.Panel();
            this.btnYazar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.pnlKategori = new System.Windows.Forms.Panel();
            this.btnKategoriler = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.rbKitaplik = new System.Windows.Forms.RadioButton();
            this.rbKitap = new System.Windows.Forms.RadioButton();
            this.rbYazar = new System.Windows.Forms.RadioButton();
            this.rbKategori = new System.Windows.Forms.RadioButton();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.pnlKitaplik.SuspendLayout();
            this.pnlKitap.SuspendLayout();
            this.pnlYazar.SuspendLayout();
            this.pnlKategori.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnKategoriEkle
            // 
            this.btnKategoriEkle.Location = new System.Drawing.Point(12, 28);
            this.btnKategoriEkle.Name = "btnKategoriEkle";
            this.btnKategoriEkle.Size = new System.Drawing.Size(104, 23);
            this.btnKategoriEkle.TabIndex = 0;
            this.btnKategoriEkle.Text = "Kategori Ekle";
            this.btnKategoriEkle.UseVisualStyleBackColor = true;
            this.btnKategoriEkle.Click += new System.EventHandler(this.btnKategoriEkle_Click);
            // 
            // btnKitapEkle
            // 
            this.btnKitapEkle.Location = new System.Drawing.Point(12, 57);
            this.btnKitapEkle.Name = "btnKitapEkle";
            this.btnKitapEkle.Size = new System.Drawing.Size(104, 23);
            this.btnKitapEkle.TabIndex = 1;
            this.btnKitapEkle.Text = "Kitap Ekle";
            this.btnKitapEkle.UseVisualStyleBackColor = true;
            this.btnKitapEkle.Click += new System.EventHandler(this.btnKitapEkle_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 86);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(104, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 115);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(104, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(161, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(510, 336);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kitaplık";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kitapadi,
            this.yazar,
            this.kategori});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.Size = new System.Drawing.Size(504, 317);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseClick);
            // 
            // kitapadi
            // 
            this.kitapadi.HeaderText = "Kitap Adı";
            this.kitapadi.Name = "kitapadi";
            this.kitapadi.Width = 200;
            // 
            // yazar
            // 
            this.yazar.HeaderText = "Yazar";
            this.yazar.Name = "yazar";
            this.yazar.Width = 200;
            // 
            // kategori
            // 
            this.kategori.HeaderText = "Kategori";
            this.kategori.Name = "kategori";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pnlKitaplik);
            this.groupBox1.Controls.Add(this.pnlKitap);
            this.groupBox1.Controls.Add(this.pnlYazar);
            this.groupBox1.Controls.Add(this.pnlKategori);
            this.groupBox1.Controls.Add(this.rbKitaplik);
            this.groupBox1.Controls.Add(this.rbKitap);
            this.groupBox1.Controls.Add(this.rbYazar);
            this.groupBox1.Controls.Add(this.rbKategori);
            this.groupBox1.Location = new System.Drawing.Point(164, 355);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(507, 118);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Arama Yap";
            // 
            // pnlKitaplik
            // 
            this.pnlKitaplik.Controls.Add(this.btnKitaplik);
            this.pnlKitaplik.Controls.Add(this.label7);
            this.pnlKitaplik.Controls.Add(this.textBox7);
            this.pnlKitaplik.Location = new System.Drawing.Point(195, 20);
            this.pnlKitaplik.Name = "pnlKitaplik";
            this.pnlKitaplik.Size = new System.Drawing.Size(200, 87);
            this.pnlKitaplik.TabIndex = 7;
            // 
            // btnKitaplik
            // 
            this.btnKitaplik.Location = new System.Drawing.Point(96, 30);
            this.btnKitaplik.Name = "btnKitaplik";
            this.btnKitaplik.Size = new System.Drawing.Size(100, 23);
            this.btnKitaplik.TabIndex = 11;
            this.btnKitaplik.Text = "Ara";
            this.btnKitaplik.UseVisualStyleBackColor = true;
            this.btnKitaplik.Click += new System.EventHandler(this.btnKitaplik_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 6);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Aranacak Kelime";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(96, 3);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(100, 20);
            this.textBox7.TabIndex = 9;
            // 
            // pnlKitap
            // 
            this.pnlKitap.Controls.Add(this.btnKitap);
            this.pnlKitap.Controls.Add(this.label5);
            this.pnlKitap.Controls.Add(this.textBox5);
            this.pnlKitap.Controls.Add(this.label6);
            this.pnlKitap.Controls.Add(this.textBox6);
            this.pnlKitap.Location = new System.Drawing.Point(213, 225);
            this.pnlKitap.Name = "pnlKitap";
            this.pnlKitap.Size = new System.Drawing.Size(201, 87);
            this.pnlKitap.TabIndex = 6;
            // 
            // btnKitap
            // 
            this.btnKitap.Location = new System.Drawing.Point(96, 58);
            this.btnKitap.Name = "btnKitap";
            this.btnKitap.Size = new System.Drawing.Size(100, 23);
            this.btnKitap.TabIndex = 9;
            this.btnKitap.Text = "Ara";
            this.btnKitap.UseVisualStyleBackColor = true;
            this.btnKitap.Click += new System.EventHandler(this.btnKitap_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Aranacak Kelime";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(96, 32);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(56, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Kitap";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(96, 6);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 20);
            this.textBox6.TabIndex = 5;
            // 
            // pnlYazar
            // 
            this.pnlYazar.Controls.Add(this.btnYazar);
            this.pnlYazar.Controls.Add(this.label2);
            this.pnlYazar.Controls.Add(this.textBox3);
            this.pnlYazar.Controls.Add(this.label1);
            this.pnlYazar.Controls.Add(this.textBox2);
            this.pnlYazar.Location = new System.Drawing.Point(213, 133);
            this.pnlYazar.Name = "pnlYazar";
            this.pnlYazar.Size = new System.Drawing.Size(201, 87);
            this.pnlYazar.TabIndex = 5;
            // 
            // btnYazar
            // 
            this.btnYazar.Location = new System.Drawing.Point(96, 58);
            this.btnYazar.Name = "btnYazar";
            this.btnYazar.Size = new System.Drawing.Size(100, 23);
            this.btnYazar.TabIndex = 4;
            this.btnYazar.Text = "Ara";
            this.btnYazar.UseVisualStyleBackColor = true;
            this.btnYazar.Click += new System.EventHandler(this.btnYazar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Aranacak Kelime";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(96, 32);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Yazar";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(96, 6);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 0;
            // 
            // pnlKategori
            // 
            this.pnlKategori.Controls.Add(this.btnKategoriler);
            this.pnlKategori.Controls.Add(this.label3);
            this.pnlKategori.Controls.Add(this.textBox1);
            this.pnlKategori.Controls.Add(this.label4);
            this.pnlKategori.Controls.Add(this.textBox4);
            this.pnlKategori.Location = new System.Drawing.Point(7, 132);
            this.pnlKategori.Name = "pnlKategori";
            this.pnlKategori.Size = new System.Drawing.Size(200, 87);
            this.pnlKategori.TabIndex = 4;
            // 
            // btnKategoriler
            // 
            this.btnKategoriler.Location = new System.Drawing.Point(96, 58);
            this.btnKategoriler.Name = "btnKategoriler";
            this.btnKategoriler.Size = new System.Drawing.Size(100, 23);
            this.btnKategoriler.TabIndex = 9;
            this.btnKategoriler.Text = "Ara";
            this.btnKategoriler.UseVisualStyleBackColor = true;
            this.btnKategoriler.Click += new System.EventHandler(this.btnKategoriler_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Aranacak Kelime";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(96, 32);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Kategori(ler)";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(96, 6);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 5;
            // 
            // rbKitaplik
            // 
            this.rbKitaplik.AutoSize = true;
            this.rbKitaplik.Checked = true;
            this.rbKitaplik.Location = new System.Drawing.Point(7, 89);
            this.rbKitaplik.Name = "rbKitaplik";
            this.rbKitaplik.Size = new System.Drawing.Size(111, 17);
            this.rbKitaplik.TabIndex = 3;
            this.rbKitaplik.TabStop = true;
            this.rbKitaplik.Text = "Tüm Kitaplıkta Ara";
            this.rbKitaplik.UseVisualStyleBackColor = true;
            this.rbKitaplik.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // rbKitap
            // 
            this.rbKitap.AutoSize = true;
            this.rbKitap.Location = new System.Drawing.Point(7, 66);
            this.rbKitap.Name = "rbKitap";
            this.rbKitap.Size = new System.Drawing.Size(139, 17);
            this.rbKitap.TabIndex = 2;
            this.rbKitap.Text = "Bir Kitabın İçerisinde Ara";
            this.rbKitap.UseVisualStyleBackColor = true;
            this.rbKitap.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // rbYazar
            // 
            this.rbYazar.AutoSize = true;
            this.rbYazar.Location = new System.Drawing.Point(7, 43);
            this.rbYazar.Name = "rbYazar";
            this.rbYazar.Size = new System.Drawing.Size(182, 17);
            this.rbYazar.TabIndex = 1;
            this.rbYazar.Text = "Bir Yazarın Kitapları İçerisinde Ara";
            this.rbYazar.UseVisualStyleBackColor = true;
            this.rbYazar.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // rbKategori
            // 
            this.rbKategori.AutoSize = true;
            this.rbKategori.Location = new System.Drawing.Point(7, 20);
            this.rbKategori.Name = "rbKategori";
            this.rbKategori.Size = new System.Drawing.Size(139, 17);
            this.rbKategori.TabIndex = 0;
            this.rbKategori.Text = "Belirli Kategori(ler)de Ara";
            this.rbKategori.UseVisualStyleBackColor = true;
            this.rbKategori.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 731);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnKitapEkle);
            this.Controls.Add(this.btnKategoriEkle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.pnlKitaplik.ResumeLayout(false);
            this.pnlKitaplik.PerformLayout();
            this.pnlKitap.ResumeLayout(false);
            this.pnlKitap.PerformLayout();
            this.pnlYazar.ResumeLayout(false);
            this.pnlYazar.PerformLayout();
            this.pnlKategori.ResumeLayout(false);
            this.pnlKategori.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnKategoriEkle;
        private System.Windows.Forms.Button btnKitapEkle;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitapadi;
        private System.Windows.Forms.DataGridViewTextBoxColumn yazar;
        private System.Windows.Forms.DataGridViewTextBoxColumn kategori;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel pnlKitaplik;
        private System.Windows.Forms.Button btnKitaplik;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Panel pnlKitap;
        private System.Windows.Forms.Button btnKitap;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Panel pnlYazar;
        private System.Windows.Forms.Button btnYazar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Panel pnlKategori;
        private System.Windows.Forms.Button btnKategoriler;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.RadioButton rbKitaplik;
        private System.Windows.Forms.RadioButton rbKitap;
        private System.Windows.Forms.RadioButton rbYazar;
        private System.Windows.Forms.RadioButton rbKategori;
    }
}

