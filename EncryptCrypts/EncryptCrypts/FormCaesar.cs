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
    public partial class FormCaesar : Form
    {
        Form _father;

        public FormCaesar(Form father)
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
                int key = Convert.ToInt32(txt_key.Text);

                string output = Encrypto.caesar_cipher_encrypt(input, key);
                txt_output.Text = output;
            }
        }

        private void btn_decrypt_Click(object sender, EventArgs e)
        {
            if (txt_inputD.Text != "")
            {
                string input = txt_inputD.Text;
                int key = Convert.ToInt32(txt_keyD.Text);

                string output = Encrypto.caesar_cipher_decrypt(input, key);
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
