
namespace OtobusBiletRezervasyonUygulamasi
{
    partial class Giris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Giris));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnAdminGiris = new System.Windows.Forms.Button();
            this.BtnYolcuGiris = new System.Windows.Forms.Button();
            this.gbAdminGiris = new System.Windows.Forms.GroupBox();
            this.BtnGiris = new System.Windows.Forms.Button();
            this.txtAdmSifre = new System.Windows.Forms.TextBox();
            this.txtAdmKullanıcı = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gbAdminGiris.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(244, 13);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(332, 210);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // BtnAdminGiris
            // 
            this.BtnAdminGiris.BackColor = System.Drawing.Color.DarkGreen;
            this.BtnAdminGiris.Location = new System.Drawing.Point(288, 263);
            this.BtnAdminGiris.Name = "BtnAdminGiris";
            this.BtnAdminGiris.Size = new System.Drawing.Size(114, 80);
            this.BtnAdminGiris.TabIndex = 1;
            this.BtnAdminGiris.Text = "Admin Girişi";
            this.BtnAdminGiris.UseVisualStyleBackColor = false;
            this.BtnAdminGiris.Click += new System.EventHandler(this.BtnAdminGiris_Click);
            // 
            // BtnYolcuGiris
            // 
            this.BtnYolcuGiris.BackColor = System.Drawing.Color.Green;
            this.BtnYolcuGiris.Location = new System.Drawing.Point(446, 263);
            this.BtnYolcuGiris.Name = "BtnYolcuGiris";
            this.BtnYolcuGiris.Size = new System.Drawing.Size(114, 80);
            this.BtnYolcuGiris.TabIndex = 2;
            this.BtnYolcuGiris.Text = "Bilet Al";
            this.BtnYolcuGiris.UseVisualStyleBackColor = false;
            this.BtnYolcuGiris.Click += new System.EventHandler(this.BtnYolcuGiris_Click);
            // 
            // gbAdminGiris
            // 
            this.gbAdminGiris.Controls.Add(this.BtnGiris);
            this.gbAdminGiris.Controls.Add(this.txtAdmSifre);
            this.gbAdminGiris.Controls.Add(this.txtAdmKullanıcı);
            this.gbAdminGiris.Controls.Add(this.label2);
            this.gbAdminGiris.Controls.Add(this.label1);
            this.gbAdminGiris.Location = new System.Drawing.Point(26, 227);
            this.gbAdminGiris.Name = "gbAdminGiris";
            this.gbAdminGiris.Size = new System.Drawing.Size(225, 217);
            this.gbAdminGiris.TabIndex = 3;
            this.gbAdminGiris.TabStop = false;
            this.gbAdminGiris.Text = "Admin Girişi";
            this.gbAdminGiris.Visible = false;
            // 
            // BtnGiris
            // 
            this.BtnGiris.BackColor = System.Drawing.Color.ForestGreen;
            this.BtnGiris.ForeColor = System.Drawing.Color.Black;
            this.BtnGiris.Location = new System.Drawing.Point(110, 135);
            this.BtnGiris.Name = "BtnGiris";
            this.BtnGiris.Size = new System.Drawing.Size(87, 30);
            this.BtnGiris.TabIndex = 4;
            this.BtnGiris.Text = "Giriş Yap";
            this.BtnGiris.UseVisualStyleBackColor = false;
            this.BtnGiris.Click += new System.EventHandler(this.BtnGiris_Click);
            // 
            // txtAdmSifre
            // 
            this.txtAdmSifre.Location = new System.Drawing.Point(110, 93);
            this.txtAdmSifre.Name = "txtAdmSifre";
            this.txtAdmSifre.PasswordChar = '*';
            this.txtAdmSifre.Size = new System.Drawing.Size(100, 22);
            this.txtAdmSifre.TabIndex = 3;
            // 
            // txtAdmKullanıcı
            // 
            this.txtAdmKullanıcı.Location = new System.Drawing.Point(110, 59);
            this.txtAdmKullanıcı.Name = "txtAdmKullanıcı";
            this.txtAdmKullanıcı.Size = new System.Drawing.Size(100, 22);
            this.txtAdmKullanıcı.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Şifre :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Adı :";
            // 
            // Giris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(791, 456);
            this.Controls.Add(this.gbAdminGiris);
            this.Controls.Add(this.BtnYolcuGiris);
            this.Controls.Add(this.BtnAdminGiris);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Giris";
            this.Text = "Giris";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gbAdminGiris.ResumeLayout(false);
            this.gbAdminGiris.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BtnAdminGiris;
        private System.Windows.Forms.Button BtnYolcuGiris;
        private System.Windows.Forms.GroupBox gbAdminGiris;
        private System.Windows.Forms.TextBox txtAdmSifre;
        private System.Windows.Forms.TextBox txtAdmKullanıcı;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnGiris;
    }
}