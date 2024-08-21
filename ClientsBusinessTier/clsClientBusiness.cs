using ClientDataTier;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace ClientsBusinessTier
{
    public class clsClientsBusiness
    {
        public int _ID {  get; set; }
        public string _FirstName { get; set; }
        public string _MiddleName {  get; set; }
        public string _LastName { get; set; }
        public string _Email { get; set; }
        public string _Address {  get; set; }
        public string _Phone {  get; set; }
        public DateTime _BirthDate { get; set; }
        public string _NationalID { get; set; }
        public string _AccountNumber {  get; set; }
        public string _Pincode {  get; set; }
        public double _AccountBalance { get; set; }

        public clsClientsBusiness() { }
        public clsClientsBusiness(int ID,string FirstName,string MiddleName,string LastName,
            string Email,string Address,string Phone,DateTime BithDate,
            string NationalID,string Pincode,double AccountBalance,string AccounNumber="")

        {
            _Address = Address;
            _FirstName = FirstName;
            _MiddleName = MiddleName;
            _BirthDate = BithDate;
            _NationalID = NationalID;
            _Email = Email;
            _ID = ID;
            _LastName = LastName;
            _Phone = Phone; 
            _Pincode = Pincode;
            _AccountBalance = AccountBalance;
            if(string.IsNullOrWhiteSpace(AccounNumber))
                _AccountNumber=clsClientsBusiness.RandomAccountNumber();
            else
            {
                _AccountNumber = AccounNumber;
            }
        }


        public bool AddClient()
        {
            _ID=clsClientsData.AddClient(_FirstName, _MiddleName, _LastName,
                _Email,_Address, _Phone,_BirthDate,_NationalID,_Pincode,_AccountBalance,_AccountNumber);
            if(_ID!=-1)
                return true; 
            return false;
        }

        static public clsClientsBusiness FindClientByID(int ID)
        {
            string Firstname = "", MiddleName = "", LastName = "", Email = "",
                Address = "", Phone = "", NationalID = "",AccountNumber="",Pincode="";           
            double AccountBalance=0;
            DateTime BirthDate = new DateTime();
            if(clsClientsData.FindClientByID(ID,ref Firstname,ref MiddleName,ref LastName,ref Email,
                ref Address,ref Phone,ref BirthDate,ref NationalID,ref Pincode,ref AccountBalance,ref AccountNumber))
                return new clsClientsBusiness(ID,Firstname,MiddleName,LastName,Email,
                    Address,Phone,BirthDate,NationalID,Pincode,AccountBalance,AccountNumber);
            return null;
        }

        static public clsClientsBusiness FindClientByFullName(string[] FullName)
        {
            string  Email = "", Address = "", Phone = "", NationalID = "",
                AccountNumber = "",LastName="",Middle="",Pincode="";
            int ID=0;
            double AccountBalance = 0;
            DateTime BirthDate = new DateTime();
            if (FullName.Length == 3)
            {
                if (clsClientsData.FindClientByFullName(ref ID, ref FullName[0], ref FullName[1], ref FullName[2], ref Email,
                ref Address, ref Phone, ref BirthDate, ref NationalID, ref Pincode, ref AccountBalance, ref AccountNumber))
                    return new clsClientsBusiness(ID, FullName[0], FullName[1], FullName[2], Email,
                        Address, Phone, BirthDate, NationalID, Pincode, AccountBalance, AccountNumber);
            }

            else if(FullName.Length==2)
            {
                if (clsClientsData.FindClientByFullName(ref ID, ref FullName[0], ref FullName[1], ref LastName, ref Email,
                ref Address, ref Phone, ref BirthDate, ref NationalID, ref Pincode, ref AccountBalance, ref AccountNumber))
                    return new clsClientsBusiness(ID, FullName[0], FullName[1], LastName, Email,
                        Address, Phone, BirthDate, NationalID, Pincode, AccountBalance, AccountNumber);
            }

            else
            {
                if (clsClientsData.FindClientByFullName(ref ID, ref FullName[0], ref Middle, ref LastName, ref Email,
                ref Address, ref Phone, ref BirthDate, ref NationalID, ref Pincode, ref AccountBalance, ref AccountNumber))
                    return new clsClientsBusiness(ID, FullName[0],Middle, LastName, Email,
                        Address, Phone, BirthDate, NationalID, Pincode, AccountBalance, AccountNumber);
            }

            return null;
        }

        static public clsClientsBusiness FindAccountByAccountNumber(string AccountNumber)
        {
            string Firstname = "", MiddleName = "", LastName = "", Email = "",
                            Address = "", Phone = "", NationalID = "", Pincode = "";
            double AccountBalance = 0;
            int ID = 0;
            DateTime BirthDate = new DateTime();
            if (clsClientsData.FindAccountByAccountNumber(ref ID, ref Firstname, ref MiddleName, ref LastName, ref Email,
                ref Address, ref Phone, ref BirthDate, ref NationalID, ref Pincode, ref AccountBalance, AccountNumber))
                return new clsClientsBusiness(ID, Firstname, MiddleName, LastName, Email,
                    Address, Phone, BirthDate, NationalID, Pincode, AccountBalance, AccountNumber);
            return null;
        }

        static public clsClientsBusiness FindAccountByAccountNumberAndPincode(string AccountNumber,string Pincode)
        {
            string Firstname = "", MiddleName = "", LastName = "", Email = "",
                            Address = "", Phone = "", NationalID = "";
            double AccountBalance = 0;
            int ID = 0;
            DateTime BirthDate = new DateTime();
            if (clsClientsData.FindAccountByAccountNumberAndPincode(ref ID, ref Firstname, ref MiddleName, ref LastName, ref Email,
                ref Address, ref Phone, ref BirthDate, ref NationalID,Pincode, ref AccountBalance,ref AccountNumber))
                return new clsClientsBusiness(ID, Firstname, MiddleName, LastName, Email,
                    Address, Phone, BirthDate, NationalID, Pincode, AccountBalance, AccountNumber);
            return null;
        }

        static public DataTable FindClientListByName(string FirstName) 
        {
            return clsClientsData.FindClientListByName(FirstName);              
        }

        static public string RandomAccountNumber()
        {
            Random random = new Random();
            string Character=Convert.ToChar(random.Next('A','Z')).ToString();
            string Numbers = random.Next(100, 9999).ToString();
            return Character+Numbers;
        }

        static public bool Delete(int ID) 
        {
            if(clsClientsData.DeleteClient(ID)) 
                return true;
            return false;
        }

        public bool Update( )
        {
            if(clsClientsData.UpdateClient(_ID,_FirstName,_MiddleName,_LastName,_Email,_Address,_Phone,_BirthDate
                ,_NationalID,_Pincode,_AccountBalance,_AccountNumber))
                return true;
            return false;
        }

        static public DataTable ClientList()
        {
            return clsClientsData.ClientList();
        }

        static public DataTable AccountBalancesList(string FirstName,string MiddleName="",string LastName="")
        {
            return clsClientsData.GetAccountBalances(FirstName,MiddleName,LastName);
        }

        private bool CheckWithdrawAmount(double amount)
        {
            if(amount>_AccountBalance) 
                return false;
            return true;
        }

        public void Deposite(double DepositeAmount)
        {
             _AccountBalance += DepositeAmount;
         
        }

        public bool Withdraw(double Withdraw)
        {
            if (CheckWithdrawAmount(Withdraw))
            {
                _AccountBalance -= Withdraw;
                return true;
            }
            return false;
        }

   
    }
}
