namespace LoginScreen
{
    partial class Form6
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
            comboBox1 = new ComboBox();
            label2 = new Label();
            rbA = new RadioButton();
            rbD = new RadioButton();
            btnAdd = new Button();
            btnIptal = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 34);
            label1.Name = "label1";
            label1.Size = new Size(154, 25);
            label1.TabIndex = 0;
            label1.Text = "Part Number:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(172, 35);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(263, 28);
            comboBox1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(83, 83);
            label2.Name = "label2";
            label2.Size = new Size(83, 25);
            label2.TabIndex = 2;
            label2.Text = "Status:";
            // 
            // rbA
            // 
            rbA.AutoSize = true;
            rbA.Location = new Point(213, 85);
            rbA.Name = "rbA";
            rbA.Size = new Size(61, 24);
            rbA.TabIndex = 3;
            rbA.TabStop = true;
            rbA.Text = "Aktif";
            rbA.UseVisualStyleBackColor = true;
            // 
            // rbD
            // 
            rbD.AutoSize = true;
            rbD.Location = new Point(332, 85);
            rbD.Name = "rbD";
            rbD.Size = new Size(78, 24);
            rbD.TabIndex = 4;
            rbD.TabStop = true;
            rbD.Text = "Deaktif";
            rbD.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(64, 64, 64);
            btnAdd.ForeColor = SystemColors.ButtonHighlight;
            btnAdd.Location = new Point(83, 150);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(129, 70);
            btnAdd.TabIndex = 15;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnIptal
            // 
            btnIptal.BackColor = Color.Maroon;
            btnIptal.ForeColor = SystemColors.ButtonHighlight;
            btnIptal.Location = new Point(291, 150);
            btnIptal.Name = "btnIptal";
            btnIptal.Size = new Size(129, 70);
            btnIptal.TabIndex = 16;
            btnIptal.Text = "Cancel";
            btnIptal.UseVisualStyleBackColor = false;
            // 
            // Form6
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(493, 244);
            Controls.Add(btnIptal);
            Controls.Add(btnAdd);
            Controls.Add(rbD);
            Controls.Add(rbA);
            Controls.Add(label2);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            Name = "Form6";
            Text = "Form6";
            Load += Form6_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox comboBox1;
        private Label label2;
        private RadioButton rbA;
        private RadioButton rbD;
        private Button btnAdd;
        private Button btnIptal;
    }
}