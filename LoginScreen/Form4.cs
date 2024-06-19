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
using System.Xml.Linq;

namespace LoginScreen
{
    public partial class Form4 : Form
    {
        string conString = ConfigurationManager.ConnectionStrings["conStr"].ConnectionString;
        //string number, name, type, aciklama;
        public int id;
        public Form4()
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
                        command.CommandText = "IN_SALESGROUPS";
                        command.Parameters.AddWithValue("@SALESNUMBER", txtSalesNumber.Text);
                        command.Parameters.AddWithValue("@SALESNAME", txtSalesName.Text);
                        command.Parameters.AddWithValue("@KOGR", txtKOGR.Text);
                        command.Parameters.AddWithValue("@FET", txtFET.Text);
                        command.Parameters.AddWithValue("@PET", txtPET.Text);
                        command.Parameters.AddWithValue("@ACIKLAMA", txtAciklama.Text);
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
                        command.CommandText = "UP_SALESGROUPS";
                        command.Parameters.AddWithValue("@ID", id);
                        command.Parameters.AddWithValue("@SALESNUMBER", txtSalesNumber.Text);
                        command.Parameters.AddWithValue("@SALESNAME", txtSalesName.Text);
                        command.Parameters.AddWithValue("@KOGR", txtKOGR.Text);
                        command.Parameters.AddWithValue("@FET", txtFET.Text);
                        command.Parameters.AddWithValue("@PET", txtPET.Text);
                        command.Parameters.AddWithValue("@ACIKLAMA", txtAciklama.Text);
                        command.ExecuteNonQuery();
                    }
                }
            }
            MessageBox.Show("Başarılı", "!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }



        private DataTable GetSalesGroupsById(int id)
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
                        cmd.CommandText = "GETSALESGROUPSBYID";
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

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form4_Load_1(object sender, EventArgs e)
        {
            if (id != 0)
            {

                DataTable dt = new DataTable();
                dt = GetSalesGroupsById(id);
                txtSalesName.Text = dt.Rows[0]["SALESNAME"].ToString();
                txtSalesNumber.Text = dt.Rows[0]["SALESNUMBER"].ToString();
                txtAciklama.Text = dt.Rows[0]["ACIKLAMA"].ToString();
                txtKOGR.Text = dt.Rows[0]["KOGR"].ToString();
                txtFET.Text = dt.Rows[0]["FET"].ToString();
                txtPET.Text = dt.Rows[0]["PET"].ToString();
                dgList.DataSource = dt;
            }
            else
            {
                txtAciklama.Text = "";
                txtFET.Text = "";
                txtKOGR.Text = "";
                txtPET.Text = "";
                txtSalesName.Text = "";
                txtSalesNumber.Text = "";
                dgList.DataSource = null;
            }
        }


        private void btnPartNumberAdd_Click(object sender, EventArgs e)
        {
            //küçük ekran açılacak o küçük ekranda girdi yaptıktan sonra ekran kapanacak ve ekleme işlemi yapılmış olunacak
            Form6 form = new Form6();
            form.ShowDialog();
            FillGrid();

        }
        private void FillGrid()
        {
            dgList.DataSource = GetDgData();
            dgList.Columns["ID"].Visible = false;
        }

        private object GetDgData()
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
                    cmd.CommandText = "GETDETAILS";
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

        private void btnDel_Click(object sender, EventArgs e)
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
                        cmd.CommandText = "DEL_DETAILS";
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
            btnDel_Click(null, null);
        }
    }
}
