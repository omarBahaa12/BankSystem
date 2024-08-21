using ClientTransactionDataTier;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientTransactionsBusinessTier
{
    public class clsClientTransactions
    {
        public int _TransactionID {  get; set; }
        public int _ClientID { get; set; }
        public string _AccountNumber { get; set; }
        public string _OperationName { get; set; }
        public string _AnotherInformations { get; set; }
        public DateTime _TransactionDate { get; set; }
        public double _AmountMoney { get; set; }

        public static void AddTransactionRecord(int ClientID,string AccountNumber,string OperationName,
            string AnotherInformations,DateTime TransactionDate,double AmountMoney)
        {
            clsClientTransactionData.AddRecord(ClientID, AccountNumber,
                OperationName, AnotherInformations, TransactionDate, AmountMoney);
        }

        public static bool Delete(int TransactionID)
        {
            if(clsClientTransactionData.DeleteRecord(TransactionID))
                return true;
            return false;
        }

        public static DataTable Find(string AccountNumber)
        {
            return clsClientTransactionData.FindRecord(AccountNumber);
        }

    }
}
