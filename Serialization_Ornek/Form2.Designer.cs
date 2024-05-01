namespace Serialization_Ornek
{
    partial class Form2
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
            btnJsonSerialize = new Button();
            btnJsonDeserialize = new Button();
            lblSonuc = new Label();
            SuspendLayout();
            // 
            // btnJsonSerialize
            // 
            btnJsonSerialize.Location = new Point(197, 132);
            btnJsonSerialize.Name = "btnJsonSerialize";
            btnJsonSerialize.Size = new Size(113, 51);
            btnJsonSerialize.TabIndex = 0;
            btnJsonSerialize.Text = "Json Serialize";
            btnJsonSerialize.UseVisualStyleBackColor = true;
            btnJsonSerialize.Click += btnJsonSerialize_Click;
            // 
            // btnJsonDeserialize
            // 
            btnJsonDeserialize.Location = new Point(356, 132);
            btnJsonDeserialize.Name = "btnJsonDeserialize";
            btnJsonDeserialize.Size = new Size(113, 51);
            btnJsonDeserialize.TabIndex = 0;
            btnJsonDeserialize.Text = "Json Deserialize";
            btnJsonDeserialize.UseVisualStyleBackColor = true;
            btnJsonDeserialize.Click += btnJsonDeserialize_Click;
            // 
            // lblSonuc
            // 
            lblSonuc.AutoSize = true;
            lblSonuc.Location = new Point(200, 225);
            lblSonuc.Name = "lblSonuc";
            lblSonuc.Size = new Size(0, 15);
            lblSonuc.TabIndex = 1;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(684, 342);
            Controls.Add(lblSonuc);
            Controls.Add(btnJsonDeserialize);
            Controls.Add(btnJsonSerialize);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnJsonSerialize;
        private Button btnJsonDeserialize;
        private Label lblSonuc;
    }
}