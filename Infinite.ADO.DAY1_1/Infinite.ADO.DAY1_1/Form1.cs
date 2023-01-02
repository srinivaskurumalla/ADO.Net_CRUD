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

namespace Infinite.ADO.DAY1_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //step:1 Create Connection
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source = ICS-LAP-7099\\SQLEXPRESS; Initial Catalog = HR; Integrated Security = true; ";

            //step: 2 Create Command
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "Select * from Position";
            cmd.Connection = con;

            //step: 3 Open Connection
            con.Open();

            //step: 4 Execute the Query
            SqlDataReader reader =  cmd.ExecuteReader();

            //Convert to table Format
            DataTable dt = new DataTable();
            dt.Load(reader);

            //Bound data table to data grid view
            GvPosition.DataSource = dt;

            //Step: 5 Close Connection
            con.Close();
        }
    }
}
