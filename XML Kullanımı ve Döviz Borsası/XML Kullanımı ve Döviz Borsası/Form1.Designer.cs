namespace XML_Kullanımı_ve_Döviz_Borsası
{
    partial class Form1
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LblDolarAlış = new System.Windows.Forms.Label();
            this.LblDolarSatış = new System.Windows.Forms.Label();
            this.LblEuroAlış = new System.Windows.Forms.Label();
            this.LblEuroSatış = new System.Windows.Forms.Label();
            this.BtnDolarAl = new System.Windows.Forms.Button();
            this.BtnDolarSat = new System.Windows.Forms.Button();
            this.BtnEuroAl = new System.Windows.Forms.Button();
            this.BtnEuroSat = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button6 = new System.Windows.Forms.Button();
            this.BtnSatış = new System.Windows.Forms.Button();
            this.TxtKalan = new System.Windows.Forms.TextBox();
            this.TxtTutar = new System.Windows.Forms.TextBox();
            this.TxtMiktar = new System.Windows.Forms.TextBox();
            this.TxtKur = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dolar Alış:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Dolar Satış:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Euro Alış:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "Euro Satış:";
            // 
            // LblDolarAlış
            // 
            this.LblDolarAlış.AutoSize = true;
            this.LblDolarAlış.Location = new System.Drawing.Point(185, 48);
            this.LblDolarAlış.Name = "LblDolarAlış";
            this.LblDolarAlış.Size = new System.Drawing.Size(20, 22);
            this.LblDolarAlış.TabIndex = 4;
            this.LblDolarAlış.Text = "0";
            // 
            // LblDolarSatış
            // 
            this.LblDolarSatış.AutoSize = true;
            this.LblDolarSatış.Location = new System.Drawing.Point(185, 85);
            this.LblDolarSatış.Name = "LblDolarSatış";
            this.LblDolarSatış.Size = new System.Drawing.Size(20, 22);
            this.LblDolarSatış.TabIndex = 5;
            this.LblDolarSatış.Text = "0";
            // 
            // LblEuroAlış
            // 
            this.LblEuroAlış.AutoSize = true;
            this.LblEuroAlış.Location = new System.Drawing.Point(185, 127);
            this.LblEuroAlış.Name = "LblEuroAlış";
            this.LblEuroAlış.Size = new System.Drawing.Size(20, 22);
            this.LblEuroAlış.TabIndex = 6;
            this.LblEuroAlış.Text = "0";
            // 
            // LblEuroSatış
            // 
            this.LblEuroSatış.AutoSize = true;
            this.LblEuroSatış.Location = new System.Drawing.Point(185, 167);
            this.LblEuroSatış.Name = "LblEuroSatış";
            this.LblEuroSatış.Size = new System.Drawing.Size(20, 22);
            this.LblEuroSatış.TabIndex = 7;
            this.LblEuroSatış.Text = "0";
            // 
            // BtnDolarAl
            // 
            this.BtnDolarAl.Location = new System.Drawing.Point(309, 48);
            this.BtnDolarAl.Name = "BtnDolarAl";
            this.BtnDolarAl.Size = new System.Drawing.Size(105, 28);
            this.BtnDolarAl.TabIndex = 8;
            this.BtnDolarAl.Text = "Dolar Al";
            this.BtnDolarAl.UseVisualStyleBackColor = true;
            this.BtnDolarAl.Click += new System.EventHandler(this.BtnDolarAl_Click);
            // 
            // BtnDolarSat
            // 
            this.BtnDolarSat.Location = new System.Drawing.Point(309, 92);
            this.BtnDolarSat.Name = "BtnDolarSat";
            this.BtnDolarSat.Size = new System.Drawing.Size(105, 29);
            this.BtnDolarSat.TabIndex = 9;
            this.BtnDolarSat.Text = "Dolar Sat";
            this.BtnDolarSat.UseVisualStyleBackColor = true;
            this.BtnDolarSat.Click += new System.EventHandler(this.BtnDolarSat_Click);
            // 
            // BtnEuroAl
            // 
            this.BtnEuroAl.Location = new System.Drawing.Point(309, 127);
            this.BtnEuroAl.Name = "BtnEuroAl";
            this.BtnEuroAl.Size = new System.Drawing.Size(105, 29);
            this.BtnEuroAl.TabIndex = 10;
            this.BtnEuroAl.Text = "Euro Al";
            this.BtnEuroAl.UseVisualStyleBackColor = true;
            // 
            // BtnEuroSat
            // 
            this.BtnEuroSat.Location = new System.Drawing.Point(309, 162);
            this.BtnEuroSat.Name = "BtnEuroSat";
            this.BtnEuroSat.Size = new System.Drawing.Size(105, 28);
            this.BtnEuroSat.TabIndex = 11;
            this.BtnEuroSat.Text = "Euro Sat";
            this.BtnEuroSat.UseVisualStyleBackColor = true;
            this.BtnEuroSat.Click += new System.EventHandler(this.BtnEuroSat_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button6);
            this.groupBox1.Controls.Add(this.BtnSatış);
            this.groupBox1.Controls.Add(this.TxtKalan);
            this.groupBox1.Controls.Add(this.TxtTutar);
            this.groupBox1.Controls.Add(this.TxtMiktar);
            this.groupBox1.Controls.Add(this.TxtKur);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Location = new System.Drawing.Point(465, 196);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(431, 272);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "İşlemler";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(227, 221);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(118, 30);
            this.button6.TabIndex = 13;
            this.button6.Text = "Satış Yap2";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // BtnSatış
            // 
            this.BtnSatış.Location = new System.Drawing.Point(70, 221);
            this.BtnSatış.Name = "BtnSatış";
            this.BtnSatış.Size = new System.Drawing.Size(107, 30);
            this.BtnSatış.TabIndex = 20;
            this.BtnSatış.Text = "Satış Yap";
            this.BtnSatış.UseVisualStyleBackColor = true;
            this.BtnSatış.Click += new System.EventHandler(this.button5_Click);
            // 
            // TxtKalan
            // 
            this.TxtKalan.Location = new System.Drawing.Point(161, 168);
            this.TxtKalan.Name = "TxtKalan";
            this.TxtKalan.Size = new System.Drawing.Size(134, 30);
            this.TxtKalan.TabIndex = 19;
            // 
            // TxtTutar
            // 
            this.TxtTutar.Location = new System.Drawing.Point(161, 126);
            this.TxtTutar.Name = "TxtTutar";
            this.TxtTutar.Size = new System.Drawing.Size(134, 30);
            this.TxtTutar.TabIndex = 18;
            // 
            // TxtMiktar
            // 
            this.TxtMiktar.Location = new System.Drawing.Point(161, 84);
            this.TxtMiktar.Name = "TxtMiktar";
            this.TxtMiktar.Size = new System.Drawing.Size(134, 30);
            this.TxtMiktar.TabIndex = 17;
            // 
            // TxtKur
            // 
            this.TxtKur.Location = new System.Drawing.Point(161, 40);
            this.TxtKur.Name = "TxtKur";
            this.TxtKur.Size = new System.Drawing.Size(134, 30);
            this.TxtKur.TabIndex = 13;
            this.TxtKur.TextChanged += new System.EventHandler(this.TxtKur_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(22, 171);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(63, 22);
            this.label12.TabIndex = 16;
            this.label12.Text = "Kalan:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(23, 126);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 22);
            this.label11.TabIndex = 15;
            this.label11.Text = "Tutar:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(22, 87);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 22);
            this.label10.TabIndex = 14;
            this.label10.Text = "Miktar:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(22, 43);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 22);
            this.label9.TabIndex = 13;
            this.label9.Text = "Kur:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1042, 480);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BtnEuroSat);
            this.Controls.Add(this.BtnEuroAl);
            this.Controls.Add(this.BtnDolarSat);
            this.Controls.Add(this.BtnDolarAl);
            this.Controls.Add(this.LblEuroSatış);
            this.Controls.Add(this.LblEuroAlış);
            this.Controls.Add(this.LblDolarSatış);
            this.Controls.Add(this.LblDolarAlış);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Döviz Bürosu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LblDolarAlış;
        private System.Windows.Forms.Label LblDolarSatış;
        private System.Windows.Forms.Label LblEuroAlış;
        private System.Windows.Forms.Label LblEuroSatış;
        private System.Windows.Forms.Button BtnDolarAl;
        private System.Windows.Forms.Button BtnDolarSat;
        private System.Windows.Forms.Button BtnEuroAl;
        private System.Windows.Forms.Button BtnEuroSat;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button BtnSatış;
        private System.Windows.Forms.TextBox TxtKalan;
        private System.Windows.Forms.TextBox TxtTutar;
        private System.Windows.Forms.TextBox TxtMiktar;
        private System.Windows.Forms.TextBox TxtKur;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
    }
}

