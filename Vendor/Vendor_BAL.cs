using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.SqlClient;

using System.Net;
using System.Net.Sockets;



namespace Vendor
{
    class Vendor_BAL
    {
        string conString;
        SqlConnection connection;

        //networking
        static int local_port = 100;

        public int LocalPort
        {
            get { return local_port; }
            set { local_port = value; }
        }

        public Vendor_BAL()
        {
            conString = "Data Source=roni;Initial Catalog=inflow_Vendor;Integrated Security=True";
            connection = new SqlConnection(conString);
        }

        public DataSet GetAllProducts()
        {
            try
            {
                using (connection = new SqlConnection(conString))
                {
                    connection.Open();

                    SqlCommand cmd;
                    using (cmd = new SqlCommand("GetAllProducts", connection)
                    {
                        CommandType = CommandType.StoredProcedure,
                    })
                    {
                        DataSet ds = new DataSet();
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        adapter.Fill(ds);

                        return ds;
                    }
                }

            }
            catch (Exception error)
            {
                throw new Exception(error.Message);
            }
        }//end method


        public DataSet GetAllRequests()
        {
            try
            {
                using (connection = new SqlConnection(conString))
                {
                    connection.Open();

                    SqlCommand cmd;
                    using (cmd = new SqlCommand("GetPendingTasks", connection)
                    {
                        CommandType = CommandType.StoredProcedure,
                    })
                    {
                        DataSet ds = new DataSet();
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        adapter.Fill(ds);

                        return ds;
                    }
                }

            }
            catch (Exception error)
            {
                throw new Exception(error.Message);
            }
        }//end method


        public string AddNewProduct(string id, string name, double cost, int qty)
        {
            try
            {
                using (connection = new SqlConnection(conString))
                {
                    connection.Open();

                    SqlCommand cmd;
                    using (cmd = new SqlCommand("InsertNewProduct", connection)
                    {
                        CommandType = CommandType.StoredProcedure,
                    })
                    {
                        cmd.Parameters.AddWithValue("@code", id);
                        cmd.Parameters.AddWithValue("@name", name);
                        cmd.Parameters.AddWithValue("@cost", cost);
                        cmd.Parameters.AddWithValue("@quantity", qty);

                        int affected = cmd.ExecuteNonQuery();
                        if (affected < 0)
                            return "Product inserted into database ...";
                        else
                            return "Could not insert product in database!";

                    }
                }

            }
            catch (Exception error)
            {
                return "Error adding product: " + error.Message;

            }
        } //end method


        public string EditProduct(string code, string name, double cost)
        {
            using (connection = new SqlConnection(conString))
            {
                connection.Open();

                SqlCommand cmd;
                using (cmd = new SqlCommand("EditProduct", connection)
                {
                    CommandType = CommandType.StoredProcedure,
                })
                {
                    cmd.Parameters.AddWithValue("@code", code);
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@cost", cost);

                    int affected = cmd.ExecuteNonQuery();
                    if (affected < 0)

                        return "Product updated ...";
                    else
                        return "Could not update product!";
                }
            }

        }//end method

        public List<string> GetProductNames()
        {
            List<string> names = new List<string>();
            try
            {
                using (connection = new SqlConnection(conString))
                {
                    connection.Open();

                    SqlCommand cmd = new SqlCommand("select name from Products", connection);
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        names.Add(reader[0].ToString());
                    } reader.Close();

                }

                return names;

            }
            catch (Exception error)
            {
                throw new Exception(error.Message);
            }

        }//end method

        public string GetProductPrice(string product)
        {
            string cost = null;
            try
            {
                using (connection = new SqlConnection(conString))
                {
                    connection.Open();

                    SqlCommand cmd = new SqlCommand("select cost from Products", connection);
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        cost = reader[0].ToString();
                    } reader.Close();

                }

                return cost;

            }
            catch (Exception error)
            {
                throw new Exception(error.Message);
            }
        }//end method

        public string AddToRequestLog(string cutomer, string product, int qty)
        {
            using (connection = new SqlConnection(conString))
            {
                connection.Open();

                SqlCommand cmd;
                using (cmd = new SqlCommand("AddRequest", connection)
                {
                    CommandType = CommandType.StoredProcedure,
                })
                {
                    cmd.Parameters.AddWithValue("@customer", cutomer);
                    cmd.Parameters.AddWithValue("@productName", product);
                    cmd.Parameters.AddWithValue("@qty", qty);

                    int affected = cmd.ExecuteNonQuery();
                    if (affected < 0)

                        return "Request added to log...";
                    else
                        return "Could not add request!";
                }
            }
        }//end method

        public string ProcessRequest(int logID)
        {
            using (connection = new SqlConnection(conString))
            {
                connection.Open();

                SqlCommand cmd;
                using (cmd = new SqlCommand("IssueBill", connection)
                {
                    CommandType = CommandType.StoredProcedure,
                })
                {
                    cmd.Parameters.AddWithValue("@logID", logID);

                    int affected = cmd.ExecuteNonQuery();
                    if (affected < 0)

                        return "Order is processed.Stock ready to shipp...";
                    else
                        return "Could not process bill!";
                }
            }
        }//end method


        public DataSet GetInvoices()
        {
            try
            {
                using (connection = new SqlConnection(conString))
                {
                    connection.Open();

                    SqlCommand cmd;
                    using (cmd = new SqlCommand("GetInvoices", connection)
                    {
                        CommandType = CommandType.StoredProcedure,
                    })
                    {
                        DataSet ds = new DataSet();
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        adapter.Fill(ds);

                        return ds;
                    }
                }

            }
            catch (Exception error)
            {
                throw new Exception(error.Message);
            }
        }


        #region HELPERS

        public DataSet InitGridSearch()
        {
            using (connection = new SqlConnection(conString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("select name from Products", connection);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapter.Fill(ds);

                return ds;
            }
        }//end method


        public string GetLocalIp()
        {
            IPHostEntry host;
            host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }
            return IPAddress.Loopback.ToString();
        }

        #endregion


        #region FINAL UPDATE, WS

        public string UpdateStockWithProduct(string product, int qty)
        {
            using (connection = new SqlConnection(conString))
            {
                connection.Open();

                SqlCommand cmd;
                using (cmd = new SqlCommand("vendor_UpdateStock", connection) { CommandType = CommandType.StoredProcedure })
                {
                    cmd.Parameters.AddWithValue("@productID", product);
                    cmd.Parameters.AddWithValue("@quantity", qty);

                    try
                    {
                        int result = cmd.ExecuteNonQuery();

                        if (result < 1) return "UPDATED";
                        else return "not updated";

                    }
                    catch (Exception err)
                    {
                        return err.Message;
                    }
                }
            }
        }

        #endregion
    }
}
