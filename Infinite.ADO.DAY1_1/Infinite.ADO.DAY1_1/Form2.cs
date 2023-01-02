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
using System.Data.Common;

namespace Infinite.ADO.DAY1_1
{
    
    public partial class Form2 : Form
    {
        private SqlConnection con = null;
        private SqlCommand cmd = null;
        public Form2()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
           // string cs = "Data Source = ICS-LAP-7099\\SQLEXPRESS; Initial Catalog = NorthWind; Integrated Security = true; ";

             con = new SqlConnection(ConfigurationManager.ConnectionStrings["NorthWindCon"].ConnectionString);

            string query = "Select ProductName,SupplierID,CategoryID,QuantityPerUnit,UnitPrice,UnitsInStock from Products where ProductID = @ProductId";
             cmd = new SqlCommand(query, con);

            if(con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            cmd.Parameters.AddWithValue("@ProductId",TxtProductId.Text);

            SqlDataReader reader = cmd.ExecuteReader();

            if(reader.HasRows)
            {
                reader.Read();
                TxtProductName.Text = reader["Productname"].ToString();
                TxtSupplierId.Text = reader["SupplierId"].ToString();
                TxtCategoryId.Text = reader["CategoryId"].ToString();
                TxtQtyPerUnit.Text = reader["QuantityPerUnit"].ToString();
                TxtUnitPrice.Text = reader["UnitPrice"].ToString();
                TxtUnitsInStock.Text = reader["UnitsInStock"].ToString();
            }
            else
            {
                LblMsg.Text = "No Records";
            }
            reader.Close();
            cmd.Dispose();
            con.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {

                 con = new SqlConnection(ConfigurationManager.ConnectionStrings["NorthWindCon"].ConnectionString);
             cmd = new SqlCommand("usp_InsertProducts", con);

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@ProductName", TxtProductName.Text);
            cmd.Parameters.AddWithValue("@SupplierId", TxtSupplierId.Text);
            cmd.Parameters.AddWithValue("@CategoryId", TxtCategoryId.Text);
            cmd.Parameters.AddWithValue("@QuantityPerUnit", TxtQtyPerUnit.Text);
            cmd.Parameters.AddWithValue("@UnitPrice", TxtUnitPrice.Text);
            cmd.Parameters.AddWithValue("@UnitsInStock", TxtUnitsInStock.Text);

                // get output parameter

                SqlParameter IdParameter = new SqlParameter("@Id", SqlDbType.Int)
                {
                    Direction= ParameterDirection.Output
                };
                cmd.Parameters.Add(IdParameter);

            if(con.State == ConnectionState.Closed)
            {
                con.Open();
            }
             int res = cmd.ExecuteNonQuery();

                if (res > 0)
                {
                    LblMsg.Text = $"Product Added successfully with Id : {IdParameter.Value}";
                }
            }
            catch(SqlException se)
            {
                Reset();
                LblMsg.Text = $"Sql Error :{se.Message} ";
            }
            catch(Exception e1)
            {
                Reset();
                LblMsg.Text = $"Error: {e1.Message} ";
            }
            finally
            {
               cmd?.Dispose();
               con?.Close();
            }
        
           
        }

        private  void Reset()
        {
            TxtProductId.Text = "";
            TxtProductName.Text = "";
            TxtQtyPerUnit.Text = "";
            TxtSupplierId.Text = "";
            TxtUnitsInStock.Text = "";
            TxtCategoryId.Text = "";
            TxtUnitPrice.Text = "";
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                using (con = new SqlConnection(ConfigurationManager.ConnectionStrings["NorthWindCon"].ConnectionString))
                {
                    using (cmd = new SqlCommand("usp_DeleteProductById", con))
                    {

                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@ProductId", TxtProductId.Text);

                        SqlParameter idParameter = new SqlParameter("@Id", SqlDbType.Int)
                        {
                            Direction = ParameterDirection.Output
                        };

                        cmd.Parameters.Add(idParameter);

                        if (con.State == ConnectionState.Closed)
                        {
                            con.Open();
                        }
                        if (MessageBox.Show("Do you want to delete this Product?", "Delete Product", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            int res = cmd.ExecuteNonQuery();

                            if (res > 0)
                            {
                                LblMsg.Text = $"Product Deleted successfully with Id :{idParameter.Value} and Name is {TxtProductName.Text}";
                            }
                        }
                    }
                }
            }
            catch (SqlException se)
            {
                LblMsg.Text = se.Message;
            }
            catch (Exception ex)
            {
                LblMsg.Text = ex.Message;
            }

            //finally
            //{
            //    cmd?.Dispose();
            //    con?.Close();
            //}
        
        }

        private void UpdateBtnClick(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection(ConfigurationManager.ConnectionStrings["NorthWindCon"].ConnectionString);
                cmd = new SqlCommand("usp_UpdateProduct", con);

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@ProductId", TxtProductId.Text);
                cmd.Parameters.AddWithValue("@UnitPrice", TxtUnitPrice.Text);
                cmd.Parameters.AddWithValue("@UnitsInStock", TxtUnitsInStock.Text);

                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                int res = cmd.ExecuteNonQuery();

                if (res > 0)
                {
                    LblMsg.Text = $"Product Updated successfully ";
                }
            }
            catch(SqlException se)
            {
                LblMsg.Text = se.Message;
            }
            catch(Exception ex)
            {
                LblMsg.Text = ex.Message;
            }
            finally
            {
                cmd?.Dispose();
                con?.Close();
            }


        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection(ConfigurationManager.ConnectionStrings["NorthWindCon"].ConnectionString);

                string query = "Select ProductName,SupplierID,CategoryID,QuantityPerUnit,UnitPrice,UnitsInStock from Products where ProductID = @ProductId";
                cmd = new SqlCommand(query, con);

                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                cmd.Parameters.AddWithValue("@ProductId", TxtProductId.Text);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    reader.Read();
                    TxtProductName.Text = reader["Productname"].ToString();
                    TxtSupplierId.Text = reader["SupplierId"].ToString();
                    TxtCategoryId.Text = reader["CategoryId"].ToString();
                    TxtQtyPerUnit.Text = reader["QuantityPerUnit"].ToString();
                    TxtUnitPrice.Text = reader["UnitPrice"].ToString();
                    TxtUnitsInStock.Text = reader["UnitsInStock"].ToString();
                }
                reader.Close();
            }
            catch (SqlException se)
            {
                LblMsg.Text = se.Message;
            }
            catch (Exception e1)
            {
                LblMsg.Text = e1.Message;
            }
            finally { 
           
            cmd?.Dispose();
            con?.Close();
        }

        }
    }
    
}
