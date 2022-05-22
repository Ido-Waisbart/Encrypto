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
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
            ToolTip TP = new ToolTip();
            TP.ShowAlways = true;
            TP.SetToolTip(btn_AES, "AES cipher");
            TP.SetToolTip(btn_caesar, "Caesar cipher");
            TP.SetToolTip(btn_key_generation, "RSA key generation");
            TP.SetToolTip(btn_RSA, "RSA cipher");
            TP.SetToolTip(btn_viginere, "Vigenere cipher");
            this.ControlBox = false;
        }

        private void btn_AES_Click(object sender, EventArgs e)
        {
            Form form_aes = new FormAES(this);
            this.Hide();
            form_aes.Show();
        }

        private void btn_caesar_Click(object sender, EventArgs e)
        {
            Form frm_caeser = new FormCaesar(this);
            this.Hide();
            frm_caeser.Show();
        }

        private void btn_viginere_Click(object sender, EventArgs e)
        {
            Form frm_vigenere = new FormVigenere(this);
            this.Hide();
            frm_vigenere.Show();
        }

        private void btn_RSA_Click(object sender, EventArgs e)
        {
            Form frm_RSA = new FormRSA(this);
            this.Hide();
            frm_RSA.Show();
        }

        private void btn_key_generation_Click(object sender, EventArgs e)
        {
            Form frm_RSA_key_generator = new FormRSAKeyGenerator(this);
            this.Hide();
            frm_RSA_key_generator.Show();
        }

        private void btn_quit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
