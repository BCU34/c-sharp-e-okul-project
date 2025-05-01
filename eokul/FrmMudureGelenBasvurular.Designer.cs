namespace eokul
{
    partial class FrmMudureGelenBasvurular
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
            this.groupMenu = new System.Windows.Forms.GroupBox();
            this.groupAciklama = new System.Windows.Forms.GroupBox();
            this.richAciklama = new System.Windows.Forms.RichTextBox();
            this.groupOgrDetay = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioOgretmen = new System.Windows.Forms.RadioButton();
            this.radioMdrYardimcisi = new System.Windows.Forms.RadioButton();
            this.radioOgrenci = new System.Windows.Forms.RadioButton();
            this.btnOgrtckimliknogosteraciklama = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txtOgretmenDers = new System.Windows.Forms.TextBox();
            this.maskOgrenciTC = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.radioKadin = new System.Windows.Forms.RadioButton();
            this.radioErkek = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.txtOgrenciYas = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtOgrenciAdSoyad = new System.Windows.Forms.TextBox();
            this.groupBGO = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupİslemler = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupMenu.SuspendLayout();
            this.groupAciklama.SuspendLayout();
            this.groupOgrDetay.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBGO.SuspendLayout();
            this.groupİslemler.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupMenu
            // 
            this.groupMenu.Controls.Add(this.groupAciklama);
            this.groupMenu.Controls.Add(this.groupOgrDetay);
            this.groupMenu.Location = new System.Drawing.Point(289, 12);
            this.groupMenu.Name = "groupMenu";
            this.groupMenu.Size = new System.Drawing.Size(564, 518);
            this.groupMenu.TabIndex = 24;
            this.groupMenu.TabStop = false;
            this.groupMenu.Text = "Menü";
            // 
            // groupAciklama
            // 
            this.groupAciklama.Controls.Add(this.richAciklama);
            this.groupAciklama.Location = new System.Drawing.Point(6, 255);
            this.groupAciklama.Name = "groupAciklama";
            this.groupAciklama.Size = new System.Drawing.Size(549, 257);
            this.groupAciklama.TabIndex = 26;
            this.groupAciklama.TabStop = false;
            this.groupAciklama.Text = "Açıklama";
            // 
            // richAciklama
            // 
            this.richAciklama.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richAciklama.Location = new System.Drawing.Point(3, 23);
            this.richAciklama.Name = "richAciklama";
            this.richAciklama.Size = new System.Drawing.Size(543, 231);
            this.richAciklama.TabIndex = 11;
            this.richAciklama.Text = "NULL";
            // 
            // groupOgrDetay
            // 
            this.groupOgrDetay.Controls.Add(this.groupBox2);
            this.groupOgrDetay.Controls.Add(this.btnOgrtckimliknogosteraciklama);
            this.groupOgrDetay.Controls.Add(this.label10);
            this.groupOgrDetay.Controls.Add(this.txtOgretmenDers);
            this.groupOgrDetay.Controls.Add(this.maskOgrenciTC);
            this.groupOgrDetay.Controls.Add(this.label9);
            this.groupOgrDetay.Controls.Add(this.radioKadin);
            this.groupOgrDetay.Controls.Add(this.radioErkek);
            this.groupOgrDetay.Controls.Add(this.label8);
            this.groupOgrDetay.Controls.Add(this.txtOgrenciYas);
            this.groupOgrDetay.Controls.Add(this.label7);
            this.groupOgrDetay.Controls.Add(this.label6);
            this.groupOgrDetay.Controls.Add(this.txtOgrenciAdSoyad);
            this.groupOgrDetay.Location = new System.Drawing.Point(6, 20);
            this.groupOgrDetay.Name = "groupOgrDetay";
            this.groupOgrDetay.Size = new System.Drawing.Size(549, 229);
            this.groupOgrDetay.TabIndex = 23;
            this.groupOgrDetay.TabStop = false;
            this.groupOgrDetay.Text = "Öğrenci Detayları";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioOgretmen);
            this.groupBox2.Controls.Add(this.radioMdrYardimcisi);
            this.groupBox2.Controls.Add(this.radioOgrenci);
            this.groupBox2.Location = new System.Drawing.Point(371, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(166, 117);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Seçenekler";
            // 
            // radioOgretmen
            // 
            this.radioOgretmen.AutoSize = true;
            this.radioOgretmen.Location = new System.Drawing.Point(16, 52);
            this.radioOgretmen.Name = "radioOgretmen";
            this.radioOgretmen.Size = new System.Drawing.Size(92, 23);
            this.radioOgretmen.TabIndex = 2;
            this.radioOgretmen.Text = "Öğretmen";
            this.radioOgretmen.UseVisualStyleBackColor = true;
            this.radioOgretmen.CheckedChanged += new System.EventHandler(this.radioOgretmen_CheckedChanged);
            // 
            // radioMdrYardimcisi
            // 
            this.radioMdrYardimcisi.AutoSize = true;
            this.radioMdrYardimcisi.Location = new System.Drawing.Point(16, 81);
            this.radioMdrYardimcisi.Name = "radioMdrYardimcisi";
            this.radioMdrYardimcisi.Size = new System.Drawing.Size(139, 23);
            this.radioMdrYardimcisi.TabIndex = 3;
            this.radioMdrYardimcisi.Text = "Müdür Yardımcısı";
            this.radioMdrYardimcisi.UseVisualStyleBackColor = true;
            this.radioMdrYardimcisi.CheckedChanged += new System.EventHandler(this.radioMdrYardimcisi_CheckedChanged);
            // 
            // radioOgrenci
            // 
            this.radioOgrenci.AutoSize = true;
            this.radioOgrenci.Checked = true;
            this.radioOgrenci.Location = new System.Drawing.Point(16, 23);
            this.radioOgrenci.Name = "radioOgrenci";
            this.radioOgrenci.Size = new System.Drawing.Size(78, 23);
            this.radioOgrenci.TabIndex = 1;
            this.radioOgrenci.TabStop = true;
            this.radioOgrenci.Text = "Öğrenci";
            this.radioOgrenci.UseVisualStyleBackColor = true;
            this.radioOgrenci.CheckedChanged += new System.EventHandler(this.radioOgrenci_CheckedChanged);
            // 
            // btnOgrtckimliknogosteraciklama
            // 
            this.btnOgrtckimliknogosteraciklama.BackgroundImage = global::eokul.Properties.Resources.hide;
            this.btnOgrtckimliknogosteraciklama.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnOgrtckimliknogosteraciklama.Location = new System.Drawing.Point(367, 136);
            this.btnOgrtckimliknogosteraciklama.Name = "btnOgrtckimliknogosteraciklama";
            this.btnOgrtckimliknogosteraciklama.Size = new System.Drawing.Size(27, 27);
            this.btnOgrtckimliknogosteraciklama.TabIndex = 9;
            this.btnOgrtckimliknogosteraciklama.UseVisualStyleBackColor = true;
            this.btnOgrtckimliknogosteraciklama.Click += new System.EventHandler(this.btnOgrtckimliknogosteraciklama_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(121, 184);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 19);
            this.label10.TabIndex = 10;
            this.label10.Text = "Ders:";
            this.label10.Visible = false;
            // 
            // txtOgretmenDers
            // 
            this.txtOgretmenDers.Location = new System.Drawing.Point(170, 179);
            this.txtOgretmenDers.Name = "txtOgretmenDers";
            this.txtOgretmenDers.Size = new System.Drawing.Size(100, 27);
            this.txtOgretmenDers.TabIndex = 10;
            this.txtOgretmenDers.Text = "null";
            this.txtOgretmenDers.Visible = false;
            // 
            // maskOgrenciTC
            // 
            this.maskOgrenciTC.Location = new System.Drawing.Point(170, 136);
            this.maskOgrenciTC.Mask = "00000000000";
            this.maskOgrenciTC.Name = "maskOgrenciTC";
            this.maskOgrenciTC.Size = new System.Drawing.Size(195, 27);
            this.maskOgrenciTC.TabIndex = 8;
            this.maskOgrenciTC.Text = "00000000000";
            this.maskOgrenciTC.UseSystemPasswordChar = true;
            this.maskOgrenciTC.ValidatingType = typeof(int);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 139);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(150, 19);
            this.label9.TabIndex = 7;
            this.label9.Text = "Öğrenci TC Kimlik No:";
            // 
            // radioKadin
            // 
            this.radioKadin.AutoSize = true;
            this.radioKadin.Location = new System.Drawing.Point(239, 102);
            this.radioKadin.Name = "radioKadin";
            this.radioKadin.Size = new System.Drawing.Size(63, 23);
            this.radioKadin.TabIndex = 7;
            this.radioKadin.Text = "Kadın";
            this.radioKadin.UseVisualStyleBackColor = true;
            // 
            // radioErkek
            // 
            this.radioErkek.AutoSize = true;
            this.radioErkek.Checked = true;
            this.radioErkek.Location = new System.Drawing.Point(170, 102);
            this.radioErkek.Name = "radioErkek";
            this.radioErkek.Size = new System.Drawing.Size(61, 23);
            this.radioErkek.TabIndex = 6;
            this.radioErkek.TabStop = true;
            this.radioErkek.Text = "Erkek";
            this.radioErkek.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(99, 104);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 19);
            this.label8.TabIndex = 4;
            this.label8.Text = "Cinsiyeti";
            // 
            // txtOgrenciYas
            // 
            this.txtOgrenciYas.Location = new System.Drawing.Point(170, 66);
            this.txtOgrenciYas.Name = "txtOgrenciYas";
            this.txtOgrenciYas.Size = new System.Drawing.Size(84, 27);
            this.txtOgrenciYas.TabIndex = 5;
            this.txtOgrenciYas.Text = "00";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(71, 69);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 19);
            this.label7.TabIndex = 2;
            this.label7.Text = "Öğrenci Yaşı:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 19);
            this.label6.TabIndex = 1;
            this.label6.Text = "Öğrenci Ad Soyad:";
            // 
            // txtOgrenciAdSoyad
            // 
            this.txtOgrenciAdSoyad.Location = new System.Drawing.Point(170, 26);
            this.txtOgrenciAdSoyad.Name = "txtOgrenciAdSoyad";
            this.txtOgrenciAdSoyad.Size = new System.Drawing.Size(195, 27);
            this.txtOgrenciAdSoyad.TabIndex = 4;
            this.txtOgrenciAdSoyad.Text = "null null";
            // 
            // groupBGO
            // 
            this.groupBGO.Controls.Add(this.listBox1);
            this.groupBGO.Location = new System.Drawing.Point(12, 12);
            this.groupBGO.Name = "groupBGO";
            this.groupBGO.Size = new System.Drawing.Size(271, 518);
            this.groupBGO.TabIndex = 23;
            this.groupBGO.TabStop = false;
            this.groupBGO.Text = "Başvuru Gönderen Öğrenciler";
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 19;
            this.listBox1.Location = new System.Drawing.Point(3, 23);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(265, 492);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // groupİslemler
            // 
            this.groupİslemler.Controls.Add(this.button3);
            this.groupİslemler.Controls.Add(this.button2);
            this.groupİslemler.Controls.Add(this.button1);
            this.groupİslemler.Location = new System.Drawing.Point(859, 12);
            this.groupİslemler.Name = "groupİslemler";
            this.groupİslemler.Size = new System.Drawing.Size(217, 518);
            this.groupİslemler.TabIndex = 25;
            this.groupİslemler.TabStop = false;
            this.groupİslemler.Text = "Başvuru İşlemler";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(17, 81);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(184, 35);
            this.button2.TabIndex = 13;
            this.button2.Text = "Reddet";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(17, 33);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(184, 35);
            this.button1.TabIndex = 12;
            this.button1.Text = "Kabul et";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(17, 131);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(184, 35);
            this.button3.TabIndex = 14;
            this.button3.Text = "Başvuru Detay";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // FrmMudureGelenBasvurular
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkBlue;
            this.ClientSize = new System.Drawing.Size(1089, 539);
            this.Controls.Add(this.groupİslemler);
            this.Controls.Add(this.groupMenu);
            this.Controls.Add(this.groupBGO);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmMudureGelenBasvurular";
            this.Text = "Başvurular";
            this.Load += new System.EventHandler(this.FrmMudureGelenBasvurular_Load);
            this.groupMenu.ResumeLayout(false);
            this.groupAciklama.ResumeLayout(false);
            this.groupOgrDetay.ResumeLayout(false);
            this.groupOgrDetay.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBGO.ResumeLayout(false);
            this.groupİslemler.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupMenu;
        private System.Windows.Forms.GroupBox groupAciklama;
        private System.Windows.Forms.RichTextBox richAciklama;
        private System.Windows.Forms.GroupBox groupOgrDetay;
        private System.Windows.Forms.Button btnOgrtckimliknogosteraciklama;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtOgretmenDers;
        private System.Windows.Forms.MaskedTextBox maskOgrenciTC;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RadioButton radioKadin;
        private System.Windows.Forms.RadioButton radioErkek;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtOgrenciYas;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtOgrenciAdSoyad;
        private System.Windows.Forms.GroupBox groupBGO;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioOgretmen;
        private System.Windows.Forms.RadioButton radioMdrYardimcisi;
        private System.Windows.Forms.RadioButton radioOgrenci;
        private System.Windows.Forms.GroupBox groupİslemler;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
    }
}