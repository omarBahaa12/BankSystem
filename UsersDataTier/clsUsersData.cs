using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.CodeDom;
using System.Data;
using static System.Net.Mime.MediaTypeNames;
using System.Security.Policy;

namespace UsersDataTier
{
    public static class clsUsersData
    {
        static private string ConnectionString = "Server=.;Database=Bank_System;User Id=sa;Password=sa123456;";

        static public int AddNewUser(string UsersName,string Password,int Permissions,string Image)
        {
            SqlConnection connection=new SqlConnection(ConnectionString);
            string Query = "INSERT INTO Users" +
                "(userName,Password,Permissions,Image)VALUES " +
                "(@userName ,@Password,@Permissions,@Image)"+
                "select SCOPE_IDENTITY();";
            SqlCommand command=new SqlCommand(Query,connection);
            command.Parameters.AddWithValue("@username", UsersName);
            command.Parameters.AddWithValue("@Password", Password);
            command.Parameters.AddWithValue("@Permissions", Permissions);
            command.Parameters.AddWithValue("@Image", Image);
            connection.Open();
            try
            {
                object EffectedRow=command.ExecuteScalar();
                if(EffectedRow!=null &&int.TryParse(EffectedRow.ToString(),out int ID))
                {
                    connection.Close();
                    return ID;
                }
                else 
                {
                    connection.Close();
                    return -1;
                }
            }
            catch 
            {
                connection.Close();
                return -1;
            }
        }

        static public bool FindUserByUserNameAndPassword(ref string UserName,ref int Permissions, ref int ID,string Password,ref string Image) 
        {
            SqlConnection sqlConnection=new SqlConnection(ConnectionString);
            string Query = "SELECT * from Users where UserName=@username and Password=@password";
            SqlCommand cmd=new SqlCommand(Query,sqlConnection);
            cmd.Parameters.AddWithValue ("@username", UserName);
            cmd.Parameters.AddWithValue("@password",Password);
            sqlConnection.Open();
            try
            {
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    UserName = (string)reader["UserName"];
                    ID = (int)reader["UserID"];                    
                    Permissions = (int)reader["Permissions"];
                    if (!Convert.IsDBNull(reader["Image"]))
                        Image = (string)reader["Image"];
                    return true;
                }
                reader.Close();
                return false;
            }
            catch
            {                
                return false;
            }
            finally
            { 
                sqlConnection.Close();
            }
                       
        }

        static public bool FindUserByUserID(ref string UserName, ref int Permissions,int ID,ref string Password,ref string Image)
        {
            SqlConnection sqlConnection = new SqlConnection(ConnectionString);
            string Query = "SELECT * from Users where UserID=@ID";
            SqlCommand cmd = new SqlCommand(Query, sqlConnection);
            cmd.Parameters.AddWithValue("@ID", ID);           
            sqlConnection.Open();
            try
            {
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    UserName = (string)reader["UserName"];
                    Permissions = (int)reader["Permissions"];
                    Password = (string)reader["Password"];
                    Permissions = (int)reader["Permissions"];
                    if (!Convert.IsDBNull(reader["Image"]))
                        Image = (string)reader["Image"];
                }
                sqlConnection.Close();
                reader.Close();
                return true;
            }
            catch
            { }
            finally
            {
                sqlConnection.Close();

            }
            return false;
        }

        static public bool Delete(int UserID)
        {
            SqlConnection connection= new SqlConnection(ConnectionString);
            string Query = "DELETE FROM Users WHERE UserID=@ID";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@ID", UserID);
            try
            {
                connection.Open();
                int Row = command.ExecuteNonQuery();
                if (Row != 0)
                {
                    connection.Close();
                    return true;
                }
            }
            finally 
            { 
                connection.Close(); 
                
            }
            return false;
        }

        static public bool UpdateUser(int UserID,string UserName,string Password,int Permissions,string Image)
        {
            SqlConnection connection = new SqlConnection(ConnectionString);
            string Query = "UPDATE Users SET " +
                "UserName =@userName,Password=@Password,Permissions =@Permissions,Image=@Image " +
                "WHERE UserID=@ID";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@ID", UserID);
            command.Parameters.AddWithValue("@UserName", UserName);
            command.Parameters.AddWithValue("@Password", Password);
            command.Parameters.AddWithValue("@Permissions", Permissions);
            command.Parameters.AddWithValue("@Image", Image);
            connection.Open();
            try
            {
                
                int Row = command.ExecuteNonQuery();
                if (Row != 0)
                {
                    connection.Close();
                    return true;
                }
            }
            finally
            {
                connection.Close();

            }
            return false;
        }

        static public DataTable GetUsersList()
        {
            SqlConnection connection=new SqlConnection(ConnectionString);
            DataTable table = new DataTable();
            string Query = "select * from Users";
            SqlCommand command= new SqlCommand(Query, connection);
            connection.Open();
            try 
            {
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                    table.Load(reader);
                reader.Close();
            }
            finally 
            {
                connection.Close();
            }
            return table;
        }

        public static DataTable GetUsersByFullName(ref string FullName)
        {
            SqlConnection sqlConnection = new SqlConnection(ConnectionString);
            DataTable table = new DataTable();
            String Query = "Select * from Users Where UserName like ''+@Full+'%'";
            SqlCommand command=new SqlCommand(Query, sqlConnection);
            command.Parameters.AddWithValue("@Full", FullName);
            sqlConnection.Open();
            try
            {
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                    table.Load(reader);
                reader.Close();
                return table;
            }
            finally 
            {
                sqlConnection.Close();
            }
        }

        public static bool FindUserByUserName(ref string UserName, ref int Permissions, ref int ID, ref string Password, ref string Image)
        {
            SqlConnection sqlConnection = new SqlConnection(ConnectionString);
            string Query = "SELECT * from Users where UserName=@username";
            SqlCommand cmd = new SqlCommand(Query, sqlConnection);
            cmd.Parameters.AddWithValue("@username", UserName);
            sqlConnection.Open();
            try
            {
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    UserName = (string)reader["UserName"];
                    ID = (int)reader["UserID"];
                    Permissions = (int)reader["Permissions"];
                    Password = (string)reader["Password"];
                    if (!Convert.IsDBNull(reader["Image"]))
                        Image = (string)reader["Image"];
                    return true;
                }
                reader.Close();
                return false;
            }
            catch
            {
                return false;
            }
            finally
            {
                sqlConnection.Close();
            }
        }

        static public bool IsExist(int ID)
        {
            SqlConnection connection = new SqlConnection(ConnectionString);
            string Query = "SELECT CASE WHEN EXISTS" +
                "(SELECT *FROM Users WHERE UserID =@ID)" +
                "THEN CAST(1 AS BIT)" +
                "ELSE CAST(0 AS BIT) END";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@ID", ID);
            connection.Open();
            try
            {
                object Value = command.ExecuteScalar();
                if(Convert.ToInt32(Value)==1)
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

        static public bool IsExist(string Name)
        {
            SqlConnection connection = new SqlConnection(ConnectionString);
            string Query = "SELECT CASE WHEN EXISTS" +
                "(SELECT *FROM Users WHERE UserName =@ID)" +
                "THEN CAST(1 AS BIT)" +
                "ELSE CAST(0 AS BIT) END";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@ID", Name);
            connection.Open();
            try
            {
                object Value = command.ExecuteScalar();
                if (Convert.ToInt32(Value) == 1)
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
    }
}
