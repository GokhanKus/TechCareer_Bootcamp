namespace DLL_Library_Ornek
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
            txtSayi1 = new TextBox();
            txtSayi2 = new TextBox();
            label1 = new Label();
            txtSonuc = new TextBox();
            label2 = new Label();
            label3 = new Label();
            btnTopla = new Button();
            btnCikart = new Button();
            btnCarp = new Button();
            btnBol = new Button();
            btnUsAl = new Button();
            label4 = new Label();
            SuspendLayout();
            // 
            // txtSayi1
            // 
            txtSayi1.Location = new Point(47, 75);
            txtSayi1.Name = "txtSayi1";
            txtSayi1.Size = new Size(72, 23);
            txtSayi1.TabIndex = 0;
            // 
            // txtSayi2
            // 
            txtSayi2.Location = new Point(166, 75);
            txtSayi2.Name = "txtSayi2";
            txtSayi2.Size = new Size(72, 23);
            txtSayi2.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(166, 47);
            label1.Name = "label1";
            label1.Size = new Size(37, 15);
            label1.TabIndex = 1;
            label1.Text = "Sayi2:";
            // 
            // txtSonuc
            // 
            txtSonuc.Location = new Point(284, 75);
            txtSonuc.Name = "txtSonuc";
            txtSonuc.Size = new Size(100, 23);
            txtSonuc.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(284, 47);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 1;
            label2.Text = "Sonuc";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(47, 47);
            label3.Name = "label3";
            label3.Size = new Size(37, 15);
            label3.TabIndex = 1;
            label3.Text = "Sayi1:";
            // 
            // btnTopla
            // 
            btnTopla.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnTopla.Location = new Point(59, 116);
            btnTopla.Name = "btnTopla";
            btnTopla.Size = new Size(51, 47);
            btnTopla.TabIndex = 2;
            btnTopla.Text = "+";
            btnTopla.UseVisualStyleBackColor = true;
            btnTopla.Click += btnTopla_Click;
            // 
            // btnCikart
            // 
            btnCikart.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnCikart.Location = new Point(117, 116);
            btnCikart.Name = "btnCikart";
            btnCikart.Size = new Size(51, 47);
            btnCikart.TabIndex = 2;
            btnCikart.Text = "-";
            btnCikart.UseVisualStyleBackColor = true;
            btnCikart.Click += btnCikart_Click;
            // 
            // btnCarp
            // 
            btnCarp.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnCarp.Location = new Point(177, 116);
            btnCarp.Name = "btnCarp";
            btnCarp.Size = new Size(51, 47);
            btnCarp.TabIndex = 2;
            btnCarp.Text = "*";
            btnCarp.UseVisualStyleBackColor = true;
            btnCarp.Click += btnCarp_Click;
            // 
            // btnBol
            // 
            btnBol.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnBol.Location = new Point(241, 116);
            btnBol.Name = "btnBol";
            btnBol.Size = new Size(51, 47);
            btnBol.TabIndex = 2;
            btnBol.Text = "/";
            btnBol.UseVisualStyleBackColor = true;
            btnBol.Click += btnBol_Click;
            // 
            // btnUsAl
            // 
            btnUsAl.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnUsAl.Location = new Point(308, 116);
            btnUsAl.Name = "btnUsAl";
            btnUsAl.Size = new Size(51, 47);
            btnUsAl.TabIndex = 2;
            btnUsAl.Text = "xʸ";
            btnUsAl.UseVisualStyleBackColor = true;
            btnUsAl.Click += btnUsAl_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label4.Location = new Point(254, 77);
            label4.Name = "label4";
            label4.Size = new Size(15, 16);
            label4.TabIndex = 1;
            label4.Text = "=";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(470, 209);
            Controls.Add(btnUsAl);
            Controls.Add(btnBol);
            Controls.Add(btnCarp);
            Controls.Add(btnCikart);
            Controls.Add(btnTopla);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtSayi2);
            Controls.Add(txtSonuc);
            Controls.Add(txtSayi1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtSayi1;
        private TextBox txtSayi2;
        private Label label1;
        private TextBox txtSonuc;
        private Label label2;
        private Label label3;
        private Button btnTopla;
        private Button btnCikart;
        private Button btnCarp;
        private Button btnBol;
        private Button btnUsAl;
        private Label label4;
    }
}
