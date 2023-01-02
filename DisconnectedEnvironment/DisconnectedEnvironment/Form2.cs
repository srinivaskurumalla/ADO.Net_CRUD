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
    public partial class Form2 : Form
    {
        private SqlConnection con = null;
        private SqlDataAdapter adapter = null;
        private DataSet dataSet = null;
        public Form2()
        {
            InitializeComponent();
        }

        //Generating Primary Key
        public DataColumn[] GeneratePrimaryKey(DataSet dataSet)
        {
            DataColumn[] dc = new DataColumn[1];
            dc[0] = dataSet.Tables["Prd"].Columns["ProductId"];
            dataSet.Tables["Prd"].PrimaryKey = dc;

            return dc;
        }

        //Refresh DataSet
        private void RefreshDataSet()
        {
            using (con = new SqlConnection(ConfigurationManager.ConnectionStrings["NorthWindCon"].ConnectionString))
            {
                using (adapter = new SqlDataAdapter("Select * from Products", con))
                {
                    dataSet = new DataSet();
                    adapter.Fill(dataSet, "Prd");
                    GvProduct.DataSource = dataSet.Tables["Prd"];
                }
            }
        }

        //Reset Fields
        private void Reset()
        {
            TxtProductId.Text = "";
            TxtProductName.Text = "";
            TxtQtyPerUnit.Text = "";
            CbSupplierId.Text = "--Select--";
            TxtUnitsInStock.Text = "";
            CbCategoryId.Text = "--Select--";
            TxtUnitPrice.Text = "";
            LblMsg.Text = "";
        }

        //Search in DB
        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                using (con = new SqlConnection(ConfigurationManager.ConnectionStrings["NorthWindCon"].ConnectionString))
                {
                    using (adapter = new SqlDataAdapter("Select * from Products", con))
                    {
                        dataSet = new DataSet();

                        adapter.Fill(dataSet, "Prd");

                       // dataSet.WriteXml(@"D:\ProdctDataSet.xml");
                        dataSet.WriteXml(@"D:\ProdctDataSet1.xml",XmlWriteMode.WriteSchema);
                        //Creatig Primary Key

                        DataColumn[] dc = new DataColumn[1];
                        dc[0] = dataSet.Tables["Prd"].Columns["ProductId"];
                        dataSet.Tables["Prd"].PrimaryKey = dc;

                        DataRow dr = dataSet.Tables["Prd"].Rows.Find(TxtProductId.Text);

                        if (dr != null)
                        {
                            TxtProductName.Text = dr["ProductName"].ToString();
                            CbCategoryId.Text = dr["CategoryId"].ToString();
                            TxtQtyPerUnit.Text = dr["QuantityPerUnit"].ToString();
                            CbSupplierId.Text = dr["SupplierId"].ToString();
                            TxtUnitPrice.Text = dr["UnitPrice"].ToString();
                            TxtUnitsInStock.Text = dr["UnitsInStock"].ToString();
                        }
                        else
                        {
                            LblMsg.Text = "No Records Found";
                        }
                    }

                }
            }catch(SqlException ex)
            {
                LblMsg.Text = ex.Message;
            }
            catch(Exception ex)
            {
                LblMsg.Text = ex.Message;
            }
                
            
        }
    

       
        //Reset
        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        //Add Product
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                using (con = new SqlConnection(ConfigurationManager.ConnectionStrings["NorthWindCon"].ConnectionString))
                {
                    using (adapter = new SqlDataAdapter("Select * from Products", con))
                    {
                        //Generate Commands
                        SqlCommandBuilder builder = new SqlCommandBuilder(adapter);

                        dataSet = new DataSet();
                        adapter.Fill(dataSet, "Prd");

                        DataTable dt = dataSet.Tables["Prd"];

                        DataRow dr = dt.NewRow();
                        // dr = dt.NewRow();
                        if (dr != null)
                        {
                            dr["ProductName"] = TxtProductName.Text;
                            dr["CategoryId"] = CbCategoryId.SelectedValue;
                            dr["QuantityPerUnit"] = TxtQtyPerUnit.Text;
                            dr["SupplierId"] = CbSupplierId.SelectedValue;
                            dr["UnitPrice"] = TxtUnitPrice.Text;
                            dr["UnitsInStock"] = TxtUnitsInStock.Text;

                            dt.Rows.Add(dr);


                            int res = adapter.Update(dataSet, "Prd");

                            dataSet.Clear();

                            adapter.Fill(dataSet, "Prd");

                            if (res > 0)
                            {
                                int row = dataSet.Tables["Prd"].Rows.Count - 1;

                                LblMsg.Text = $"Product added Successfully with Id : {dataSet.Tables["Prd"].Rows[row]["ProductId"]}";
                            }
                        }
                        //else
                        //{
                        //    LblMsg.Text = "Can't Add Product";
                        //}
                    }
                }
                
                }
            catch(SqlException ex)
            {
                LblMsg.Text = ex.Message;
            }
            catch(Exception ex)
            {
                LblMsg.Text = ex.Message;
            }
            
            
        }

        //Update Product
        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            using(con = new SqlConnection(ConfigurationManager.ConnectionStrings["NorthWindCon"].ConnectionString))
            {
                using(adapter = new SqlDataAdapter("Select * from Products", con))
                {
                    dataSet = new DataSet();
                    adapter.Fill(dataSet, "Prd");
                    SqlCommandBuilder commandBuilder = new SqlCommandBuilder(adapter);

                    //Generate Primary Key
                    dataSet.Tables["Prd"].PrimaryKey = GeneratePrimaryKey(dataSet);

                    DataTable dt = dataSet.Tables["Prd"];
                    //Find the row
                    DataRow dr = dt.Rows.Find(TxtProductId.Text);

                    if(dr != null)
                    {
                        //Perform Update
                        dr.BeginEdit();

                        dr["UnitPrice"] = TxtUnitPrice.Text;
                        dr["UnitsInStock"] = TxtUnitsInStock.Text;
                        //dr["UnitPrice"] = Txt.Text;
                        dr.EndEdit();

                        int res = adapter.Update(dataSet, "Prd");

                        if (res > 0)
                        {
                            LblMsg.Text = "Product Updated Successfully of Id : " + TxtProductId.Text;
                        }
                    }
                    else
                    {
                        LblMsg.Text = "No Record Found";
                    }

                  
                }
            }
        }

        //Delete Product
        private void btnDelete_Click(object sender, EventArgs e)
        {
            
            using (con = new SqlConnection(ConfigurationManager.ConnectionStrings["NorthWindCon"].ConnectionString))
            {
                using (adapter = new SqlDataAdapter("Select * from Products", con))
                {
                    dataSet = new DataSet();
                    adapter.Fill(dataSet, "Prd");
                    SqlCommandBuilder commandBuilder = new SqlCommandBuilder(adapter);

                    //Generate Primary Key
                    dataSet.Tables["Prd"].PrimaryKey = GeneratePrimaryKey(dataSet);

                    DataTable dt = dataSet.Tables["Prd"];
                    //Find the row
                    DataRow dr = dt.Rows.Find(TxtProductId.Text);

                    if (dr != null)
                    {
                        //Perform Delete
                        dr.Delete();
                        int res = adapter.Update(dataSet, "Prd");

                        if (res > 0)
                        {
                            LblMsg.Text = "Product of Id : " + TxtProductId.Text + " deleted successfully";
                        }
                    }
                    else
                    {
                        LblMsg.Text = "No Record Found";
                    }


                }
            }
        }

        //Page Loader
        private void Form2_Load(object sender, EventArgs e)
        {
            using (con = new SqlConnection(ConfigurationManager.ConnectionStrings["NorthWindCon"].ConnectionString))
            {
                using (adapter = new SqlDataAdapter("Select CategoryId,CategoryName from Categories", con))
                {
                    dataSet = new DataSet();
                    adapter.Fill(dataSet, "Categories");

                    //Bound to Combo Box
                    CbCategoryId.DataSource = dataSet.Tables["Categories"];
                    CbCategoryId.DisplayMember = "CategoryName";
                    CbCategoryId.ValueMember = "CategoryId";
                    CbCategoryId.Text = "--Select--";

                }

                using (adapter = new SqlDataAdapter("Select SupplierId,CompanyName from Suppliers", con))
                {
                    dataSet = new DataSet();
                    adapter.Fill(dataSet, "Suppliers");

                    //Bound to Combo Box
                    CbSupplierId.DataSource = dataSet.Tables["Suppliers"];
                    CbSupplierId.DisplayMember = "CompanyName";
                    CbSupplierId.ValueMember = "SupplierId";
                    CbSupplierId.Text = "--Select--";

                }

              
            }
            RefreshDataSet();
        }
       
        //Refresh DataSet
        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            RefreshDataSet();
        }
    }
}
