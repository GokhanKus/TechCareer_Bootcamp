namespace Serialization_Ornek
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
            txtAdSoyad = new TextBox();
            txtTelefon = new TextBox();
            txtDepartman = new TextBox();
            txtMaas = new TextBox();
            dtDogumTarihi = new DateTimePicker();
            btnXmlSerialized = new Button();
            btnXmlDeserialized = new Button();
            btnJsonSerialized = new Button();
            btnJsonDeserialized = new Button();
            lblSonuc = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(218, 67);
            label1.Name = "label1";
            label1.Size = new Size(66, 15);
            label1.TabIndex = 0;
            label1.Text = "Adi Soyadi:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(233, 105);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 0;
            label2.Text = "Telefon: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(203, 144);
            label3.Name = "label3";
            label3.Size = new Size(81, 15);
            label3.TabIndex = 0;
            label3.Text = "Dogum Tarihi:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(215, 182);
            label4.Name = "label4";
            label4.Size = new Size(69, 15);
            label4.TabIndex = 0;
            label4.Text = "Departman:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(246, 219);
            label5.Name = "label5";
            label5.Size = new Size(38, 15);
            label5.TabIndex = 0;
            label5.Text = "Maas:";
            // 
            // txtAdSoyad
            // 
            txtAdSoyad.Location = new Point(312, 64);
            txtAdSoyad.Name = "txtAdSoyad";
            txtAdSoyad.Size = new Size(199, 23);
            txtAdSoyad.TabIndex = 1;
            // 
            // txtTelefon
            // 
            txtTelefon.Location = new Point(312, 102);
            txtTelefon.Name = "txtTelefon";
            txtTelefon.Size = new Size(199, 23);
            txtTelefon.TabIndex = 1;
            // 
            // txtDepartman
            // 
            txtDepartman.Location = new Point(312, 179);
            txtDepartman.Name = "txtDepartman";
            txtDepartman.Size = new Size(199, 23);
            txtDepartman.TabIndex = 1;
            // 
            // txtMaas
            // 
            txtMaas.Location = new Point(312, 216);
            txtMaas.Name = "txtMaas";
            txtMaas.Size = new Size(199, 23);
            txtMaas.TabIndex = 1;
            // 
            // dtDogumTarihi
            // 
            dtDogumTarihi.Location = new Point(311, 141);
            dtDogumTarihi.Name = "dtDogumTarihi";
            dtDogumTarihi.Size = new Size(200, 23);
            dtDogumTarihi.TabIndex = 2;
            // 
            // btnXmlSerialized
            // 
            btnXmlSerialized.Location = new Point(203, 259);
            btnXmlSerialized.Name = "btnXmlSerialized";
            btnXmlSerialized.Size = new Size(126, 31);
            btnXmlSerialized.TabIndex = 3;
            btnXmlSerialized.Text = "XmlSerialized";
            btnXmlSerialized.UseVisualStyleBackColor = true;
            btnXmlSerialized.Click += btnXmlSerialized_Click;
            // 
            // btnXmlDeserialized
            // 
            btnXmlDeserialized.Location = new Point(203, 296);
            btnXmlDeserialized.Name = "btnXmlDeserialized";
            btnXmlDeserialized.Size = new Size(126, 31);
            btnXmlDeserialized.TabIndex = 3;
            btnXmlDeserialized.Text = "XmlDeserialized";
            btnXmlDeserialized.UseVisualStyleBackColor = true;
            btnXmlDeserialized.Click += btnXmlDeserialized_Click;
            // 
            // btnJsonSerialized
            // 
            btnJsonSerialized.Location = new Point(385, 259);
            btnJsonSerialized.Name = "btnJsonSerialized";
            btnJsonSerialized.Size = new Size(126, 31);
            btnJsonSerialized.TabIndex = 3;
            btnJsonSerialized.Text = "JsonSerialized";
            btnJsonSerialized.UseVisualStyleBackColor = true;
            // 
            // btnJsonDeserialized
            // 
            btnJsonDeserialized.Location = new Point(385, 296);
            btnJsonDeserialized.Name = "btnJsonDeserialized";
            btnJsonDeserialized.Size = new Size(126, 31);
            btnJsonDeserialized.TabIndex = 3;
            btnJsonDeserialized.Text = "JsonDeserialized";
            btnJsonDeserialized.UseVisualStyleBackColor = true;
            // 
            // lblSonuc
            // 
            lblSonuc.AutoSize = true;
            lblSonuc.Location = new Point(203, 353);
            lblSonuc.Name = "lblSonuc";
            lblSonuc.Size = new Size(0, 15);
            lblSonuc.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(734, 450);
            Controls.Add(btnJsonDeserialized);
            Controls.Add(btnJsonSerialized);
            Controls.Add(btnXmlDeserialized);
            Controls.Add(btnXmlSerialized);
            Controls.Add(dtDogumTarihi);
            Controls.Add(txtMaas);
            Controls.Add(txtDepartman);
            Controls.Add(txtTelefon);
            Controls.Add(txtAdSoyad);
            Controls.Add(lblSonuc);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtAdSoyad;
        private TextBox txtTelefon;
        private TextBox txtDepartman;
        private TextBox txtMaas;
        private DateTimePicker dtDogumTarihi;
        private Button btnXmlSerialized;
        private Button btnXmlDeserialized;
        private Button btnJsonSerialized;
        private Button btnJsonDeserialized;
        private Label lblSonuc;
    }
}
