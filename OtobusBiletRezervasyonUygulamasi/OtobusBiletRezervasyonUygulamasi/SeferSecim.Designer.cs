
namespace OtobusBiletRezervasyonUygulamasi
{
    partial class SeferSecim
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpSeferTarihi = new System.Windows.Forms.DateTimePicker();
            this.cmbVarıs = new System.Windows.Forms.ComboBox();
            this.cmbKalkıs = new System.Windows.Forms.ComboBox();
            this.BtnSaat12 = new System.Windows.Forms.Button();
            this.BtnSaat14 = new System.Windows.Forms.Button();
            this.BtnSaat10 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnSeferSec = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(15, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kalkış Noktası :";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.dtpSeferTarihi);
            this.groupBox1.Controls.Add(this.cmbVarıs);
            this.groupBox1.Controls.Add(this.cmbKalkıs);
            this.groupBox1.Controls.Add(this.BtnSaat12);
            this.groupBox1.Controls.Add(this.BtnSaat14);
            this.groupBox1.Controls.Add(this.BtnSaat10);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(76, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(334, 222);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Güzergah";
            // 
            // dtpSeferTarihi
            // 
            this.dtpSeferTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpSeferTarihi.Location = new System.Drawing.Point(137, 120);
            this.dtpSeferTarihi.Name = "dtpSeferTarihi";
            this.dtpSeferTarihi.Size = new System.Drawing.Size(165, 22);
            this.dtpSeferTarihi.TabIndex = 9;
            // 
            // cmbVarıs
            // 
            this.cmbVarıs.FormattingEnabled = true;
            this.cmbVarıs.Location = new System.Drawing.Point(137, 77);
            this.cmbVarıs.Name = "cmbVarıs";
            this.cmbVarıs.Size = new System.Drawing.Size(165, 24);
            this.cmbVarıs.TabIndex = 8;
            // 
            // cmbKalkıs
            // 
            this.cmbKalkıs.FormattingEnabled = true;
            this.cmbKalkıs.Location = new System.Drawing.Point(137, 36);
            this.cmbKalkıs.Name = "cmbKalkıs";
            this.cmbKalkıs.Size = new System.Drawing.Size(165, 24);
            this.cmbKalkıs.TabIndex = 7;
            // 
            // BtnSaat12
            // 
            this.BtnSaat12.Location = new System.Drawing.Point(194, 159);
            this.BtnSaat12.Name = "BtnSaat12";
            this.BtnSaat12.Size = new System.Drawing.Size(51, 42);
            this.BtnSaat12.TabIndex = 5;
            this.BtnSaat12.Text = "12";
            this.BtnSaat12.UseVisualStyleBackColor = true;
            this.BtnSaat12.Click += new System.EventHandler(this.SaatSecClick);
            // 
            // BtnSaat14
            // 
            this.BtnSaat14.Location = new System.Drawing.Point(251, 159);
            this.BtnSaat14.Name = "BtnSaat14";
            this.BtnSaat14.Size = new System.Drawing.Size(51, 42);
            this.BtnSaat14.TabIndex = 6;
            this.BtnSaat14.Text = "14";
            this.BtnSaat14.UseVisualStyleBackColor = true;
            this.BtnSaat14.Click += new System.EventHandler(this.SaatSecClick);
            // 
            // BtnSaat10
            // 
            this.BtnSaat10.Location = new System.Drawing.Point(137, 159);
            this.BtnSaat10.Name = "BtnSaat10";
            this.BtnSaat10.Size = new System.Drawing.Size(51, 42);
            this.BtnSaat10.TabIndex = 4;
            this.BtnSaat10.Text = "10";
            this.BtnSaat10.UseVisualStyleBackColor = true;
            this.BtnSaat10.Click += new System.EventHandler(this.SaatSecClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(74, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Saat :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(71, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tarih :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Varış Noktası :";
            // 
            // BtnSeferSec
            // 
            this.BtnSeferSec.Location = new System.Drawing.Point(196, 285);
            this.BtnSeferSec.Name = "BtnSeferSec";
            this.BtnSeferSec.Size = new System.Drawing.Size(107, 32);
            this.BtnSeferSec.TabIndex = 2;
            this.BtnSeferSec.Text = "Sefer Ara";
            this.BtnSeferSec.UseVisualStyleBackColor = true;
            this.BtnSeferSec.Click += new System.EventHandler(this.BtnSeferSec_Click);
            // 
            // SeferSecim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(500, 355);
            this.Controls.Add(this.BtnSeferSec);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SeferSecim";
            this.Text = "Seferler";
            this.Load += new System.EventHandler(this.SeferSecim_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtpSeferTarihi;
        private System.Windows.Forms.ComboBox cmbVarıs;
        private System.Windows.Forms.ComboBox cmbKalkıs;
        private System.Windows.Forms.Button BtnSaat12;
        private System.Windows.Forms.Button BtnSaat14;
        private System.Windows.Forms.Button BtnSaat10;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnSeferSec;
    }
}

