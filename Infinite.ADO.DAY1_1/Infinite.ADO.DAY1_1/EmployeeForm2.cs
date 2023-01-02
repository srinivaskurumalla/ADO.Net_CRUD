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
    public partial class EmployeeForm2 : Form
    {
        private DataTable dt = null;
        public EmployeeForm2()
        {
            InitializeComponent();
        }

        private void EmployeeForm2_Load(object sender, EventArgs e)
        {
            
            String cs = "Data Source = ICS-LAP-7099\\SQLEXPRESS; Initial Catalog = HR; Integrated Security = true; ";

            SqlConnection con = new SqlConnection(cs);

            SqlCommand cmd = new SqlCommand("Select * from Employee", con);

            if(con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlDataReader reader= cmd.ExecuteReader();
            if (reader.HasRows)
            {
                dt = new DataTable();
                dt.Load(reader);
                EmpGv.DataSource= dt;
            }
            else
            {
                EmpLbl.ForeColor = Color.Blue;
                EmpLbl.Text = "No Records Found";
            }
            reader.Close();
            cmd.Dispose();
            con.Close();
        }
    }
}
