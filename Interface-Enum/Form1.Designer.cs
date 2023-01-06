namespace Interface_Enum
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnYeniUrun = new System.Windows.Forms.Button();
            this.dgUrunListesi = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbUrunDurum = new System.Windows.Forms.ComboBox();
            this.txtFiyat = new System.Windows.Forms.TextBox();
            this.txtUrunAdi = new System.Windows.Forms.TextBox();
            this.txtUrunKodu = new System.Windows.Forms.TextBox();
            this.btnUrunKaydet = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.nmAdet = new System.Windows.Forms.NumericUpDown();
            this.btnSepet = new System.Windows.Forms.Button();
            this.dgSiparisListesi = new System.Windows.Forms.DataGridView();
            this.btnSiparisTamamla = new System.Windows.Forms.Button();
            this.txtTutar = new System.Windows.Forms.TextBox();
            this.txtSUrunAdi = new System.Windows.Forms.TextBox();
            this.txtSUrunKodu = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSiparisKodu = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnDegisiklikKaydet = new System.Windows.Forms.Button();
            this.txtSSiparisKodu = new System.Windows.Forms.TextBox();
            this.cmbSiparisDurum = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgUrunListesi)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmAdet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgSiparisListesi)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightSalmon;
            this.groupBox1.Controls.Add(this.btnYeniUrun);
            this.groupBox1.Controls.Add(this.dgUrunListesi);
            this.groupBox1.Controls.Add(this.cmbUrunDurum);
            this.groupBox1.Controls.Add(this.txtFiyat);
            this.groupBox1.Controls.Add(this.txtUrunAdi);
            this.groupBox1.Controls.Add(this.txtUrunKodu);
            this.groupBox1.Controls.Add(this.btnUrunKaydet);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(460, 646);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "URUN";
            // 
            // btnYeniUrun
            // 
            this.btnYeniUrun.Location = new System.Drawing.Point(25, 180);
            this.btnYeniUrun.Name = "btnYeniUrun";
            this.btnYeniUrun.Size = new System.Drawing.Size(97, 67);
            this.btnYeniUrun.TabIndex = 5;
            this.btnYeniUrun.Text = "Yeni Urun";
            this.btnYeniUrun.UseVisualStyleBackColor = true;
            this.btnYeniUrun.Click += new System.EventHandler(this.btnYeniUrun_Click);
            // 
            // dgUrunListesi
            // 
            this.dgUrunListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgUrunListesi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgUrunListesi.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgUrunListesi.Location = new System.Drawing.Point(3, 273);
            this.dgUrunListesi.Name = "dgUrunListesi";
            this.dgUrunListesi.Size = new System.Drawing.Size(454, 370);
            this.dgUrunListesi.TabIndex = 4;
            this.dgUrunListesi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgUrunListesi_CellClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Urun Kodu";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Urun Adı";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Fiyat";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Durum";
            this.Column4.Name = "Column4";
            // 
            // cmbUrunDurum
            // 
            this.cmbUrunDurum.FormattingEnabled = true;
            this.cmbUrunDurum.Location = new System.Drawing.Point(128, 141);
            this.cmbUrunDurum.Name = "cmbUrunDurum";
            this.cmbUrunDurum.Size = new System.Drawing.Size(238, 33);
            this.cmbUrunDurum.TabIndex = 3;
            // 
            // txtFiyat
            // 
            this.txtFiyat.Location = new System.Drawing.Point(128, 104);
            this.txtFiyat.Name = "txtFiyat";
            this.txtFiyat.Size = new System.Drawing.Size(100, 31);
            this.txtFiyat.TabIndex = 2;
            // 
            // txtUrunAdi
            // 
            this.txtUrunAdi.Location = new System.Drawing.Point(128, 67);
            this.txtUrunAdi.Name = "txtUrunAdi";
            this.txtUrunAdi.Size = new System.Drawing.Size(238, 31);
            this.txtUrunAdi.TabIndex = 2;
            // 
            // txtUrunKodu
            // 
            this.txtUrunKodu.Enabled = false;
            this.txtUrunKodu.Location = new System.Drawing.Point(128, 30);
            this.txtUrunKodu.Name = "txtUrunKodu";
            this.txtUrunKodu.Size = new System.Drawing.Size(238, 31);
            this.txtUrunKodu.TabIndex = 2;
            // 
            // btnUrunKaydet
            // 
            this.btnUrunKaydet.Location = new System.Drawing.Point(128, 180);
            this.btnUrunKaydet.Name = "btnUrunKaydet";
            this.btnUrunKaydet.Size = new System.Drawing.Size(151, 67);
            this.btnUrunKaydet.TabIndex = 1;
            this.btnUrunKaydet.Text = "Ürün Kaydet";
            this.btnUrunKaydet.UseVisualStyleBackColor = true;
            this.btnUrunKaydet.Click += new System.EventHandler(this.btnUrunKaydet_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(6, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Ürün Durumu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(6, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ürün Fiyat";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(6, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ürün Adı";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(6, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ürün Kodu";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.groupBox2.Controls.Add(this.nmAdet);
            this.groupBox2.Controls.Add(this.btnSepet);
            this.groupBox2.Controls.Add(this.dgSiparisListesi);
            this.groupBox2.Controls.Add(this.btnSiparisTamamla);
            this.groupBox2.Controls.Add(this.txtTutar);
            this.groupBox2.Controls.Add(this.txtSUrunAdi);
            this.groupBox2.Controls.Add(this.txtSUrunKodu);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtSiparisKodu);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(475, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(445, 646);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "SİPARİŞ";
            // 
            // nmAdet
            // 
            this.nmAdet.Location = new System.Drawing.Point(136, 137);
            this.nmAdet.Name = "nmAdet";
            this.nmAdet.Size = new System.Drawing.Size(78, 26);
            this.nmAdet.TabIndex = 4;
            this.nmAdet.ValueChanged += new System.EventHandler(this.nmAdet_ValueChanged);
            // 
            // btnSepet
            // 
            this.btnSepet.Location = new System.Drawing.Point(87, 200);
            this.btnSepet.Name = "btnSepet";
            this.btnSepet.Size = new System.Drawing.Size(151, 67);
            this.btnSepet.TabIndex = 3;
            this.btnSepet.Text = "Sepete Ekle";
            this.btnSepet.UseVisualStyleBackColor = true;
            this.btnSepet.Click += new System.EventHandler(this.btnSepet_Click);
            // 
            // dgSiparisListesi
            // 
            this.dgSiparisListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSiparisListesi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8});
            this.dgSiparisListesi.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgSiparisListesi.Location = new System.Drawing.Point(3, 293);
            this.dgSiparisListesi.Name = "dgSiparisListesi";
            this.dgSiparisListesi.Size = new System.Drawing.Size(439, 350);
            this.dgSiparisListesi.TabIndex = 2;
            this.dgSiparisListesi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgSiparisListesi_CellClick);
            // 
            // btnSiparisTamamla
            // 
            this.btnSiparisTamamla.Location = new System.Drawing.Point(264, 200);
            this.btnSiparisTamamla.Name = "btnSiparisTamamla";
            this.btnSiparisTamamla.Size = new System.Drawing.Size(151, 67);
            this.btnSiparisTamamla.TabIndex = 1;
            this.btnSiparisTamamla.Text = "Sipariş Tamamla";
            this.btnSiparisTamamla.UseVisualStyleBackColor = true;
            this.btnSiparisTamamla.Click += new System.EventHandler(this.btnSiparisTamamla_Click);
            // 
            // txtTutar
            // 
            this.txtTutar.Enabled = false;
            this.txtTutar.ForeColor = System.Drawing.Color.Firebrick;
            this.txtTutar.Location = new System.Drawing.Point(133, 168);
            this.txtTutar.Name = "txtTutar";
            this.txtTutar.Size = new System.Drawing.Size(238, 26);
            this.txtTutar.TabIndex = 2;
            // 
            // txtSUrunAdi
            // 
            this.txtSUrunAdi.Location = new System.Drawing.Point(133, 99);
            this.txtSUrunAdi.Name = "txtSUrunAdi";
            this.txtSUrunAdi.Size = new System.Drawing.Size(238, 26);
            this.txtSUrunAdi.TabIndex = 2;
            // 
            // txtSUrunKodu
            // 
            this.txtSUrunKodu.Location = new System.Drawing.Point(133, 67);
            this.txtSUrunKodu.Name = "txtSUrunKodu";
            this.txtSUrunKodu.Size = new System.Drawing.Size(238, 26);
            this.txtSUrunKodu.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(17, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Sipariş Kodu";
            // 
            // txtSiparisKodu
            // 
            this.txtSiparisKodu.Location = new System.Drawing.Point(133, 30);
            this.txtSiparisKodu.Name = "txtSiparisKodu";
            this.txtSiparisKodu.Size = new System.Drawing.Size(238, 26);
            this.txtSiparisKodu.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(17, 170);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 20);
            this.label9.TabIndex = 0;
            this.label9.Text = "Tutar";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(17, 130);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "Adet";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(17, 98);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Ürün Adı";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(17, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Ürün Kodu";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Teal;
            this.groupBox3.Controls.Add(this.btnDegisiklikKaydet);
            this.groupBox3.Controls.Add(this.txtSSiparisKodu);
            this.groupBox3.Controls.Add(this.cmbSiparisDurum);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox3.Location = new System.Drawing.Point(926, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(402, 646);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "SİPARİŞ İZLEME";
            // 
            // btnDegisiklikKaydet
            // 
            this.btnDegisiklikKaydet.Location = new System.Drawing.Point(145, 148);
            this.btnDegisiklikKaydet.Name = "btnDegisiklikKaydet";
            this.btnDegisiklikKaydet.Size = new System.Drawing.Size(151, 67);
            this.btnDegisiklikKaydet.TabIndex = 4;
            this.btnDegisiklikKaydet.Text = "Değişiklik Kaydet";
            this.btnDegisiklikKaydet.UseVisualStyleBackColor = true;
            this.btnDegisiklikKaydet.Click += new System.EventHandler(this.btnDegisiklikKaydet_Click);
            // 
            // txtSSiparisKodu
            // 
            this.txtSSiparisKodu.Location = new System.Drawing.Point(145, 34);
            this.txtSSiparisKodu.Name = "txtSSiparisKodu";
            this.txtSSiparisKodu.Size = new System.Drawing.Size(238, 26);
            this.txtSSiparisKodu.TabIndex = 2;
            // 
            // cmbSiparisDurum
            // 
            this.cmbSiparisDurum.FormattingEnabled = true;
            this.cmbSiparisDurum.Location = new System.Drawing.Point(145, 89);
            this.cmbSiparisDurum.Name = "cmbSiparisDurum";
            this.cmbSiparisDurum.Size = new System.Drawing.Size(238, 28);
            this.cmbSiparisDurum.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(13, 37);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(110, 20);
            this.label10.TabIndex = 0;
            this.label10.Text = "Sipariş Kodu";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(7, 92);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(132, 20);
            this.label11.TabIndex = 0;
            this.label11.Text = "Sipariş Durumu";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Sipariş Kodu";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Urun";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Fiyat";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Durum";
            this.Column8.Name = "Column8";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1340, 686);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgUrunListesi)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmAdet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgSiparisListesi)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgUrunListesi;
        private System.Windows.Forms.ComboBox cmbUrunDurum;
        private System.Windows.Forms.TextBox txtFiyat;
        private System.Windows.Forms.TextBox txtUrunAdi;
        private System.Windows.Forms.TextBox txtUrunKodu;
        private System.Windows.Forms.Button btnUrunKaydet;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nmAdet;
        private System.Windows.Forms.Button btnSepet;
        private System.Windows.Forms.DataGridView dgSiparisListesi;
        private System.Windows.Forms.Button btnSiparisTamamla;
        private System.Windows.Forms.TextBox txtTutar;
        private System.Windows.Forms.TextBox txtSUrunAdi;
        private System.Windows.Forms.TextBox txtSUrunKodu;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSiparisKodu;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnDegisiklikKaydet;
        private System.Windows.Forms.TextBox txtSSiparisKodu;
        private System.Windows.Forms.ComboBox cmbSiparisDurum;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Button btnYeniUrun;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
    }
}

