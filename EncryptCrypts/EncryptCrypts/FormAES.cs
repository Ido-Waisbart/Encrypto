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
    public partial class FormAES : Form
    {
        Form _father;

        public FormAES(Form father)
        {
            this.ControlBox = false;
            _father = father;
            InitializeComponent();
        }

        private void btn_encrypt_Click(object sender, EventArgs e)
        {
            int i = 0;
            byte[] bytes_256 = new byte[256];

            if (txt_input.Text != "")
            {
                byte[] input = Encoding.ASCII.GetBytes(txt_input.Text);
                byte[] key = Encoding.ASCII.GetBytes(txt_key.Text);

                for (i = 0; i < 256; i++)
                {
                    bytes_256[i] = 0x00;
                    if (i < input.Length)
                    {
                        bytes_256[i] = input[i];
                    }
                }

                //Console.WriteLine("E - " + BitConverter.ToString(bytes_256).Replace("-", ""));

                byte[] output = Encrypto.aes_cipher_encrypt(bytes_256, key);
                txt_output.Text = BitConverter.ToString(output).Replace("-", string.Empty);

                //Console.WriteLine("E2 - " + BitConverter.ToString(output).Replace("-", ""));
            }
        }

        private void btn_decrypt_Click(object sender, EventArgs e)
        {
            int i = 0;
            byte[] bytes_256 = new byte[256];

            if (txt_inputD.Text != "")
            {
                //byte[] input = Encoding.ASCII.GetBytes(txt_inputD.Text);
                byte[] input = Encrypto.string_to_byte_array(txt_inputD.Text);
                //byte[] input = HexEncoding.GetBytes(txt_inputD.Text, out int discarded);
                byte[] key = Encoding.ASCII.GetBytes(txt_keyD.Text);

                for (i = 0; i < 256; i++)
                {
                    bytes_256[i] = 0x00;
                    if (i < input.Length)
                    {
                        bytes_256[i] = input[i];
                    }
                }

                //Console.WriteLine("D - " + BitConverter.ToString(bytes_256).Replace("-", ""));

                byte[] output = Encrypto.aes_cipher_decrypt(bytes_256, key);
                txt_outputD.Text = Encrypto.hex_to_string(BitConverter.ToString(output).Replace("-", string.Empty));

                //Console.WriteLine("D2 - " + BitConverter.ToString(output).Replace("-", ""));
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            _father.Show();
            this.Close();
        }
    }
}
