using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Net;
using System.Security.Policy;

namespace ClientDataTier
{
    static public class clsClientsData
    {
        static private string ConnectionString = "Server=.;Database=Bank_System;User Id=sa;Password=sa123456;";

        static public int AddClient(string FirstName, string MiddleName, string LastName,
            string Email, string Address, string Phone, DateTime BirthDate,
            string NationalID, string Pincode, double Accountbalance,string AccountNumber)
        {
            SqlConnection connection = new SqlConnection(ConnectionString);
            string Query = "INSERT INTO Clients " +
                "(FirstName,MiddleName,LastName,Phone,Address,NationalID,Email,BirthDate,AccountNumber,Pincode,AccountBalance)" +
                "VALUES(@FirstName,@MiddleName,@LastName,@Phone,@Address,@NationalID," +
                "@Email,@BirthDate,@AccountNumber,@Pincode,@AccountBalance)"
                                + "select SCOPE_IDENTITY();";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@FirstName", FirstName);
            command.Parameters.AddWithValue("@MiddleName", MiddleName);
            command.Parameters.AddWithValue("@LastName", LastName);
            command.Parameters.AddWithValue("@Phone", Phone);
            command.Parameters.AddWithValue("@Address", Address);
            command.Parameters.AddWithValue("@NationalID", NationalID);
            command.Parameters.AddWithValue("@Email", Email);
            command.Parameters.AddWithValue("@BirthDate", BirthDate);
            command.Parameters.AddWithValue("@AccountNumber", AccountNumber);
            command.Parameters.AddWithValue("@Pincode", Pincode);
            command.Parameters.AddWithValue("@AccountBalance", Accountbalance);
            connection.Open();
            try
            {
                object RowEffected = command.ExecuteScalar();
                if (RowEffected != null && int.TryParse(RowEffected.ToString(), out int ID))
                {
                    return ID;
                }
            }
            catch
            {
                return -1;
            }
            finally
            {
                connection.Close();
            }
            return -1;

        }

        static public bool FindClientByID(int ID, ref string FirstName, ref string MiddleName, ref string LastName,
            ref string Email, ref string Address, ref string Phone, ref DateTime BithDate,
            ref string NationalID, ref string Pincode, ref double AccountBalance,ref string AccountNumber)
        {
            SqlConnection connection = new SqlConnection(ConnectionString);
            string Query = "Select * from Clients where ClientID=@ID";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@ID", ID);
            connection.Open();
            try
            {
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    FirstName = (string)reader["FirstName"];
                    LastName = (string)reader["LastName"];
                    Address = (string)reader["Address"];
                    Phone = (string)reader["Phone"];
                    BithDate = (DateTime)reader["BirthDate"];
                    NationalID = (string)reader["NationalID"];
                    Pincode = (string)reader["Pincode"];
                    AccountBalance = (double)reader["AccountBalance"];
                    AccountNumber = (string)reader["AccountNumber"];
                    if (Convert.IsDBNull(reader["Email"]))
                        Email = null;
                    else
                    {
                        Email = (string)reader["Email"];
                    }
                    if (Convert.IsDBNull(reader["MiddleName"]))
                        MiddleName = null;
                    else
                    {
                        MiddleName = (string)reader["MiddleName"];
                    }
                    return true;
                }
                reader.Close();
            }
            catch
            {
                return false;
            }
            finally
            {
                connection.Close();
            }
            return false;
        }

        static public bool FindClientByFullName(ref int ID, ref string FirstName, ref string MiddleName, ref string LastName,
            ref string Email, ref string Address, ref string Phone, ref DateTime BithDate,
            ref string NationalID, ref string Pincode, ref double AccountBalance, ref string AccountNumber)
        {
            SqlConnection connection = new SqlConnection(ConnectionString);
            string Query = "Select * from Clients where FirstName like '' +@First+'%' and MiddleName like '' +@Middle+'%' and LastName like '' +@Last+'%'";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@First", FirstName);
            command.Parameters.AddWithValue("@Middle", MiddleName);
            command.Parameters.AddWithValue("@Last", LastName);
            connection.Open();
            try
            {
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    ID=(int)reader["ClientID"];
                    FirstName = (string)reader["FirstName"];
                    LastName = (string)reader["LastName"];
                    Address = (string)reader["Address"];
                    Phone = (string)reader["Phone"];
                    BithDate = (DateTime)reader["BirthDate"];
                    NationalID = (string)reader["NationalID"];
                    Pincode = (string)reader["Pincode"];
                    AccountBalance = (double)reader["AccountBalance"];
                    AccountNumber = (string)reader["AccountNumber"];
                    if (Convert.IsDBNull(reader["Email"]))
                        Email = null;
                    else
                    {
                        Email = (string)reader["Email"];
                    }
                    if (Convert.IsDBNull(reader["MiddleName"]))
                        MiddleName = null;
                    else
                    {
                        MiddleName = (string)reader["MiddleName"];
                    }
                    return true;
                }
                reader.Close();
            }
            catch
            {
                return false;
            }
            finally
            {
                connection.Close();
            }
            return false;
        }
            

        static public DataTable FindClientListByName(string FirstName)
        {
            DataTable dataTable = new DataTable();
            SqlConnection connection = new SqlConnection(ConnectionString);
            string Query = "Select * from Clients where FirstName like '' +@first+'%'";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@first", FirstName);
            connection.Open();
            try
            {
                SqlDataReader reader = command.ExecuteReader();
                if(reader.HasRows) 
                {
                    dataTable.Load(reader);
                    return dataTable;
                }
                reader.Close();
            }
            catch
            {
                return dataTable;
            }
            finally
            {
                connection.Close();
            }
            return dataTable;
        }

        static public bool DeleteClient(int ID) 
        {
            SqlConnection connection = new SqlConnection(ConnectionString);
            string Query = "DELETE FROM Clients WHERE ClientID=@ID";
            SqlCommand command= new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@ID", ID);
            connection.Open();
            try
            {
                int RowEffected = command.ExecuteNonQuery();
                if(RowEffected > 0) 
                {
                    return true;
                }
                return false;
            }
            finally 
            {
                connection.Close(); 
            }
        }

        static public bool UpdateClient( int ID,  string FirstName,  string MiddleName,  string LastName,
            string Email, string Address,  string Phone,  DateTime BithDate,
            string NationalID,  string Pincode,  double AccountBalance,  string AccountNumber)
        {
            SqlConnection connection= new SqlConnection(ConnectionString);
            string Query = "UPDATE Clients SET " +
                "FirstName = @FirstName,MiddleName =@MiddleName,LastName=@LastName,Phone=@Phone" +
                ",Address =@Address,NationalID=@NationalID,Email=@Email,BirthDate=@BirthDate," +
                "AccountNumber=@AccountNumber,Pincode=@Pincode,AccountBalance=@AccountBalance WHERE ClientID=@ID";
            SqlCommand cmd= new SqlCommand(Query, connection);
            cmd.Parameters.AddWithValue("@ID", ID);
            cmd.Parameters.AddWithValue("@FirstName", FirstName);
            cmd.Parameters.AddWithValue("@MiddleName", MiddleName);
            cmd.Parameters.AddWithValue("@LastName", LastName);
            cmd.Parameters.AddWithValue("@Phone", Phone);
            cmd.Parameters.AddWithValue("@Address", Address);
            cmd.Parameters.AddWithValue("@NationalID", NationalID);
            cmd.Parameters.AddWithValue("@Email", Email);
            cmd.Parameters.AddWithValue("@AccountNumber", AccountNumber);
            cmd.Parameters.AddWithValue("@Pincode", Pincode);
            cmd.Parameters.AddWithValue("@AccountBalance", AccountBalance);
            cmd.Parameters.AddWithValue("@BirthDate", BithDate);
            connection.Open();
            try
            {
                int RowEffected = cmd.ExecuteNonQuery();
                if(RowEffected > 0)  { return true; }

                return false;
            }
            catch { return false; }

            finally { connection.Close(); }
        }

        static public DataTable ClientList()
        {
            SqlConnection connection= new SqlConnection(ConnectionString);
            string Query = "Select * from Clients";
            DataTable dataTable = new DataTable();
            SqlCommand command= new SqlCommand(Query, connection);
            connection.Open();
            try
            {
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                    dataTable.Load(reader);
                return dataTable;
            }
            catch { return null; }

            finally { connection.Close(); }
        }

        public static bool FindAccountByAccountNumber(ref int ID, ref string FirstName, ref string MiddleName,
            ref string LastName, ref string Email, ref string Address, ref string Phone,
            ref DateTime BirthDate, ref string NationalID, ref string Pincode,
            ref double AccountBalance,string AccountNumber)
        {
            SqlConnection connection = new SqlConnection(ConnectionString);
            string Query = "Select * from Clients where AccountNumber=@AN";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@AN", AccountNumber);
            connection.Open();
            try
            {
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    ID = (int)reader["ClientID"];
                    FirstName = (string)reader["FirstName"];
                    LastName = (string)reader["LastName"];
                    Address = (string)reader["Address"];
                    Phone = (string)reader["Phone"];
                    BirthDate = (DateTime)reader["BirthDate"];
                    NationalID = (string)reader["NationalID"];
                    Pincode = (string)reader["Pincode"];
                    AccountBalance = (double)reader["AccountBalance"];
                    AccountNumber = (string)reader["AccountNumber"];
                    if (Convert.IsDBNull(reader["Email"]))
                        Email = null;
                    else
                    {
                        Email = (string)reader["Email"];
                    }
                    if (Convert.IsDBNull(reader["MiddleName"]))
                        MiddleName = null;
                    else
                    {
                        MiddleName = (string)reader["MiddleName"];
                    }
                    return true;
                }
                reader.Close();
            }
            catch
            {
                return false;
            }
            finally
            {
                connection.Close();
            }
            return false;
        }

        public static bool FindAccountByAccountNumberAndPincode(ref int ID, ref string FirstName, ref string MiddleName,
            ref string LastName, ref string Email, ref string  Address, ref string Phone,
            ref DateTime BirthDate, ref string NationalID, string Pincode,
            ref double AccountBalance,ref string AccountNumber)
        {
            SqlConnection connection = new SqlConnection(ConnectionString);
            string Query = "Select * from Clients where AccountNumber=@AN and Pincode=@PC";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@AN", AccountNumber);
            command.Parameters.AddWithValue("@PC", Pincode);
            connection.Open();
            try
            {
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    ID = (int)reader["ClientID"];
                    FirstName = (string)reader["FirstName"];
                    LastName = (string)reader["LastName"];
                    Address = (string)reader["Address"];
                    Phone = (string)reader["Phone"];
                    BirthDate = (DateTime)reader["BirthDate"];
                    NationalID = (string)reader["NationalID"];
                    Pincode = (string)reader["Pincode"];
                    AccountBalance = (double)reader["AccountBalance"];
                    AccountNumber = (string)reader["AccountNumber"];
                    if (Convert.IsDBNull(reader["Email"]))
                        Email = null;
                    else
                    {
                        Email = (string)reader["Email"];
                    }
                    if (Convert.IsDBNull(reader["MiddleName"]))
                        MiddleName = null;
                    else
                    {
                        MiddleName = (string)reader["MiddleName"];
                    }
                    return true;
                }
                reader.Close();
            }
            catch
            {
                return false;
            }
            finally
            {
                connection.Close();
            }
            return false;
        }


        public static DataTable GetAccountBalances(string FirstName,string MiddleName,string LastName)
        {
            SqlConnection connection=new SqlConnection(ConnectionString);
            connection.Open();
            DataTable accountBalances = new DataTable();
            string query = "Select ClientID,FirstName,MiddleName,LastName,AccountNumber,AccountBalance from Clients where FirstName like ''+@FirstName+'%' " +
                "and MiddleName like ''+@MiddleName+'%' and LastName like ''+@LastName+'%'";
            SqlCommand command=new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@FirstName", FirstName);
            command.Parameters.AddWithValue("@MiddleName", MiddleName);
            command.Parameters.AddWithValue("@LastName", LastName);
            try
            {
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    accountBalances.Load(reader);
                    
                }
                reader.Close();
                return accountBalances;
            }
            finally
            { 
                connection.Close();
            }           
        }
    }
}
