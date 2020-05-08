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
using System.Configuration;



namespace loginapp


{
    public partial class Dashboard : Form
    {
        string ConnectionString;
        string orderconstring;
        string tableval;
        double total = 0;
        static double totalsales = 0;


        public Dashboard()
        {
            InitializeComponent();
           
            ConnectionString = ConfigurationManager.ConnectionStrings["loginapp.Properties.Settings.table_no_1ConnectionString"].ConnectionString;
            orderconstring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\login\ORDER HISTORY\order.mdf;Integrated Security=True;Connect Timeout=30";
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'table_no_1DataSet.TABLE_NO1' table. You can move, or remove it, as needed.



        }

       
        

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            string tablenum = combobox_tableselect.SelectedItem.ToString();
            for (int i = 1; i < 21; i++)
            {
                if (Convert.ToString(i) == tablenum)
                {
                    tableval = "Table" + Convert.ToString(i);

                }
            }


            using (SqlConnection con = new SqlConnection(ConnectionString))
            using (SqlCommand command = new SqlCommand("Select * from " + tableval, con))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {





                DataTable dt1 = new DataTable();
                adapter.Fill(dt1);
                dgv1.DataSource = dt1;
                
                
                int rowsnum = dt1.Rows.Count;
                for (int i = 0; i <= rowsnum - 1; i++)
                {
                    total = total + (Convert.ToDouble((dt1.Rows[i][2].ToString())) * Convert.ToDouble((dt1.Rows[i][3].ToString()))) ;
                    
                }
                
            }
         } 
        
    
    



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }


        private void printDocument1_PrintPage_1(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bmp = new Bitmap(this.dgv1.Width, this.dgv1.Height);
            dgv1.DrawToBitmap(bmp, new Rectangle(50,100 , this.dgv1.Width, this.dgv1.Height));
            Bitmap bmpdate = new Bitmap(this.datetime.Width, this.datetime.Height);
            datetime.DrawToBitmap(bmpdate, new Rectangle(0, 0, this.datetime.Width, this.datetime.Height));

            e.Graphics.DrawImage(bmp, 50, 100);
            e.Graphics.DrawImage(bmpdate, 50, 150);
            e.Graphics.DrawString("Earth Billing: Happy FOOD! ", new Font("Aerial", 20, FontStyle.Bold), Brushes.Black, new Point(250, 50));
            e.Graphics.DrawString("TOTAL:     "+ Convert.ToString(total), new Font("Aerial", 16, FontStyle.Bold), Brushes.Red, new Point(80,400 ));
            totalsales = totalsales + total;
            total = 0;
        }
    
        private void print_Click(object sender, EventArgs e)
        {
            printdialog.Document = printDocument1;
            printdialog.ShowDialog();
            








        }

        private void btn_totalsales_Click(object sender, EventArgs e)
        {
            string timenow = datetime.Value.ToShortTimeString();
            if(timenow == "11:59 PM")
            {
                totalsales = 0;
            }


            lbl_totalsales.Text = Convert.ToString(totalsales);



        }
    }
}
