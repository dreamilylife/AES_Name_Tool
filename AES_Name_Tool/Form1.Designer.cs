namespace AES_Name_Tool
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.key_label = new System.Windows.Forms.Label();
            this.encrypt_button = new System.Windows.Forms.Button();
            this.decrypt_button = new System.Windows.Forms.Button();
            this.plain_textBox = new System.Windows.Forms.TextBox();
            this.encrypted_textBox = new System.Windows.Forms.TextBox();
            this.key_textBox = new System.Windows.Forms.TextBox();
            this.reset_button = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.reset_button);
            this.panel1.Controls.Add(this.key_textBox);
            this.panel1.Controls.Add(this.encrypted_textBox);
            this.panel1.Controls.Add(this.plain_textBox);
            this.panel1.Controls.Add(this.decrypt_button);
            this.panel1.Controls.Add(this.encrypt_button);
            this.panel1.Controls.Add(this.key_label);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(5, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(790, 288);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Plain Text:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Encrypted Text:";
            // 
            // key_label
            // 
            this.key_label.AutoSize = true;
            this.key_label.Location = new System.Drawing.Point(29, 193);
            this.key_label.Name = "key_label";
            this.key_label.Size = new System.Drawing.Size(41, 18);
            this.key_label.TabIndex = 2;
            this.key_label.Text = "Key:";
            // 
            // encrypt_button
            // 
            this.encrypt_button.Location = new System.Drawing.Point(191, 245);
            this.encrypt_button.Name = "encrypt_button";
            this.encrypt_button.Size = new System.Drawing.Size(114, 33);
            this.encrypt_button.TabIndex = 3;
            this.encrypt_button.Text = "Encrypt";
            this.encrypt_button.UseVisualStyleBackColor = true;
            this.encrypt_button.Click += new System.EventHandler(this.encrypt_button_Click);
            // 
            // decrypt_button
            // 
            this.decrypt_button.Location = new System.Drawing.Point(384, 245);
            this.decrypt_button.Name = "decrypt_button";
            this.decrypt_button.Size = new System.Drawing.Size(114, 33);
            this.decrypt_button.TabIndex = 4;
            this.decrypt_button.Text = "Decrypt";
            this.decrypt_button.UseVisualStyleBackColor = true;
            this.decrypt_button.Click += new System.EventHandler(this.decrypt_button_Click);
            // 
            // plain_textBox
            // 
            this.plain_textBox.Location = new System.Drawing.Point(168, 43);
            this.plain_textBox.Multiline = true;
            this.plain_textBox.Name = "plain_textBox";
            this.plain_textBox.Size = new System.Drawing.Size(549, 76);
            this.plain_textBox.TabIndex = 5;
            // 
            // encrypted_textBox
            // 
            this.encrypted_textBox.Location = new System.Drawing.Point(168, 137);
            this.encrypted_textBox.Name = "encrypted_textBox";
            this.encrypted_textBox.Size = new System.Drawing.Size(549, 29);
            this.encrypted_textBox.TabIndex = 6;
            // 
            // key_textBox
            // 
            this.key_textBox.Location = new System.Drawing.Point(168, 190);
            this.key_textBox.Name = "key_textBox";
            this.key_textBox.Size = new System.Drawing.Size(549, 29);
            this.key_textBox.TabIndex = 7;
            // 
            // reset_button
            // 
            this.reset_button.Location = new System.Drawing.Point(570, 245);
            this.reset_button.Name = "reset_button";
            this.reset_button.Size = new System.Drawing.Size(114, 33);
            this.reset_button.TabIndex = 8;
            this.reset_button.Text = "Reset";
            this.reset_button.UseVisualStyleBackColor = true;
            this.reset_button.Click += new System.EventHandler(this.reset_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 297);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "AES Text Tool";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox key_textBox;
        private System.Windows.Forms.TextBox encrypted_textBox;
        private System.Windows.Forms.TextBox plain_textBox;
        private System.Windows.Forms.Button decrypt_button;
        private System.Windows.Forms.Button encrypt_button;
        private System.Windows.Forms.Label key_label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button reset_button;
    }
}

