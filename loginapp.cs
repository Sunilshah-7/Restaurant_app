using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace loginapp
{
    public partial class loginapp : Form
    {
        public loginapp()
        {
            InitializeComponent();
        }

        private void txt_Username_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\login\loginDb.mdf;Integrated Security=True;Connect Timeout=30");
            string query = "Select count  (*) From LOGIN where Username = '" + txt_Username.Text + "' and Password = '" + txt_Password.Text + "'";
            DataTable dt = new DataTable();
            SqlDataAdapter obj_sda = new SqlDataAdapter(query, sqlcon);
            obj_sda.Fill(dt);
            if (dt.Rows[0][0].ToString()=="1")
            {
                this.Hide();
                Dashboard obj_Dashboard = new Dashboard();
                
                obj_Dashboard.Show();
            }
            else
            {
                MessageBox.Show("Error:\n Please check your user ID  and Password!");
            }
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
