namespace LoginScreen
{
    partial class MainForm
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
            menuStrip1 = new MenuStrip();
            testToolStripMenuItem = new ToolStripMenuItem();
            partNumbersToolStripMenuItem = new ToolStripMenuItem();
            salesGroupsToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { testToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // testToolStripMenuItem
            // 
            testToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { partNumbersToolStripMenuItem, salesGroupsToolStripMenuItem });
            testToolStripMenuItem.Name = "testToolStripMenuItem";
            testToolStripMenuItem.Size = new Size(49, 24);
            testToolStripMenuItem.Text = "Test";
            // 
            // partNumbersToolStripMenuItem
            // 
            partNumbersToolStripMenuItem.Name = "partNumbersToolStripMenuItem";
            partNumbersToolStripMenuItem.Size = new Size(224, 26);
            partNumbersToolStripMenuItem.Text = "Part Numbers";
            partNumbersToolStripMenuItem.Click += partNumbersToolStripMenuItem_Click;
            // 
            // salesGroupsToolStripMenuItem
            // 
            salesGroupsToolStripMenuItem.Name = "salesGroupsToolStripMenuItem";
            salesGroupsToolStripMenuItem.Size = new Size(224, 26);
            salesGroupsToolStripMenuItem.Text = "Sales Groups";
            salesGroupsToolStripMenuItem.Click += salesGroupsToolStripMenuItem_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainForm";
            WindowState = FormWindowState.Maximized;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem testToolStripMenuItem;
        private ToolStripMenuItem partNumbersToolStripMenuItem;
        private ToolStripMenuItem salesGroupsToolStripMenuItem;
    }
}