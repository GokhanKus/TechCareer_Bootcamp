namespace KitapFormu
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            btnKaydet = new Button();
            txtKitapAdi = new TextBox();
            txtFiyat = new TextBox();
            txtSayfaSayisi = new TextBox();
            cmbKategori = new ComboBox();
            cmbYayinEvi = new ComboBox();
            cmbYazar = new ComboBox();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(69, 33);
            label1.Name = "label1";
            label1.Size = new Size(58, 15);
            label1.TabIndex = 0;
            label1.Text = "Kitap Adi:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(89, 71);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 0;
            label2.Text = "Fiyat: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(64, 107);
            label3.Name = "label3";
            label3.Size = new Size(70, 15);
            label3.TabIndex = 0;
            label3.Text = "Sayfa Sayisi:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(60, 142);
            label4.Name = "label4";
            label4.Size = new Size(51, 15);
            label4.TabIndex = 0;
            label4.Text = "Kategori";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(192, 142);
            label5.Name = "label5";
            label5.Size = new Size(50, 15);
            label5.TabIndex = 0;
            label5.Text = "Yayinevi";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(319, 142);
            label6.Name = "label6";
            label6.Size = new Size(34, 15);
            label6.TabIndex = 0;
            label6.Text = "Yazar";
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new Point(344, 50);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(148, 51);
            btnKaydet.TabIndex = 1;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // txtKitapAdi
            // 
            txtKitapAdi.Location = new Point(157, 30);
            txtKitapAdi.Name = "txtKitapAdi";
            txtKitapAdi.Size = new Size(153, 23);
            txtKitapAdi.TabIndex = 2;
            // 
            // txtFiyat
            // 
            txtFiyat.Location = new Point(157, 68);
            txtFiyat.Name = "txtFiyat";
            txtFiyat.Size = new Size(153, 23);
            txtFiyat.TabIndex = 2;
            // 
            // txtSayfaSayisi
            // 
            txtSayfaSayisi.Location = new Point(157, 104);
            txtSayfaSayisi.Name = "txtSayfaSayisi";
            txtSayfaSayisi.Size = new Size(153, 23);
            txtSayfaSayisi.TabIndex = 2;
            // 
            // cmbKategori
            // 
            cmbKategori.FormattingEnabled = true;
            cmbKategori.Location = new Point(60, 160);
            cmbKategori.Name = "cmbKategori";
            cmbKategori.Size = new Size(121, 23);
            cmbKategori.TabIndex = 3;
            // 
            // cmbYayinEvi
            // 
            cmbYayinEvi.FormattingEnabled = true;
            cmbYayinEvi.Location = new Point(192, 160);
            cmbYayinEvi.Name = "cmbYayinEvi";
            cmbYayinEvi.Size = new Size(121, 23);
            cmbYayinEvi.TabIndex = 3;
            // 
            // cmbYazar
            // 
            cmbYazar.FormattingEnabled = true;
            cmbYazar.Location = new Point(319, 160);
            cmbYazar.Name = "cmbYazar";
            cmbYazar.Size = new Size(121, 23);
            cmbYazar.TabIndex = 3;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(37, 210);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(706, 228);
            dataGridView1.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(786, 450);
            Controls.Add(dataGridView1);
            Controls.Add(cmbYazar);
            Controls.Add(cmbYayinEvi);
            Controls.Add(cmbKategori);
            Controls.Add(txtSayfaSayisi);
            Controls.Add(txtFiyat);
            Controls.Add(txtKitapAdi);
            Controls.Add(btnKaydet);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button btnKaydet;
        private TextBox txtKitapAdi;
        private TextBox txtFiyat;
        private TextBox txtSayfaSayisi;
        private ComboBox cmbKategori;
        private ComboBox cmbYayinEvi;
        private ComboBox cmbYazar;
        private DataGridView dataGridView1;
    }
}
