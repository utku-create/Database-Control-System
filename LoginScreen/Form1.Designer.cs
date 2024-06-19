namespace LoginScreen
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label2 = new Label();
            txtKullaniciAdi = new TextBox();
            txtPassword = new TextBox();
            label3 = new Label();
            label1 = new Label();
            btnGiris = new Button();
            btnIptal = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(208, 203);
            label2.Name = "label2";
            label2.Size = new Size(185, 32);
            label2.TabIndex = 1;
            label2.Text = "Kullanıcı Adı:";
            // 
            // txtKullaniciAdi
            // 
            txtKullaniciAdi.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtKullaniciAdi.Location = new Point(399, 201);
            txtKullaniciAdi.Name = "txtKullaniciAdi";
            txtKullaniciAdi.Size = new Size(234, 34);
            txtKullaniciAdi.TabIndex = 2;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassword.Location = new Point(399, 241);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(234, 34);
            txtPassword.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(314, 239);
            label3.Name = "label3";
            label3.Size = new Size(79, 32);
            label3.TabIndex = 5;
            label3.Text = "Şifre:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Gray;
            label1.Font = new Font("Bahnschrift Condensed", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(125, 36);
            label1.TabIndex = 0;
            label1.Text = "MAN LOGIN ";
            // 
            // btnGiris
            // 
            btnGiris.BackColor = Color.FromArgb(64, 64, 64);
            btnGiris.ForeColor = Color.White;
            btnGiris.Location = new Point(233, 325);
            btnGiris.Name = "btnGiris";
            btnGiris.Size = new Size(135, 66);
            btnGiris.TabIndex = 7;
            btnGiris.Text = "Giriş";
            btnGiris.UseVisualStyleBackColor = false;
            btnGiris.Click += btnGiris_Click_1;
            // 
            // btnIptal
            // 
            btnIptal.BackColor = Color.Maroon;
            btnIptal.ForeColor = Color.White;
            btnIptal.Location = new Point(473, 325);
            btnIptal.Name = "btnIptal";
            btnIptal.Size = new Size(135, 66);
            btnIptal.TabIndex = 8;
            btnIptal.Text = "İptal";
            btnIptal.UseVisualStyleBackColor = false;
            btnIptal.Click += btnIptal_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Logo_MAN;
            pictureBox1.Location = new Point(102, 58);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(645, 357);
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(833, 445);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(btnGiris);
            Controls.Add(btnIptal);
            Controls.Add(txtPassword);
            Controls.Add(txtKullaniciAdi);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private TextBox txtKullaniciAdi;
        private TextBox txtPassword;
        private Label label3;
        private Label label1;
        private Button btnGiris;
        private Button btnIptal;
        private PictureBox pictureBox1;
    }
}