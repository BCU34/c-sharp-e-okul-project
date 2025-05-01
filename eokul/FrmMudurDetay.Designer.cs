namespace eokul
{
    partial class FrmMudurDetay
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.lblOkulAdi = new System.Windows.Forms.Label();
            this.btnmudurprofil = new System.Windows.Forms.Button();
            this.profilfoto = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.profilFotoğrafıDeğiştirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.profilFotoğrafıDeğiştirToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.profilFotoğrafıKaldırToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblMuduradsoyad = new System.Windows.Forms.Label();
            this.btnHakkimda = new System.Windows.Forms.Button();
            this.btnBasvuru = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblZaman = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblppdegistirme = new System.Windows.Forms.Label();
            this.btnGeri = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            this.Ogrt_cinsiyet = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.profilfoto.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Ogrt_cinsiyet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblOkulAdi
            // 
            this.lblOkulAdi.AutoSize = true;
            this.lblOkulAdi.BackColor = System.Drawing.Color.DodgerBlue;
            this.lblOkulAdi.Font = new System.Drawing.Font("Segoe Script", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOkulAdi.ForeColor = System.Drawing.Color.Black;
            this.lblOkulAdi.Location = new System.Drawing.Point(12, 9);
            this.lblOkulAdi.Name = "lblOkulAdi";
            this.lblOkulAdi.Size = new System.Drawing.Size(866, 53);
            this.lblOkulAdi.TabIndex = 5;
            this.lblOkulAdi.Text = "PROFİLO MESLEKİ VE TEKNİK ANADOLU LİSESİ";
            // 
            // btnmudurprofil
            // 
            this.btnmudurprofil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnmudurprofil.ContextMenuStrip = this.profilfoto;
            this.btnmudurprofil.Location = new System.Drawing.Point(4, 6);
            this.btnmudurprofil.Name = "btnmudurprofil";
            this.btnmudurprofil.Size = new System.Drawing.Size(35, 34);
            this.btnmudurprofil.TabIndex = 0;
            this.btnmudurprofil.Text = "N";
            this.btnmudurprofil.UseVisualStyleBackColor = true;
            this.btnmudurprofil.Click += new System.EventHandler(this.btnmudurprofil_Click);
            // 
            // profilfoto
            // 
            this.profilfoto.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.profilFotoğrafıDeğiştirToolStripMenuItem});
            this.profilfoto.Name = "profilfoto";
            this.profilfoto.Size = new System.Drawing.Size(197, 26);
            // 
            // profilFotoğrafıDeğiştirToolStripMenuItem
            // 
            this.profilFotoğrafıDeğiştirToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.profilFotoğrafıDeğiştirToolStripMenuItem1,
            this.profilFotoğrafıKaldırToolStripMenuItem});
            this.profilFotoğrafıDeğiştirToolStripMenuItem.Name = "profilFotoğrafıDeğiştirToolStripMenuItem";
            this.profilFotoğrafıDeğiştirToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.profilFotoğrafıDeğiştirToolStripMenuItem.Text = "Profil Fotoğrafı Değiştir";
            // 
            // profilFotoğrafıDeğiştirToolStripMenuItem1
            // 
            this.profilFotoğrafıDeğiştirToolStripMenuItem1.Name = "profilFotoğrafıDeğiştirToolStripMenuItem1";
            this.profilFotoğrafıDeğiştirToolStripMenuItem1.Size = new System.Drawing.Size(196, 22);
            this.profilFotoğrafıDeğiştirToolStripMenuItem1.Text = "Profil Fotoğrafı Değiştir";
            this.profilFotoğrafıDeğiştirToolStripMenuItem1.Click += new System.EventHandler(this.profilFotoğrafıDeğiştirToolStripMenuItem1_Click);
            // 
            // profilFotoğrafıKaldırToolStripMenuItem
            // 
            this.profilFotoğrafıKaldırToolStripMenuItem.Name = "profilFotoğrafıKaldırToolStripMenuItem";
            this.profilFotoğrafıKaldırToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.profilFotoğrafıKaldırToolStripMenuItem.Text = "Profil Fotoğrafı Kaldır";
            this.profilFotoğrafıKaldırToolStripMenuItem.Click += new System.EventHandler(this.profilFotoğrafıKaldırToolStripMenuItem_Click);
            // 
            // lblMuduradsoyad
            // 
            this.lblMuduradsoyad.AutoSize = true;
            this.lblMuduradsoyad.BackColor = System.Drawing.Color.White;
            this.lblMuduradsoyad.Location = new System.Drawing.Point(44, 14);
            this.lblMuduradsoyad.Name = "lblMuduradsoyad";
            this.lblMuduradsoyad.Size = new System.Drawing.Size(61, 19);
            this.lblMuduradsoyad.TabIndex = 7;
            this.lblMuduradsoyad.Text = "null null";
            // 
            // btnHakkimda
            // 
            this.btnHakkimda.Location = new System.Drawing.Point(884, 63);
            this.btnHakkimda.Name = "btnHakkimda";
            this.btnHakkimda.Size = new System.Drawing.Size(95, 28);
            this.btnHakkimda.TabIndex = 1;
            this.btnHakkimda.Text = "Hakkımda";
            this.btnHakkimda.UseVisualStyleBackColor = true;
            this.btnHakkimda.Visible = false;
            this.btnHakkimda.Click += new System.EventHandler(this.btnHakkimda_Click);
            // 
            // btnBasvuru
            // 
            this.btnBasvuru.Location = new System.Drawing.Point(884, 97);
            this.btnBasvuru.Name = "btnBasvuru";
            this.btnBasvuru.Size = new System.Drawing.Size(95, 28);
            this.btnBasvuru.TabIndex = 2;
            this.btnBasvuru.Text = "Başvurular";
            this.btnBasvuru.UseVisualStyleBackColor = true;
            this.btnBasvuru.Visible = false;
            this.btnBasvuru.Click += new System.EventHandler(this.btnBasvuru_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.btnmudurprofil);
            this.panel1.Controls.Add(this.lblMuduradsoyad);
            this.panel1.Location = new System.Drawing.Point(884, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(120, 48);
            this.panel1.TabIndex = 11;
            // 
            // lblZaman
            // 
            this.lblZaman.AutoSize = true;
            this.lblZaman.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblZaman.ForeColor = System.Drawing.Color.White;
            this.lblZaman.Location = new System.Drawing.Point(82, 611);
            this.lblZaman.Name = "lblZaman";
            this.lblZaman.Size = new System.Drawing.Size(53, 19);
            this.lblZaman.TabIndex = 24;
            this.lblZaman.Text = "zaman";
            this.lblZaman.Click += new System.EventHandler(this.lblZaman_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblppdegistirme
            // 
            this.lblppdegistirme.AutoSize = true;
            this.lblppdegistirme.ForeColor = System.Drawing.Color.Red;
            this.lblppdegistirme.Location = new System.Drawing.Point(17, 70);
            this.lblppdegistirme.Name = "lblppdegistirme";
            this.lblppdegistirme.Size = new System.Drawing.Size(603, 19);
            this.lblppdegistirme.TabIndex = 25;
            this.lblppdegistirme.Text = "NOT: Fotoğrafınızın konumunu değiştirirseniz veya silerseniz profil fotoğrafınız " +
    "kaldırılacaktır.";
            this.lblppdegistirme.Visible = false;
            // 
            // btnGeri
            // 
            this.btnGeri.BackgroundImage = global::eokul.Properties.Resources.geri;
            this.btnGeri.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnGeri.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGeri.ForeColor = System.Drawing.Color.Black;
            this.btnGeri.Location = new System.Drawing.Point(12, 588);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(64, 64);
            this.btnGeri.TabIndex = 4;
            this.btnGeri.UseVisualStyleBackColor = true;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // btnCikis
            // 
            this.btnCikis.BackColor = System.Drawing.Color.Red;
            this.btnCikis.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCikis.ForeColor = System.Drawing.Color.Black;
            this.btnCikis.Location = new System.Drawing.Point(884, 131);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(95, 28);
            this.btnCikis.TabIndex = 3;
            this.btnCikis.Text = "ÇIKIŞ";
            this.btnCikis.UseVisualStyleBackColor = false;
            this.btnCikis.Visible = false;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // Ogrt_cinsiyet
            // 
            chartArea3.Name = "ChartArea1";
            this.Ogrt_cinsiyet.ChartAreas.Add(chartArea3);
            this.Ogrt_cinsiyet.Dock = System.Windows.Forms.DockStyle.Fill;
            legend3.Name = "Legend1";
            this.Ogrt_cinsiyet.Legends.Add(legend3);
            this.Ogrt_cinsiyet.Location = new System.Drawing.Point(3, 23);
            this.Ogrt_cinsiyet.Name = "Ogrt_cinsiyet";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series3.Legend = "Legend1";
            series3.Name = "Cinsiyet";
            this.Ogrt_cinsiyet.Series.Add(series3);
            this.Ogrt_cinsiyet.Size = new System.Drawing.Size(633, 303);
            this.Ogrt_cinsiyet.TabIndex = 26;
            this.Ogrt_cinsiyet.Text = "chart1";
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox1.Controls.Add(this.Ogrt_cinsiyet);
            this.groupBox1.Location = new System.Drawing.Point(138, 122);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(639, 329);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Öğretmenlerin Cinsiyetine Göre Dağılışı";
            // 
            // FrmMudurDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1280, 664);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.lblppdegistirme);
            this.Controls.Add(this.lblZaman);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnBasvuru);
            this.Controls.Add(this.btnHakkimda);
            this.Controls.Add(this.lblOkulAdi);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMudurDetay";
            this.Text = "FrmMudurDetay";
            this.Load += new System.EventHandler(this.FrmMudurDetay_Load);
            this.profilfoto.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Ogrt_cinsiyet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOkulAdi;
        private System.Windows.Forms.Button btnmudurprofil;
        private System.Windows.Forms.Label lblMuduradsoyad;
        private System.Windows.Forms.Button btnHakkimda;
        private System.Windows.Forms.Button btnBasvuru;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnGeri;
        private System.Windows.Forms.ContextMenuStrip profilfoto;
        private System.Windows.Forms.ToolStripMenuItem profilFotoğrafıDeğiştirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem profilFotoğrafıDeğiştirToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem profilFotoğrafıKaldırToolStripMenuItem;
        private System.Windows.Forms.Label lblZaman;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblppdegistirme;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.DataVisualization.Charting.Chart Ogrt_cinsiyet;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}