namespace EncryptCrypts
{
    partial class FormMenu
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
            this.btn_RSA = new System.Windows.Forms.Button();
            this.btn_viginere = new System.Windows.Forms.Button();
            this.btn_caesar = new System.Windows.Forms.Button();
            this.btn_AES = new System.Windows.Forms.Button();
            this.btn_key_generation = new System.Windows.Forms.Button();
            this.btn_quit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_RSA
            // 
            this.btn_RSA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(140)))), ((int)(((byte)(221)))));
            this.btn_RSA.BackgroundImage = global::EncryptCrypts.Properties.Resources.RSA;
            this.btn_RSA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_RSA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_RSA.Location = new System.Drawing.Point(213, 81);
            this.btn_RSA.Name = "btn_RSA";
            this.btn_RSA.Size = new System.Drawing.Size(48, 49);
            this.btn_RSA.TabIndex = 1;
            this.btn_RSA.UseVisualStyleBackColor = false;
            this.btn_RSA.Click += new System.EventHandler(this.btn_RSA_Click);
            // 
            // btn_viginere
            // 
            this.btn_viginere.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(140)))), ((int)(((byte)(221)))));
            this.btn_viginere.BackgroundImage = global::EncryptCrypts.Properties.Resources.Vigenere;
            this.btn_viginere.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_viginere.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_viginere.Location = new System.Drawing.Point(480, 81);
            this.btn_viginere.Name = "btn_viginere";
            this.btn_viginere.Size = new System.Drawing.Size(48, 49);
            this.btn_viginere.TabIndex = 3;
            this.btn_viginere.UseVisualStyleBackColor = false;
            this.btn_viginere.Click += new System.EventHandler(this.btn_viginere_Click);
            // 
            // btn_caesar
            // 
            this.btn_caesar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(140)))), ((int)(((byte)(221)))));
            this.btn_caesar.BackgroundImage = global::EncryptCrypts.Properties.Resources.Caesar;
            this.btn_caesar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_caesar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_caesar.Location = new System.Drawing.Point(345, 81);
            this.btn_caesar.Name = "btn_caesar";
            this.btn_caesar.Size = new System.Drawing.Size(48, 49);
            this.btn_caesar.TabIndex = 2;
            this.btn_caesar.UseVisualStyleBackColor = false;
            this.btn_caesar.Click += new System.EventHandler(this.btn_caesar_Click);
            // 
            // btn_AES
            // 
            this.btn_AES.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(140)))), ((int)(((byte)(221)))));
            this.btn_AES.BackgroundImage = global::EncryptCrypts.Properties.Resources.AES;
            this.btn_AES.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_AES.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AES.Location = new System.Drawing.Point(89, 81);
            this.btn_AES.Name = "btn_AES";
            this.btn_AES.Size = new System.Drawing.Size(48, 49);
            this.btn_AES.TabIndex = 0;
            this.btn_AES.UseVisualStyleBackColor = false;
            this.btn_AES.Click += new System.EventHandler(this.btn_AES_Click);
            // 
            // btn_key_generation
            // 
            this.btn_key_generation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(140)))), ((int)(((byte)(221)))));
            this.btn_key_generation.BackgroundImage = global::EncryptCrypts.Properties.Resources.RSA;
            this.btn_key_generation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_key_generation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_key_generation.Location = new System.Drawing.Point(221, 164);
            this.btn_key_generation.Name = "btn_key_generation";
            this.btn_key_generation.Size = new System.Drawing.Size(32, 32);
            this.btn_key_generation.TabIndex = 4;
            this.btn_key_generation.UseVisualStyleBackColor = false;
            this.btn_key_generation.Click += new System.EventHandler(this.btn_key_generation_Click);
            // 
            // btn_quit
            // 
            this.btn_quit.Location = new System.Drawing.Point(268, 278);
            this.btn_quit.Name = "btn_quit";
            this.btn_quit.Size = new System.Drawing.Size(75, 23);
            this.btn_quit.TabIndex = 38;
            this.btn_quit.Text = "QUIT";
            this.btn_quit.UseVisualStyleBackColor = true;
            this.btn_quit.Click += new System.EventHandler(this.btn_quit_Click);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(624, 361);
            this.Controls.Add(this.btn_quit);
            this.Controls.Add(this.btn_key_generation);
            this.Controls.Add(this.btn_viginere);
            this.Controls.Add(this.btn_caesar);
            this.Controls.Add(this.btn_RSA);
            this.Controls.Add(this.btn_AES);
            this.Name = "FormMenu";
            this.Text = "Main Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_AES;
        private System.Windows.Forms.Button btn_RSA;
        private System.Windows.Forms.Button btn_caesar;
        private System.Windows.Forms.Button btn_viginere;
        private System.Windows.Forms.Button btn_key_generation;
        private System.Windows.Forms.Button btn_quit;
    }
}

