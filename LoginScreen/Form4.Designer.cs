namespace LoginScreen
{
    partial class Form4
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
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            txtSalesNumber = new TextBox();
            txtSalesName = new TextBox();
            TEXT = new Label();
            label = new Label();
            txtKOGR = new MaskedTextBox();
            txtFET = new MaskedTextBox();
            label3 = new Label();
            txtPET = new MaskedTextBox();
            label4 = new Label();
            label5 = new Label();
            txtAciklama = new TextBox();
            btnGiris = new Button();
            btnIptal = new Button();
            dgList = new DataGridView();
            btnPartNumberAdd = new Button();
            btnDel = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgList).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Logo_MAN;
            pictureBox1.Location = new Point(0, -2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(118, 66);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Gray;
            label1.Font = new Font("Bahnschrift Condensed", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(0, 67);
            label1.Name = "label1";
            label1.Size = new Size(208, 36);
            label1.TabIndex = 1;
            label1.Text = "MAN SALES GROUPS";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(53, 144);
            label2.Name = "label2";
            label2.Size = new Size(201, 35);
            label2.TabIndex = 2;
            label2.Text = "Sales Number:";
            // 
            // txtSalesNumber
            // 
            txtSalesNumber.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            txtSalesNumber.Location = new Point(260, 140);
            txtSalesNumber.Name = "txtSalesNumber";
            txtSalesNumber.Size = new Size(408, 39);
            txtSalesNumber.TabIndex = 3;
            // 
            // txtSalesName
            // 
            txtSalesName.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            txtSalesName.Location = new Point(260, 185);
            txtSalesName.Name = "txtSalesName";
            txtSalesName.Size = new Size(408, 39);
            txtSalesName.TabIndex = 4;
            // 
            // TEXT
            // 
            TEXT.AutoSize = true;
            TEXT.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point);
            TEXT.Location = new Point(84, 189);
            TEXT.Name = "TEXT";
            TEXT.Size = new Size(170, 35);
            TEXT.TabIndex = 5;
            TEXT.Text = "Sales Name:";
            // 
            // label
            // 
            label.AutoSize = true;
            label.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label.Location = new Point(137, 237);
            label.Name = "label";
            label.Size = new Size(117, 35);
            label.TabIndex = 6;
            label.Text = "KOGR:";
            // 
            // txtKOGR
            // 
            txtKOGR.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point);
            txtKOGR.Location = new Point(260, 230);
            txtKOGR.Mask = "0000";
            txtKOGR.Name = "txtKOGR";
            txtKOGR.Size = new Size(71, 42);
            txtKOGR.TabIndex = 7;
            txtKOGR.ValidatingType = typeof(int);
            // 
            // txtFET
            // 
            txtFET.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point);
            txtFET.Location = new Point(260, 278);
            txtFET.Mask = "00/00";
            txtFET.Name = "txtFET";
            txtFET.Size = new Size(71, 42);
            txtFET.TabIndex = 8;
            txtFET.ValidatingType = typeof(int);
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(172, 285);
            label3.Name = "label3";
            label3.Size = new Size(82, 35);
            label3.TabIndex = 9;
            label3.Text = "FET:";
            // 
            // txtPET
            // 
            txtPET.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point);
            txtPET.Location = new Point(260, 326);
            txtPET.Mask = "00/00";
            txtPET.Name = "txtPET";
            txtPET.Size = new Size(71, 42);
            txtPET.TabIndex = 10;
            txtPET.ValidatingType = typeof(int);
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(172, 333);
            label4.Name = "label4";
            label4.Size = new Size(82, 35);
            label4.TabIndex = 11;
            label4.Text = "PET:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(62, 378);
            label5.Name = "label5";
            label5.Size = new Size(192, 35);
            label5.TabIndex = 12;
            label5.Text = "*Explanation:";
            // 
            // txtAciklama
            // 
            txtAciklama.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            txtAciklama.Location = new Point(260, 374);
            txtAciklama.Multiline = true;
            txtAciklama.Name = "txtAciklama";
            txtAciklama.Size = new Size(408, 135);
            txtAciklama.TabIndex = 13;
            // 
            // btnGiris
            // 
            btnGiris.BackColor = Color.FromArgb(64, 64, 64);
            btnGiris.ForeColor = SystemColors.ButtonHighlight;
            btnGiris.Location = new Point(260, 532);
            btnGiris.Name = "btnGiris";
            btnGiris.Size = new Size(129, 70);
            btnGiris.TabIndex = 14;
            btnGiris.Text = "Giriş";
            btnGiris.UseVisualStyleBackColor = false;
            btnGiris.Click += btnGiris_Click;
            // 
            // btnIptal
            // 
            btnIptal.BackColor = Color.Maroon;
            btnIptal.ForeColor = SystemColors.ButtonHighlight;
            btnIptal.Location = new Point(539, 532);
            btnIptal.Name = "btnIptal";
            btnIptal.Size = new Size(129, 70);
            btnIptal.TabIndex = 15;
            btnIptal.Text = "İptal";
            btnIptal.UseVisualStyleBackColor = false;
            btnIptal.Click += btnIptal_Click;
            // 
            // dgList
            // 
            dgList.AllowUserToAddRows = false;
            dgList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgList.Location = new Point(737, 140);
            dgList.Name = "dgList";
            dgList.ReadOnly = true;
            dgList.RowHeadersVisible = false;
            dgList.RowHeadersWidth = 51;
            dgList.RowTemplate.Height = 29;
            dgList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgList.Size = new Size(535, 369);
            dgList.TabIndex = 16;
            dgList.CellClick += dgList_CellClick;
            dgList.CellDoubleClick += dgList_CellDoubleClick;
            // 
            // btnPartNumberAdd
            // 
            btnPartNumberAdd.BackColor = Color.FromArgb(64, 64, 64);
            btnPartNumberAdd.ForeColor = SystemColors.ButtonHighlight;
            btnPartNumberAdd.Location = new Point(1007, 532);
            btnPartNumberAdd.Name = "btnPartNumberAdd";
            btnPartNumberAdd.Size = new Size(129, 70);
            btnPartNumberAdd.TabIndex = 17;
            btnPartNumberAdd.Text = "Part Number Add";
            btnPartNumberAdd.UseVisualStyleBackColor = false;
            btnPartNumberAdd.Click += btnPartNumberAdd_Click;
            // 
            // btnDel
            // 
            btnDel.BackColor = Color.Maroon;
            btnDel.ForeColor = SystemColors.ButtonHighlight;
            btnDel.Location = new Point(1143, 532);
            btnDel.Name = "btnDel";
            btnDel.Size = new Size(129, 70);
            btnDel.TabIndex = 18;
            btnDel.Text = "Delete";
            btnDel.UseVisualStyleBackColor = false;
            btnDel.Click += btnDel_Click;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(1307, 622);
            Controls.Add(btnDel);
            Controls.Add(btnPartNumberAdd);
            Controls.Add(dgList);
            Controls.Add(btnIptal);
            Controls.Add(btnGiris);
            Controls.Add(txtAciklama);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtPET);
            Controls.Add(label3);
            Controls.Add(txtFET);
            Controls.Add(txtKOGR);
            Controls.Add(label);
            Controls.Add(TEXT);
            Controls.Add(txtSalesName);
            Controls.Add(txtSalesNumber);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "Form4";
            Text = "Form4";
            Load += Form4_Load_1;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private TextBox txtSalesNumber;
        private TextBox txtSalesName;
        private Label TEXT;
        private Label label;
        private MaskedTextBox txtKOGR;
        private MaskedTextBox txtFET;
        private Label label3;
        private MaskedTextBox txtPET;
        private Label label4;
        private Label label5;
        private TextBox txtAciklama;
        private Button btnGiris;
        private Button btnIptal;
        private DataGridView dgList;
        private Button btnPartNumberAdd;
        private Button btnDel;
    }
}