namespace EncryptCrypts
{
    partial class FormRSAKeyGenerator
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
            this.btn_generate = new System.Windows.Forms.Button();
            this.lbl_public_D = new System.Windows.Forms.Label();
            this.txt_public_D = new System.Windows.Forms.TextBox();
            this.txt_public_E = new System.Windows.Forms.TextBox();
            this.lbl_public_E = new System.Windows.Forms.Label();
            this.txt_private_E = new System.Windows.Forms.TextBox();
            this.lbl_private_E = new System.Windows.Forms.Label();
            this.txt_private_D = new System.Windows.Forms.TextBox();
            this.lbl_private_D = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_exit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_generate
            // 
            this.btn_generate.Location = new System.Drawing.Point(275, 271);
            this.btn_generate.Name = "btn_generate";
            this.btn_generate.Size = new System.Drawing.Size(75, 23);
            this.btn_generate.TabIndex = 0;
            this.btn_generate.Text = "Generate";
            this.btn_generate.UseVisualStyleBackColor = true;
            this.btn_generate.Click += new System.EventHandler(this.btn_generate_Click);
            // 
            // lbl_public_D
            // 
            this.lbl_public_D.AutoSize = true;
            this.lbl_public_D.Location = new System.Drawing.Point(339, 57);
            this.lbl_public_D.Name = "lbl_public_D";
            this.lbl_public_D.Size = new System.Drawing.Size(111, 13);
            this.lbl_public_D.TabIndex = 1;
            this.lbl_public_D.Text = "Public Decryption Key";
            // 
            // txt_public_D
            // 
            this.txt_public_D.Location = new System.Drawing.Point(460, 54);
            this.txt_public_D.Name = "txt_public_D";
            this.txt_public_D.Size = new System.Drawing.Size(100, 20);
            this.txt_public_D.TabIndex = 2;
            // 
            // txt_public_E
            // 
            this.txt_public_E.Location = new System.Drawing.Point(187, 54);
            this.txt_public_E.Name = "txt_public_E";
            this.txt_public_E.Size = new System.Drawing.Size(100, 20);
            this.txt_public_E.TabIndex = 4;
            // 
            // lbl_public_E
            // 
            this.lbl_public_E.AutoSize = true;
            this.lbl_public_E.Location = new System.Drawing.Point(66, 57);
            this.lbl_public_E.Name = "lbl_public_E";
            this.lbl_public_E.Size = new System.Drawing.Size(110, 13);
            this.lbl_public_E.TabIndex = 3;
            this.lbl_public_E.Text = "Public Encryption Key";
            // 
            // txt_private_E
            // 
            this.txt_private_E.Location = new System.Drawing.Point(187, 102);
            this.txt_private_E.Name = "txt_private_E";
            this.txt_private_E.Size = new System.Drawing.Size(100, 20);
            this.txt_private_E.TabIndex = 6;
            // 
            // lbl_private_E
            // 
            this.lbl_private_E.AutoSize = true;
            this.lbl_private_E.Location = new System.Drawing.Point(66, 105);
            this.lbl_private_E.Name = "lbl_private_E";
            this.lbl_private_E.Size = new System.Drawing.Size(114, 13);
            this.lbl_private_E.TabIndex = 5;
            this.lbl_private_E.Text = "Private Encryption Key";
            // 
            // txt_private_D
            // 
            this.txt_private_D.Location = new System.Drawing.Point(460, 106);
            this.txt_private_D.Name = "txt_private_D";
            this.txt_private_D.Size = new System.Drawing.Size(100, 20);
            this.txt_private_D.TabIndex = 8;
            // 
            // lbl_private_D
            // 
            this.lbl_private_D.AutoSize = true;
            this.lbl_private_D.Location = new System.Drawing.Point(339, 109);
            this.lbl_private_D.Name = "lbl_private_D";
            this.lbl_private_D.Size = new System.Drawing.Size(115, 13);
            this.lbl_private_D.TabIndex = 7;
            this.lbl_private_D.Text = "Private Decryption Key";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.DarkGray;
            this.pictureBox1.Location = new System.Drawing.Point(309, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(10, 232);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(275, 315);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(75, 23);
            this.btn_exit.TabIndex = 10;
            this.btn_exit.Text = "BACK";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // FormRSAKeyGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 361);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txt_private_D);
            this.Controls.Add(this.lbl_private_D);
            this.Controls.Add(this.txt_private_E);
            this.Controls.Add(this.lbl_private_E);
            this.Controls.Add(this.txt_public_E);
            this.Controls.Add(this.lbl_public_E);
            this.Controls.Add(this.txt_public_D);
            this.Controls.Add(this.lbl_public_D);
            this.Controls.Add(this.btn_generate);
            this.Name = "FormRSAKeyGenerator";
            this.Text = "frm_RSA_key_generator";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_generate;
        private System.Windows.Forms.Label lbl_public_D;
        private System.Windows.Forms.TextBox txt_public_D;
        private System.Windows.Forms.TextBox txt_public_E;
        private System.Windows.Forms.Label lbl_public_E;
        private System.Windows.Forms.TextBox txt_private_E;
        private System.Windows.Forms.Label lbl_private_E;
        private System.Windows.Forms.TextBox txt_private_D;
        private System.Windows.Forms.Label lbl_private_D;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_exit;
    }
}