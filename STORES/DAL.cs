using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Data.SqlClient;
using System.Data.Common;
using System.IO;

namespace STORES
{
    class DAL
    {
        string connectionString = @"Data Source=DESKTOP-H514NOT\SQLEXPRESS; Initial catalog=Store;Integrated Security=True;";
        public ArrayList GetAllStores()
        {
            ArrayList allStores = new ArrayList();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand com = new SqlCommand("SELECT * FROM Stores Order By Name", con);

                try
                {
                    con.Open();
                    SqlDataReader dr = com.ExecuteReader();
                    if (dr.HasRows)
                        foreach (DbDataRecord result in dr)
                            allStores.Add(result);
                }
                catch
                {

                }
            }
            return allStores;
        }

        internal ArrayList GetAllSteetForStores(object StoresID)
        {
            ArrayList allStreet = new ArrayList();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = String.Format("SELECT * FROM Street Where StoresID='{0}'", StoresID);
                SqlCommand com = new SqlCommand(query, con);
                try
                {
                    con.Open();
                    SqlDataReader dr = com.ExecuteReader();
                    if (dr.HasRows)
                        foreach (DbDataRecord result in dr)
                            allStreet.Add(result);
                }
                catch
                {

                }
            }
            return allStreet;
        }

        internal ArrayList GetAllProductForStreet(object StreetID)
        {
            ArrayList allProduct = new ArrayList();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = String.Format("SELECT * FROM Product Where StreetID='{0}'", StreetID);
                SqlCommand com = new SqlCommand(query, con);
                try
                {
                    con.Open();
                    SqlDataReader dr = com.ExecuteReader();
                    if (dr.HasRows)
                        foreach (DbDataRecord result in dr)
                            allProduct.Add(result);
                }
                catch
                {

                }
            }
            return allProduct;
        }

        public bool SaveNewStore(string ID, string Name)
        {
            bool flagResult = false;
            string query = string.Format("INSERT INTO Stores([ID], [Name]) VALUES ('{0}', '{1}')", ID, Name);

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand com = new SqlCommand(query, con);
                try
                {
                    con.Open();
                    if (com.ExecuteNonQuery() == 1)
                        flagResult = true;
                }
                catch
                {

                }
            }
            return flagResult;
        }

        public bool SaveNewStreet(Guid ID, string Name, Guid StoresID)
        {
            bool flagResult = false;
            string query = string.Format("INSERT INTO Street([ID], [Name], [StoresID]) VALUES ('{0}', '{1}', '{2}')", ID, Name, StoresID);

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand com = new SqlCommand(query, con);
                try
                {
                    con.Open();
                    if (com.ExecuteNonQuery() == 1)
                        flagResult = true;
                }
                catch (Exception)
                {

                }
            }
            return flagResult;
        }

        public bool SaveNewProduct(Guid ID, string Name, int Quantity, string Price, Guid StreetID, string Colour, string Connector,
            string Height, string Width, string Barcode)
        {
            bool flagResult = false;
            string query = string.Format("INSERT INTO Product([ID], [Name], [Quantity], [Price], [StreetID]," +
                " [Colour], [Connector], [Height], [Width], [Barcode]) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}'," +
                " '{5}', '{6}', '{7}', '{8}', '{9}')", ID, Name, Quantity, Price, StreetID, Colour, Connector, Height, Width, Barcode);

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand com = new SqlCommand(query, con);
                try
                {
                    con.Open();
                    if (com.ExecuteNonQuery() == 1)
                        flagResult = true;
                }
                catch (Exception)
                {

                }
            }
            return flagResult;
        }

        internal bool SaveDBToLocalFile()
        {
            bool flagResult = true;

            StreamWriter file = new StreamWriter(new FileStream("Stores.csv", FileMode.Create), Encoding.GetEncoding(1251));

            string query;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    query = "SELECT * FROM Stores";
                    SqlCommand com = new SqlCommand(query, con);
                    con.Open();
                    SqlDataReader reader = com.ExecuteReader();

                    file.WriteLine("Start of file");
                    file.WriteLine(@"""ID""; ""Name""");
                    if(reader.HasRows)
                    {
                        while(reader.Read())
                        {
                            file.WriteLine(@"""" + reader.GetValue(0).ToString() + @""";""" + reader.GetString(1) 
                                + @"""", Encoding.ASCII);
                        }

                    }
                    else 
                    {
                        file.WriteLine("No one row to save");
                    }
                    file.WriteLine("End of file");
                    flagResult = true;
                    file.Dispose();
                }
                catch
                {
                    flagResult = false;
                }
            }

            file = new StreamWriter(new FileStream("Street.csv", FileMode.Create), Encoding.GetEncoding(1251));

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    query = "SELECT * FROM Street";
                    SqlCommand com = new SqlCommand(query, con);
                    con.Open();
                    SqlDataReader reader = com.ExecuteReader();

                    file.WriteLine("Start of file");
                    file.WriteLine(@"""ID""; ""Name""; ""StoresID""");
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            file.WriteLine(@"""" + reader.GetValue(0).ToString() + @""";""" + reader.GetString(1)
                                + @""";""" + reader.GetValue(2).ToString() + @"""", Encoding.ASCII);
                        }

                    }
                    else
                    {
                        file.WriteLine("No one row to save");
                    }
                    file.WriteLine("End of file");
                    flagResult = true;
                    file.Dispose();
                }
                catch
                {
                    flagResult = false;
                }
            }

            file = new StreamWriter(new FileStream("Product.csv", FileMode.Create), Encoding.GetEncoding(1251));

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    query = "SELECT * FROM Product";
                    SqlCommand com = new SqlCommand(query, con);
                    con.Open();
                    SqlDataReader reader = com.ExecuteReader();

                    file.WriteLine("Start of file");
                    file.WriteLine(@"""ID""; ""Name""; ""Quantity""; ""Price""; ""StreetID""; ""Colour""; ""Connector""; ""Height""; ""Width""; ""Barcode""");
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            file.WriteLine(@"""" + reader.GetValue(0).ToString() + @""";""" + reader.GetString(1).ToString()
                                + @""";""" + reader.GetValue(2).ToString() + @""";""" + reader.GetString(3).ToString() + @""";""" + 
                                reader.GetValue(4).ToString() + @""";""" + reader.GetString(5).ToString()
                                + @""";""" + reader[6].ToString() + @""";""" + reader.GetString(7).ToString() + @""";""" + 
                                reader.GetString(8).ToString() + @""";""" + reader.GetString(9).ToString() + @"""", Encoding.ASCII);
                        }

                    }
                    else
                    {
                        file.WriteLine("No one row to save");
                    }
                    file.WriteLine("End of file");
                    flagResult = true;
                    file.Dispose();
                }
                catch
                {
                    flagResult = false;
                }
            }
            return flagResult;
        }
    }  
}
