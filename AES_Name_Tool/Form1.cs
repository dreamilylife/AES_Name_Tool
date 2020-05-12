using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AES_Name_Tool;

namespace AES_Name_Tool
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void encrypt_button_Click(object sender, EventArgs e)
        {
            string key = key_textBox.Text;
            AES_Tools my_aes = new AES_Tools();
            key = my_aes.do_check_and_revise_key(key);
            string encrypted_text = my_aes.do_encrypt_text(plain_textBox.Text, key);
            encrypted_textBox.Text = encrypted_text;
        }

        private void decrypt_button_Click(object sender, EventArgs e)
        {
            string key = key_textBox.Text;
            AES_Tools my_aes = new AES_Tools();
            key = my_aes.do_check_and_revise_key(key);
            string decrypted_text = my_aes.do_decrypt_text(encrypted_textBox.Text, key);
            plain_textBox.Text = decrypted_text;
        }

        private void reset_button_Click(object sender, EventArgs e)
        {
            plain_textBox.Text = "";
            encrypted_textBox.Text = "";
            key_textBox.Text = "";
        }
    }
}
