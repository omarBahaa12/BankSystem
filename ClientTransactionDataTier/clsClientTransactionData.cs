using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace ClientTransactionDataTier
{
    public class clsClientTransactionData
    {
        static private string ConnectionString = "Server=.;Database=Bank_System;User Id=sa;Password=sa123456;";

        static public void AddRecord(int ClientID,string AccountNumber,string OperationName,
            string AnotherInfo,DateTime DateTransaction,double AmountMoney)
        {
            SqlConnection connection = new SqlConnection(ConnectionString);
            string Query = "INSERT INTO TransactionHistory (AccountNumber,OperationName,AomuntMoney" +
                ",AnotherInformation,TransactionDate,ClientID) " +
                "VALUES (@AccountNumber,@OperationName,@AmountMoney,@AnotherInformation" +
                ",@TransactionDate,@ClientID)";
            SqlCommand command =new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@AccountNumber", AccountNumber);
            command.Parameters.AddWithValue("@OperationName", OperationName);
            command.Parameters.AddWithValue("@AmountMoney", AmountMoney);
            command.Parameters.AddWithValue("@AnotherInformation", AnotherInfo);
            command.Parameters.AddWithValue("@TransactionDate", DateTransaction);
            command.Parameters.AddWithValue("@ClientID", ClientID);
            connection.Open();
            try
            {
                int Value=command.ExecuteNonQuery(); 
                if (Value > 0) { return; }
            }
            finally { connection.Close(); }
        }

        static public bool DeleteRecord(int TransactionID)
        {
            SqlConnection connection = new SqlConnection(ConnectionString);
            string Query = "DELETE FROM TransactionHistory WHERE TransactionID=@ID";
            SqlCommand command=new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@ID", TransactionID);
            connection.Open() ;
            try
            {
                int Value = command.ExecuteNonQuery();
                if (Value > 0) 
                {
                    return true;
                }
                return false;
            }
            finally
            { connection.Close(); }
        }

        static public DataTable FindRecord(string AccountNumber) 
        {
            SqlConnection connection = new SqlConnection(ConnectionString);
            string Query = "select * FROM TransactionHistory WHERE AccountNumber like ''+@Account+'%'";
            DataTable table = new DataTable();
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@Account", AccountNumber);
            connection.Open();
            try
            {
                SqlDataReader reader = command.ExecuteReader();
                if(reader.HasRows) 
                {
                    table.Load(reader);
                    return table;
                }
                else
                    return null;
            }
            finally
            { connection.Close(); }
        }
    }
}
