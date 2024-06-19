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
    public partial class Form2 : Form
    {
        string conString = ConfigurationManager.ConnectionStrings["conStr"].ConnectionString;
        //string number, name, type, aciklama;
        public int id;
        public Form2()
        {
            InitializeComponent();
        }

        private void btnGiris_Click(object sender, EventArgs e)  
        {
            if (id == 0)
            {
                using (SqlConnection connection = new SqlConnection(conString))
                {
                    connection.Open();

                    using (SqlCommand command = connection.CreateCommand())
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.CommandText = "IN_PARTNUMBER";
                        command.Parameters.AddWithValue("@NUMBER", txtPartNumbers.Text);
                        command.Parameters.AddWithValue("@PARTNAME", txtName.Text);
                        command.Parameters.AddWithValue("@PARTTYPE", rbP.Checked == true ? 'P' : 'G');
                        command.Parameters.AddWithValue("@ACIKLAMA", txtExplanation.Text);
                        command.ExecuteNonQuery();
                    }
                }


            }
            else
            {
                using (SqlConnection connection = new SqlConnection(conString))
                {
                    connection.Open();

                    using (SqlCommand command = connection.CreateCommand())
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.CommandText = "UP_PARTNUMBER";
                        command.Parameters.AddWithValue("@ID", id);
                        command.Parameters.AddWithValue("@NUMBER", txtPartNumbers.Text);
                        command.Parameters.AddWithValue("@PARTNAME", txtName.Text);
                        command.Parameters.AddWithValue("@PARTTYPE", rbP.Checked == true ? 'P' : 'G');
                        command.Parameters.AddWithValue("@ACIKLAMA", txtExplanation.Text);
                        command.ExecuteNonQuery();
                    }
                }
            }
            MessageBox.Show("Başarılı", "!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            if (id != 0)
            {
                DataTable dt = new DataTable();
                dt = GetPartNumbersById(id);
                txtName.Text = dt.Rows[0]["PARTNAME"].ToString();
                txtPartNumbers.Text = dt.Rows[0]["NUMBER"].ToString();
                txtExplanation.Text = dt.Rows[0]["ACIKLAMA"].ToString();
                if (dt.Rows[0]["PARTTYPE"].ToString() == "P")
                {
                    rbP.Checked = true;
                }
                else
                {
                    rbG.Checked = true;
                }
            }
        }

        private DataTable GetPartNumbersById(int id)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection conn = new SqlConnection(conString))
                {
                    conn.Open();
                    using (SqlCommand cmd = conn.CreateCommand())
                    {
                        cmd.Connection = conn;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = "GETPARTNUMBERSBYID";
                        cmd.Parameters.AddWithValue("@ID", id);
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        da.SelectCommand = cmd;
                        da.Fill(dt);
                    }
                }

                return dt;
            }

            catch (Exception)
            {
                throw;
            }
        }
    }
}
