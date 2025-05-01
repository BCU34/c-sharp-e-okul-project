namespace eokul
{
    partial class FrmMudurHakkinda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMudurHakkinda));
            this.groupupdateislem = new System.Windows.Forms.GroupBox();
            this.btnbilgilendirmee = new System.Windows.Forms.Button();
            this.lblbilgi = new System.Windows.Forms.Label();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.groupbilgiislem = new System.Windows.Forms.GroupBox();
            this.lblSoyad = new System.Windows.Forms.Label();
            this.txtGSoyad = new System.Windows.Forms.TextBox();
            this.btnGostersifre = new System.Windows.Forms.Button();
            this.txtsifre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDT = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtyas = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.masktc = new System.Windows.Forms.MaskedTextBox();
            this.txtadsoyad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGostertc = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupupdateislem.SuspendLayout();
            this.groupbilgiislem.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupupdateislem
            // 
            this.groupupdateislem.Controls.Add(this.btnbilgilendirmee);
            this.groupupdateislem.Controls.Add(this.lblbilgi);
            this.groupupdateislem.Controls.Add(this.btnGuncelle);
            this.groupupdateislem.Location = new System.Drawing.Point(474, 12);
            this.groupupdateislem.Name = "groupupdateislem";
            this.groupupdateislem.Size = new System.Drawing.Size(233, 264);
            this.groupupdateislem.TabIndex = 18;
            this.groupupdateislem.TabStop = false;
            this.groupupdateislem.Text = "İşlem";
            this.groupupdateislem.Visible = false;
            // 
            // btnbilgilendirmee
            // 
            this.btnbilgilendirmee.BackColor = System.Drawing.Color.White;
            this.btnbilgilendirmee.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnbilgilendirmee.BackgroundImage")));
            this.btnbilgilendirmee.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnbilgilendirmee.Location = new System.Drawing.Point(155, 35);
            this.btnbilgilendirmee.Name = "btnbilgilendirmee";
            this.btnbilgilendirmee.Size = new System.Drawing.Size(44, 41);
            this.btnbilgilendirmee.TabIndex = 9;
            this.btnbilgilendirmee.UseVisualStyleBackColor = false;
            this.btnbilgilendirmee.Visible = false;
            this.btnbilgilendirmee.Click += new System.EventHandler(this.btnbilgilendirmee_Click);
            // 
            // lblbilgi
            // 
            this.lblbilgi.AutoSize = true;
            this.lblbilgi.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblbilgi.Location = new System.Drawing.Point(6, 94);
            this.lblbilgi.Name = "lblbilgi";
            this.lblbilgi.Size = new System.Drawing.Size(211, 60);
            this.lblbilgi.TabIndex = 1;
            this.lblbilgi.Text = "Bilgilerinizi değiştirmek için\r\nönce bir kere güncelle yazan\r\nbutona tıklayıp, bi" +
    "lgilerinizi değiştirip\r\ntekrar butona tıklayınız\r\n";
            this.lblbilgi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblbilgi.Visible = false;
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(55, 35);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(94, 41);
            this.btnGuncelle.TabIndex = 8;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Visible = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // groupbilgiislem
            // 
            this.groupbilgiislem.Controls.Add(this.lblSoyad);
            this.groupbilgiislem.Controls.Add(this.txtGSoyad);
            this.groupbilgiislem.Controls.Add(this.btnGostersifre);
            this.groupbilgiislem.Controls.Add(this.txtsifre);
            this.groupbilgiislem.Controls.Add(this.label5);
            this.groupbilgiislem.Controls.Add(this.txtDT);
            this.groupbilgiislem.Controls.Add(this.label4);
            this.groupbilgiislem.Controls.Add(this.txtyas);
            this.groupbilgiislem.Controls.Add(this.label3);
            this.groupbilgiislem.Controls.Add(this.masktc);
            this.groupbilgiislem.Controls.Add(this.txtadsoyad);
            this.groupbilgiislem.Controls.Add(this.label2);
            this.groupbilgiislem.Controls.Add(this.btnGostertc);
            this.groupbilgiislem.Controls.Add(this.label1);
            this.groupbilgiislem.Location = new System.Drawing.Point(12, 12);
            this.groupbilgiislem.Name = "groupbilgiislem";
            this.groupbilgiislem.Size = new System.Drawing.Size(444, 264);
            this.groupbilgiislem.TabIndex = 17;
            this.groupbilgiislem.TabStop = false;
            this.groupbilgiislem.Text = "Bilgiler";
            this.groupbilgiislem.Visible = false;
            // 
            // lblSoyad
            // 
            this.lblSoyad.AutoSize = true;
            this.lblSoyad.Location = new System.Drawing.Point(75, 119);
            this.lblSoyad.Name = "lblSoyad";
            this.lblSoyad.Size = new System.Drawing.Size(51, 19);
            this.lblSoyad.TabIndex = 14;
            this.lblSoyad.Text = "Soyad:";
            this.lblSoyad.Visible = false;
            // 
            // txtGSoyad
            // 
            this.txtGSoyad.Location = new System.Drawing.Point(132, 116);
            this.txtGSoyad.Name = "txtGSoyad";
            this.txtGSoyad.Size = new System.Drawing.Size(268, 27);
            this.txtGSoyad.TabIndex = 4;
            this.txtGSoyad.Text = "null";
            this.txtGSoyad.Visible = false;
            // 
            // btnGostersifre
            // 
            this.btnGostersifre.BackgroundImage = global::eokul.Properties.Resources.hide;
            this.btnGostersifre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnGostersifre.Location = new System.Drawing.Point(374, 184);
            this.btnGostersifre.Name = "btnGostersifre";
            this.btnGostersifre.Size = new System.Drawing.Size(26, 26);
            this.btnGostersifre.TabIndex = 7;
            this.btnGostersifre.UseVisualStyleBackColor = true;
            this.btnGostersifre.Visible = false;
            this.btnGostersifre.Click += new System.EventHandler(this.btnGostersifre_Click);
            // 
            // txtsifre
            // 
            this.txtsifre.Enabled = false;
            this.txtsifre.Location = new System.Drawing.Point(132, 184);
            this.txtsifre.Name = "txtsifre";
            this.txtsifre.Size = new System.Drawing.Size(236, 27);
            this.txtsifre.TabIndex = 6;
            this.txtsifre.Text = "password123";
            this.txtsifre.UseSystemPasswordChar = true;
            this.txtsifre.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(84, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 19);
            this.label5.TabIndex = 10;
            this.label5.Text = "Şifre:";
            this.label5.Visible = false;
            // 
            // txtDT
            // 
            this.txtDT.Enabled = false;
            this.txtDT.Location = new System.Drawing.Point(132, 146);
            this.txtDT.Name = "txtDT";
            this.txtDT.Size = new System.Drawing.Size(100, 27);
            this.txtDT.TabIndex = 5;
            this.txtDT.Text = "00.00.0000";
            this.txtDT.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 19);
            this.label4.TabIndex = 8;
            this.label4.Text = "Doğum Tarihi:";
            this.label4.Visible = false;
            // 
            // txtyas
            // 
            this.txtyas.Enabled = false;
            this.txtyas.Location = new System.Drawing.Point(132, 111);
            this.txtyas.Name = "txtyas";
            this.txtyas.Size = new System.Drawing.Size(100, 27);
            this.txtyas.TabIndex = 3;
            this.txtyas.Text = "00";
            this.txtyas.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(92, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "Yaş:";
            // 
            // masktc
            // 
            this.masktc.Enabled = false;
            this.masktc.Location = new System.Drawing.Point(132, 32);
            this.masktc.Mask = "00000000000";
            this.masktc.Name = "masktc";
            this.masktc.Size = new System.Drawing.Size(120, 27);
            this.masktc.TabIndex = 0;
            this.masktc.Text = "00000000000";
            this.masktc.UseSystemPasswordChar = true;
            this.masktc.ValidatingType = typeof(int);
            this.masktc.Visible = false;
            // 
            // txtadsoyad
            // 
            this.txtadsoyad.Enabled = false;
            this.txtadsoyad.Location = new System.Drawing.Point(132, 72);
            this.txtadsoyad.Name = "txtadsoyad";
            this.txtadsoyad.Size = new System.Drawing.Size(268, 27);
            this.txtadsoyad.TabIndex = 2;
            this.txtadsoyad.Text = "null null";
            this.txtadsoyad.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ad Soyad:";
            this.label2.Visible = false;
            // 
            // btnGostertc
            // 
            this.btnGostertc.BackgroundImage = global::eokul.Properties.Resources.hide;
            this.btnGostertc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnGostertc.Location = new System.Drawing.Point(258, 32);
            this.btnGostertc.Name = "btnGostertc";
            this.btnGostertc.Size = new System.Drawing.Size(26, 26);
            this.btnGostertc.TabIndex = 1;
            this.btnGostertc.UseVisualStyleBackColor = true;
            this.btnGostertc.Visible = false;
            this.btnGostertc.Click += new System.EventHandler(this.btnGostertc_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "TC KİMLİK NO:";
            this.label1.Visible = false;
            // 
            // FrmMudurHakkinda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkBlue;
            this.ClientSize = new System.Drawing.Size(717, 288);
            this.Controls.Add(this.groupupdateislem);
            this.Controls.Add(this.groupbilgiislem);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmMudurHakkinda";
            this.ShowIcon = false;
            this.Text = "Hakkımda";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMudurHakkinda_FormClosing);
            this.Load += new System.EventHandler(this.FrmMudurHakkinda_Load);
            this.groupupdateislem.ResumeLayout(false);
            this.groupupdateislem.PerformLayout();
            this.groupbilgiislem.ResumeLayout(false);
            this.groupbilgiislem.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupupdateislem;
        private System.Windows.Forms.Button btnbilgilendirmee;
        private System.Windows.Forms.Label lblbilgi;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.GroupBox groupbilgiislem;
        private System.Windows.Forms.Label lblSoyad;
        private System.Windows.Forms.TextBox txtGSoyad;
        private System.Windows.Forms.Button btnGostersifre;
        private System.Windows.Forms.TextBox txtsifre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtyas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox masktc;
        private System.Windows.Forms.TextBox txtadsoyad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGostertc;
        private System.Windows.Forms.Label label1;
    }
}