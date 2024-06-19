using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace LoginScreen
{
    public partial class Form1 : Form
    {
        string conString = ConfigurationManager.ConnectionStrings["conStr"].ConnectionString;
        string kullaniciAdi, sifre;
        public int id;


        public Form1()
        {
            InitializeComponent();
        }


        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGiris_Click_1(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(conString))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "GIRISKONTROL";
                    cmd.Parameters.AddWithValue("@USERNAME", txtKullaniciAdi.Text);
                    cmd.Parameters.AddWithValue("@PASSWORD", txtPassword.Text);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.SelectCommand = cmd;
                    da.Fill(dt);
                }
            }
            if (dt.Rows.Count > 0)  //doluysa
            {
                // Giri� Ba�ar�l�
                MessageBox.Show("Giri� Ba�ar�l�", "!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                // Hatal� Giri�.
                MessageBox.Show("Hatal� Giri�\nKullan�c� ad� veya �ifre hatal�", "!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}