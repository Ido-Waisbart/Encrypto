namespace EncryptCrypts
{
    partial class FormRSA
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
            this.txt_public_keyD = new System.Windows.Forms.TextBox();
            this.lbl_public_keyD = new System.Windows.Forms.Label();
            this.btn_decrypt = new System.Windows.Forms.Button();
            this.txt_outputD = new System.Windows.Forms.TextBox();
            this.lbl_outputD = new System.Windows.Forms.Label();
            this.txt_inputD = new System.Windows.Forms.TextBox();
            this.lbl_inputD = new System.Windows.Forms.Label();
            this.btn_exit = new System.Windows.Forms.Button();
            this.txt_private_keyE = new System.Windows.Forms.TextBox();
            this.lbl_private_keyE = new System.Windows.Forms.Label();
            this.btn_encrypt = new System.Windows.Forms.Button();
            this.txt_output = new System.Windows.Forms.TextBox();
            this.lbl_output = new System.Windows.Forms.Label();
            this.txt_input = new System.Windows.Forms.TextBox();
            this.lbl_input = new System.Windows.Forms.Label();
            this.txt_public_keyE = new System.Windows.Forms.TextBox();
            this.lbl_public_keyE = new System.Windows.Forms.Label();
            this.txt_private_keyD = new System.Windows.Forms.TextBox();
            this.lbl_private_keyD = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_public_keyD
            // 
            this.txt_public_keyD.Location = new System.Drawing.Point(488, 95);
            this.txt_public_keyD.Name = "txt_public_keyD";
            this.txt_public_keyD.Size = new System.Drawing.Size(100, 20);
            this.txt_public_keyD.TabIndex = 34;
            // 
            // lbl_public_keyD
            // 
            this.lbl_public_keyD.AutoSize = true;
            this.lbl_public_keyD.Location = new System.Drawing.Point(392, 98);
            this.lbl_public_keyD.Name = "lbl_public_keyD";
            this.lbl_public_keyD.Size = new System.Drawing.Size(73, 13);
            this.lbl_public_keyD.TabIndex = 43;
            this.lbl_public_keyD.Text = "Int public key:";
            // 
            // btn_decrypt
            // 
            this.btn_decrypt.Location = new System.Drawing.Point(449, 220);
            this.btn_decrypt.Name = "btn_decrypt";
            this.btn_decrypt.Size = new System.Drawing.Size(75, 23);
            this.btn_decrypt.TabIndex = 36;
            this.btn_decrypt.Text = "Decrypt!";
            this.btn_decrypt.UseVisualStyleBackColor = true;
            this.btn_decrypt.Click += new System.EventHandler(this.btn_decrypt_Click);
            // 
            // txt_outputD
            // 
            this.txt_outputD.Location = new System.Drawing.Point(488, 165);
            this.txt_outputD.Name = "txt_outputD";
            this.txt_outputD.Size = new System.Drawing.Size(100, 20);
            this.txt_outputD.TabIndex = 35;
            // 
            // lbl_outputD
            // 
            this.lbl_outputD.AutoSize = true;
            this.lbl_outputD.Location = new System.Drawing.Point(392, 168);
            this.lbl_outputD.Name = "lbl_outputD";
            this.lbl_outputD.Size = new System.Drawing.Size(42, 13);
            this.lbl_outputD.TabIndex = 42;
            this.lbl_outputD.Text = "Output:";
            // 
            // txt_inputD
            // 
            this.txt_inputD.Location = new System.Drawing.Point(488, 60);
            this.txt_inputD.Name = "txt_inputD";
            this.txt_inputD.Size = new System.Drawing.Size(100, 20);
            this.txt_inputD.TabIndex = 33;
            // 
            // lbl_inputD
            // 
            this.lbl_inputD.AutoSize = true;
            this.lbl_inputD.Location = new System.Drawing.Point(392, 63);
            this.lbl_inputD.Name = "lbl_inputD";
            this.lbl_inputD.Size = new System.Drawing.Size(85, 13);
            this.lbl_inputD.TabIndex = 41;
            this.lbl_inputD.Text = "Encrypted Input:";
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(268, 278);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(75, 23);
            this.btn_exit.TabIndex = 37;
            this.btn_exit.Text = "BACK";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // txt_private_keyE
            // 
            this.txt_private_keyE.Location = new System.Drawing.Point(171, 131);
            this.txt_private_keyE.Name = "txt_private_keyE";
            this.txt_private_keyE.Size = new System.Drawing.Size(100, 20);
            this.txt_private_keyE.TabIndex = 30;
            // 
            // lbl_private_keyE
            // 
            this.lbl_private_keyE.AutoSize = true;
            this.lbl_private_keyE.Location = new System.Drawing.Point(75, 134);
            this.lbl_private_keyE.Name = "lbl_private_keyE";
            this.lbl_private_keyE.Size = new System.Drawing.Size(77, 13);
            this.lbl_private_keyE.TabIndex = 40;
            this.lbl_private_keyE.Text = "Int private key:";
            // 
            // btn_encrypt
            // 
            this.btn_encrypt.Location = new System.Drawing.Point(132, 220);
            this.btn_encrypt.Name = "btn_encrypt";
            this.btn_encrypt.Size = new System.Drawing.Size(75, 23);
            this.btn_encrypt.TabIndex = 32;
            this.btn_encrypt.Text = "Encrypt!";
            this.btn_encrypt.UseVisualStyleBackColor = true;
            this.btn_encrypt.Click += new System.EventHandler(this.btn_encrypt_Click);
            // 
            // txt_output
            // 
            this.txt_output.Location = new System.Drawing.Point(171, 165);
            this.txt_output.Name = "txt_output";
            this.txt_output.Size = new System.Drawing.Size(100, 20);
            this.txt_output.TabIndex = 31;
            // 
            // lbl_output
            // 
            this.lbl_output.AutoSize = true;
            this.lbl_output.Location = new System.Drawing.Point(75, 168);
            this.lbl_output.Name = "lbl_output";
            this.lbl_output.Size = new System.Drawing.Size(42, 13);
            this.lbl_output.TabIndex = 39;
            this.lbl_output.Text = "Output:";
            // 
            // txt_input
            // 
            this.txt_input.Location = new System.Drawing.Point(171, 60);
            this.txt_input.Name = "txt_input";
            this.txt_input.Size = new System.Drawing.Size(100, 20);
            this.txt_input.TabIndex = 29;
            // 
            // lbl_input
            // 
            this.lbl_input.AutoSize = true;
            this.lbl_input.Location = new System.Drawing.Point(75, 63);
            this.lbl_input.Name = "lbl_input";
            this.lbl_input.Size = new System.Drawing.Size(34, 13);
            this.lbl_input.TabIndex = 38;
            this.lbl_input.Text = "Input:";
            // 
            // txt_public_keyE
            // 
            this.txt_public_keyE.Location = new System.Drawing.Point(171, 95);
            this.txt_public_keyE.Name = "txt_public_keyE";
            this.txt_public_keyE.Size = new System.Drawing.Size(100, 20);
            this.txt_public_keyE.TabIndex = 44;
            // 
            // lbl_public_keyE
            // 
            this.lbl_public_keyE.AutoSize = true;
            this.lbl_public_keyE.Location = new System.Drawing.Point(75, 98);
            this.lbl_public_keyE.Name = "lbl_public_keyE";
            this.lbl_public_keyE.Size = new System.Drawing.Size(73, 13);
            this.lbl_public_keyE.TabIndex = 45;
            this.lbl_public_keyE.Text = "Int public key:";
            // 
            // txt_private_keyD
            // 
            this.txt_private_keyD.Location = new System.Drawing.Point(488, 131);
            this.txt_private_keyD.Name = "txt_private_keyD";
            this.txt_private_keyD.Size = new System.Drawing.Size(100, 20);
            this.txt_private_keyD.TabIndex = 46;
            // 
            // lbl_private_keyD
            // 
            this.lbl_private_keyD.AutoSize = true;
            this.lbl_private_keyD.Location = new System.Drawing.Point(392, 134);
            this.lbl_private_keyD.Name = "lbl_private_keyD";
            this.lbl_private_keyD.Size = new System.Drawing.Size(77, 13);
            this.lbl_private_keyD.TabIndex = 47;
            this.lbl_private_keyD.Text = "Int private key:";
            // 
            // FormRSA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 361);
            this.Controls.Add(this.txt_private_keyD);
            this.Controls.Add(this.lbl_private_keyD);
            this.Controls.Add(this.txt_public_keyE);
            this.Controls.Add(this.lbl_public_keyE);
            this.Controls.Add(this.txt_public_keyD);
            this.Controls.Add(this.lbl_public_keyD);
            this.Controls.Add(this.btn_decrypt);
            this.Controls.Add(this.txt_outputD);
            this.Controls.Add(this.lbl_outputD);
            this.Controls.Add(this.txt_inputD);
            this.Controls.Add(this.lbl_inputD);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.txt_private_keyE);
            this.Controls.Add(this.lbl_private_keyE);
            this.Controls.Add(this.btn_encrypt);
            this.Controls.Add(this.txt_output);
            this.Controls.Add(this.lbl_output);
            this.Controls.Add(this.txt_input);
            this.Controls.Add(this.lbl_input);
            this.Name = "FormRSA";
            this.Text = "frm_RSA";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_public_keyD;
        private System.Windows.Forms.Label lbl_public_keyD;
        private System.Windows.Forms.Button btn_decrypt;
        private System.Windows.Forms.TextBox txt_outputD;
        private System.Windows.Forms.Label lbl_outputD;
        private System.Windows.Forms.TextBox txt_inputD;
        private System.Windows.Forms.Label lbl_inputD;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.TextBox txt_private_keyE;
        private System.Windows.Forms.Label lbl_private_keyE;
        private System.Windows.Forms.Button btn_encrypt;
        private System.Windows.Forms.TextBox txt_output;
        private System.Windows.Forms.Label lbl_output;
        private System.Windows.Forms.TextBox txt_input;
        private System.Windows.Forms.Label lbl_input;
        private System.Windows.Forms.TextBox txt_public_keyE;
        private System.Windows.Forms.Label lbl_public_keyE;
        private System.Windows.Forms.TextBox txt_private_keyD;
        private System.Windows.Forms.Label lbl_private_keyD;
    }
}