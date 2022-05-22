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
    public partial class FormRSAKeyGenerator : Form
    {
        Form _father;

        public FormRSAKeyGenerator(Form father)
        {
            this.ControlBox = false;
            InitializeComponent();
            _father = father;
        }

        private void btn_generate_Click(object sender, EventArgs e)
        {
            Tuple<Tuple<int, int>, Tuple<int, int>> RSA_keys = Encrypto.rsa_key_generation();
            // ((n, e), (n, d))
            txt_public_E.Text = RSA_keys.Item1.Item1.ToString();  // n
            txt_private_E.Text = RSA_keys.Item1.Item2.ToString();  // e
            txt_public_D.Text = RSA_keys.Item2.Item1.ToString();  // n
            txt_private_D.Text = RSA_keys.Item2.Item2.ToString();  // d
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            _father.Show();
            this.Close();
        }
    }
}
