namespace EncryptionApk
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
            this.txtDecryptedText = new System.Windows.Forms.TextBox();
            this.txtEncryptedText = new System.Windows.Forms.TextBox();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.lblDecrypted = new System.Windows.Forms.Label();
            this.lblEncrypted = new System.Windows.Forms.Label();
            this.cmbAlgorithm = new System.Windows.Forms.ComboBox();
            this.txtKey = new System.Windows.Forms.TextBox();
            this.lblKey = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtDecryptedText
            // 
            this.txtDecryptedText.Location = new System.Drawing.Point(12, 52);
            this.txtDecryptedText.Multiline = true;
            this.txtDecryptedText.Name = "txtDecryptedText";
            this.txtDecryptedText.Size = new System.Drawing.Size(328, 317);
            this.txtDecryptedText.TabIndex = 0;
            // 
            // txtEncryptedText
            // 
            this.txtEncryptedText.Location = new System.Drawing.Point(629, 52);
            this.txtEncryptedText.Multiline = true;
            this.txtEncryptedText.Name = "txtEncryptedText";
            this.txtEncryptedText.Size = new System.Drawing.Size(317, 317);
            this.txtEncryptedText.TabIndex = 1;
            this.txtEncryptedText.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Location = new System.Drawing.Point(317, 433);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(75, 23);
            this.btnEncrypt.TabIndex = 2;
            this.btnEncrypt.Text = "Encrypt";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click_1);
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.Location = new System.Drawing.Point(572, 433);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(75, 23);
            this.btnDecrypt.TabIndex = 3;
            this.btnDecrypt.Text = "Decrypt";
            this.btnDecrypt.UseVisualStyleBackColor = true;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click_1);
            // 
            // lblDecrypted
            // 
            this.lblDecrypted.AllowDrop = true;
            this.lblDecrypted.AutoSize = true;
            this.lblDecrypted.Location = new System.Drawing.Point(9, 33);
            this.lblDecrypted.Name = "lblDecrypted";
            this.lblDecrypted.Size = new System.Drawing.Size(96, 16);
            this.lblDecrypted.TabIndex = 4;
            this.lblDecrypted.Text = "DecryptedText";
            // 
            // lblEncrypted
            // 
            this.lblEncrypted.AutoSize = true;
            this.lblEncrypted.Location = new System.Drawing.Point(626, 33);
            this.lblEncrypted.Name = "lblEncrypted";
            this.lblEncrypted.Size = new System.Drawing.Size(94, 16);
            this.lblEncrypted.TabIndex = 5;
            this.lblEncrypted.Text = "EncryptedText";
            // 
            // cmbAlgorithm
            // 
            this.cmbAlgorithm.FormattingEnabled = true;
            this.cmbAlgorithm.Location = new System.Drawing.Point(418, 180);
            this.cmbAlgorithm.Name = "cmbAlgorithm";
            this.cmbAlgorithm.Size = new System.Drawing.Size(121, 24);
            this.cmbAlgorithm.TabIndex = 6;
            // 
            // txtKey
            // 
            this.txtKey.Location = new System.Drawing.Point(379, 375);
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(223, 22);
            this.txtKey.TabIndex = 7;
            // 
            // lblKey
            // 
            this.lblKey.AutoSize = true;
            this.lblKey.Location = new System.Drawing.Point(436, 353);
            this.lblKey.Name = "lblKey";
            this.lblKey.Size = new System.Drawing.Size(33, 16);
            this.lblKey.TabIndex = 8;
            this.lblKey.Text = "Key:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 598);
            this.Controls.Add(this.lblKey);
            this.Controls.Add(this.txtKey);
            this.Controls.Add(this.cmbAlgorithm);
            this.Controls.Add(this.lblEncrypted);
            this.Controls.Add(this.lblDecrypted);
            this.Controls.Add(this.btnDecrypt);
            this.Controls.Add(this.btnEncrypt);
            this.Controls.Add(this.txtEncryptedText);
            this.Controls.Add(this.txtDecryptedText);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDecryptedText;
        private System.Windows.Forms.TextBox txtEncryptedText;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.Label lblDecrypted;
        private System.Windows.Forms.Label lblEncrypted;
        private System.Windows.Forms.ComboBox cmbAlgorithm;
        private System.Windows.Forms.TextBox txtKey;
        private System.Windows.Forms.Label lblKey;
    }
}

