namespace LoginScreen
{
    partial class Form2
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
            label1 = new Label();
            label2 = new Label();
            txtName = new TextBox();
            label3 = new Label();
            rbP = new RadioButton();
            rbG = new RadioButton();
            label4 = new Label();
            txtExplanation = new TextBox();
            label5 = new Label();
            pictureBox1 = new PictureBox();
            btnGiris = new Button();
            btnIptal = new Button();
            txtPartNumbers = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(49, 144);
            label1.Name = "label1";
            label1.Size = new Size(204, 35);
            label1.TabIndex = 0;
            label1.Text = "Part Numbers:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(155, 189);
            label2.Name = "label2";
            label2.Size = new Size(98, 35);
            label2.TabIndex = 2;
            label2.Text = "Name:";
            // 
            // txtName
            // 
            txtName.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            txtName.Location = new Point(259, 185);
            txtName.Name = "txtName";
            txtName.Size = new Size(413, 39);
            txtName.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(166, 230);
            label3.Name = "label3";
            label3.Size = new Size(87, 35);
            label3.TabIndex = 4;
            label3.Text = "Type:";
            // 
            // rbP
            // 
            rbP.AutoSize = true;
            rbP.Font = new Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            rbP.Location = new Point(341, 230);
            rbP.Name = "rbP";
            rbP.Size = new Size(52, 37);
            rbP.TabIndex = 5;
            rbP.TabStop = true;
            rbP.Text = "P";
            rbP.UseVisualStyleBackColor = true;
            // 
            // rbG
            // 
            rbG.AutoSize = true;
            rbG.Font = new Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            rbG.Location = new Point(531, 231);
            rbG.Name = "rbG";
            rbG.Size = new Size(55, 37);
            rbG.TabIndex = 6;
            rbG.TabStop = true;
            rbG.Text = "G";
            rbG.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(61, 274);
            label4.Name = "label4";
            label4.Size = new Size(192, 35);
            label4.TabIndex = 7;
            label4.Text = "*Explanation:";
            // 
            // txtExplanation
            // 
            txtExplanation.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            txtExplanation.Location = new Point(259, 274);
            txtExplanation.Multiline = true;
            txtExplanation.Name = "txtExplanation";
            txtExplanation.Size = new Size(413, 205);
            txtExplanation.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Gray;
            label5.Font = new Font("Bahnschrift Condensed", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(0, 71);
            label5.Name = "label5";
            label5.Size = new Size(211, 36);
            label5.TabIndex = 9;
            label5.Text = "MAN PART NUMBERS";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Logo_MAN;
            pictureBox1.Location = new Point(0, -2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(117, 70);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // btnGiris
            // 
            btnGiris.BackColor = Color.FromArgb(64, 64, 64);
            btnGiris.ForeColor = SystemColors.ButtonHighlight;
            btnGiris.Location = new Point(259, 495);
            btnGiris.Name = "btnGiris";
            btnGiris.Size = new Size(129, 70);
            btnGiris.TabIndex = 11;
            btnGiris.Text = "Giriş";
            btnGiris.UseVisualStyleBackColor = false;
            btnGiris.Click += btnGiris_Click;
            // 
            // btnIptal
            // 
            btnIptal.BackColor = Color.Maroon;
            btnIptal.ForeColor = Color.White;
            btnIptal.Location = new Point(541, 495);
            btnIptal.Name = "btnIptal";
            btnIptal.Size = new Size(131, 70);
            btnIptal.TabIndex = 12;
            btnIptal.Text = "İptal";
            btnIptal.UseVisualStyleBackColor = false;
            btnIptal.Click += btnIptal_Click;
            // 
            // txtPartNumbers
            // 
            txtPartNumbers.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            txtPartNumbers.Location = new Point(259, 140);
            txtPartNumbers.Name = "txtPartNumbers";
            txtPartNumbers.Size = new Size(413, 39);
            txtPartNumbers.TabIndex = 13;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(779, 593);
            Controls.Add(txtPartNumbers);
            Controls.Add(btnIptal);
            Controls.Add(btnGiris);
            Controls.Add(pictureBox1);
            Controls.Add(rbG);
            Controls.Add(txtExplanation);
            Controls.Add(label4);
            Controls.Add(rbP);
            Controls.Add(label3);
            Controls.Add(txtName);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label5);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtName;
        private Label label3;
        private RadioButton rbP;
        private RadioButton rbG;
        private Label label4;
        private TextBox txtExplanation;
        private Label label5;
        private PictureBox pictureBox1;
        private Button btnGiris;
        private Button btnIptal;
        private TextBox txtPartNumbers;
    }
}