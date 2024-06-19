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
    public partial class Form5 : Form
    {
        int id;
        string conString = ConfigurationManager.ConnectionStrings["conStr"].ConnectionString;
        public Form5()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            FillGrid();
        }

        private void FillGrid()
        {
            dgList.DataSource = GetSalesGroups();
            dgList.Columns["ID"].Visible = false;
        }

        private object GetSalesGroups()
        {
            DataTable dtTable = new DataTable();
            try
            {

                SqlConnection conn = new SqlConnection(conString);

                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "GETSALESGROUPS";
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.SelectCommand = cmd;
                    da.Fill(dtTable);
                    conn.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return dtTable;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            Form4 form = new Form4();
            form.id = 0;
            form.ShowDialog();
            FillGrid();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Form4 form = new Form4();
            form.id = id;
            form.ShowDialog();
            FillGrid();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {

                using (SqlConnection conn = new SqlConnection(conString))
                {
                    conn.Open();
                    using (SqlCommand cmd = conn.CreateCommand())
                    {

                        cmd.Connection = conn;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = "DEL_SALESGROUPS";
                        cmd.Parameters.AddWithValue("@ID", id);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
            FillGrid();
        }

        private void dgList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = Convert.ToInt32(dgList.Rows[dgList.CurrentRow.Index].Cells["ID"].Value);
        }

        private void dgList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnUpdate_Click(null, null);
        }
    }
}
