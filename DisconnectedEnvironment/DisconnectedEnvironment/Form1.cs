using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace DisconnectedEnvironment
{
    public partial class Form1 : Form
    {
        private SqlConnection con = null;
        private SqlDataAdapter adapter = null;
        private DataSet dataSet = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Providing Connection Information
            using(con = new SqlConnection(ConfigurationManager.ConnectionStrings["NorthWindCon"].ConnectionString))
            {
                //Creating data adapter with command and connectio object
                using (adapter = new SqlDataAdapter("Select * from Products", con))
                {
                    dataSet = new DataSet(); //Initialize data set

                    //Filling Data From DB to DataSet 
                    //When Fill() called, Adapter will open the connection and as soon data stored in dataset,
                    //connection will be closed automaticaly
                    adapter.Fill(dataSet, "Prd");


                    //Adding colors to Grid View
                    this.GridProducts.DefaultCellStyle.ForeColor = Color.Blue;
                    this.GridProducts.DefaultCellStyle.BackColor = Color.Beige;

                    //Bound the Grid view
                    GridProducts.DataSource = dataSet.Tables["Prd"];


                }
            }
        }
    }
}
