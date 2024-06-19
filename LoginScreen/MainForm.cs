using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginScreen
{
    public partial class MainForm : Form
    {
        Form3 listPartNumbers;
        Form4 listSaleGroup;
        int id;
        public MainForm()
        {
            InitializeComponent();
        }

        private void partNumbersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listPartNumbers = new Form3();
            listPartNumbers.MdiParent = this;
            listPartNumbers.Show();


        }

        private void salesGroupsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listSaleGroup = new Form4();
            listSaleGroup.MdiParent = this;
            listSaleGroup.id = 4; //burdaki id
            listSaleGroup.Show();
            
        }

        

    }
}
