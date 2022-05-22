using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EncryptoLib;

namespace EncryptCrypts
{
    public partial class FormVigenere : Form
    {
        Form _father;

        public FormVigenere(Form father)
        {
            this.ControlBox = false;
            _father = father;
            InitializeComponent();
        }

        private void btn_encrypt_Click(object sender, EventArgs e)
        {
            if (txt_input.Text != "")
            {
                string input = txt_input.Text;
                string key = txt_key.Text;

                string output = Encrypto.vigenere_cipher_encrypt(input, key);
                txt_output.Text = output;
            }
        }

        private void btn_decrypt_Click(object sender, EventArgs e)
        {
            if (txt_inputD.Text != "")
            {
                string input = txt_inputD.Text;
                string key = txt_keyD.Text;

                string output = Encrypto.vigenere_cipher_decrypt(input, key);
                txt_outputD.Text = output;
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            _father.Show();
            this.Close();
        }
    }
}
