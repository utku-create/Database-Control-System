using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginScreen
{
    public partial class Form6 : Form
    {
        string conString = ConfigurationManager.ConnectionStrings["conStr"].ConnectionString;
        public int salesGroupId;
        public int id;
        public Form6()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(conString))
            {
                connection.Open();

                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "IN_PARTNUMSTOSALEDET";
                    command.Parameters.AddWithValue("@SALESGROUPID", 4);
                    command.Parameters.AddWithValue("@PARTNUMBERID", Convert.ToInt32(comboBox1.SelectedValue));
                    command.Parameters.AddWithValue("@STATUS", rbA.Checked == true ? 'A' : 'D');
                    command.Parameters.AddWithValue("@UPDATEDTIME", System.DateTime.Now);
                    command.ExecuteNonQuery();
                }
            }
            this.Close();


        }

        private void Form6_Load(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(conString))
            {
                try
                {
                    using (SqlCommand cmd = conn.CreateCommand())
                    {
                        cmd.Connection = conn;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = "SELECTPROCEDURE6";
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        conn.Open();
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        comboBox1.DisplayMember = "NAME"; // değiş
                        comboBox1.ValueMember = "ID";
                        comboBox1.DataSource = dt;
                    }
                }
                catch (Exception ex)
                {
                    // write exception info to log or anything else
                    MessageBox.Show("Error occured!");
                }
            }
        }
    }
}
