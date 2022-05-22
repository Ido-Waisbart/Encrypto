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
using System.Numerics;

namespace EncryptCrypts
{
    public partial class FormRSA : Form
    {
        Form _father;

        public FormRSA(Form father)
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
                int private_key = Convert.ToInt32(txt_private_keyE.Text);
                int public_key = Convert.ToInt32(txt_public_keyE.Text);
                BigInteger[] BI_output = Encrypto.rsa_cipher_encrypt(input, new Tuple<int, int>(public_key, private_key));

                string output = "";

                foreach (int num in BI_output)
                {
                    output += num.ToString() + ',';
                }
                output = output.Substring(0, output.Length - 1);
                txt_output.Text = output;
            }
        }

        // generate_key() returns ((n, e), (n, d))
        // encrypt() <- (n, e)
        // decrypt() <- (n, d)

        private void btn_decrypt_Click(object sender, EventArgs e)
        {
            if (txt_inputD.Text != "")
            {
                int private_key = Convert.ToInt32(txt_private_keyD.Text);
                int public_key = Convert.ToInt32(txt_public_keyD.Text);
                BigInteger[] BI_input = new BigInteger[txt_inputD.Text.Split(',').Length];

                int i = 0;
                foreach (string big_int in txt_inputD.Text.Split(','))
                {
                    BI_input[i++] = BigInteger.Parse(big_int);
                }

                string output = Encrypto.rsa_cipher_decrypt(BI_input, new Tuple<int, int>(public_key, private_key));

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
