using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using UsersDataTier;

namespace UsersBusinessTier
{
    public class clsUserBusiness
    {
        public int _UserID { get; set; }
        public string _UserName { get; set; }
        public string _Password { get; set; }
        public int _Permissions {  get; set; }
        public string _Image {  get; set; }
        public clsUserBusiness(int userID, string userName, string password, int permissions,string Image)
        {
            _UserID = userID;
            _UserName = userName;
            _Password = password;
            _Permissions = permissions;
            _Image = Image;
        }

        public bool AddNewUser()
        {
            this._UserID = clsUsersData.AddNewUser(_UserName, _Password, _Permissions,_Image);
            if (this._UserID != -1)
                return true;
            return false;

        }

        static public clsUserBusiness FindByUserNameAndPassword(string UserName,string Password)
        {
            int Permissions = 0, ID=0;
            string Image = "";
            if(clsUsersData.FindUserByUserNameAndPassword(ref UserName,ref Permissions,ref ID, Password,ref Image))
                return new clsUserBusiness(ID,UserName,Password,Permissions,Image);
            else
                return null;
        }

        static public clsUserBusiness FindByUserName(string UserName)
        {
            int Permissions = 0, ID = 0;
            string Image = "",Password="";
            if (clsUsersData.FindUserByUserName(ref UserName, ref Permissions, ref ID,ref Password, ref Image))
                return new clsUserBusiness(ID, UserName, Password, Permissions, Image);
            else
                return null;
        }

        static public clsUserBusiness FindUserByID(int UserID)
        {
            string userName = "",Password = "",Image="";
            int  Permissions = 0;
            if (clsUsersData.FindUserByUserID(ref userName, ref Permissions, UserID, ref Password,ref Image))
                return new clsUserBusiness(UserID, userName, Password, Permissions, Image);
            return null;
        }

        static public DataTable FindUserByFullName(string FullName)
        {
            return clsUsersData.GetUsersByFullName(ref FullName);
        }

        static public bool IsExist(string UserName)
        {
            if(clsUsersData.IsExist(UserName)) 
                return true;
            return false;
        }

        static public bool IsExist(int ID)
        {
            if (clsUsersData.IsExist(ID)) 
                return true;
            return false;
        }
        static public bool Delete(int UserID) 
        {
            if(clsUsersData.Delete(UserID))
                return true;
            return false;
        }

        public bool Update()
        {
            if(clsUsersData.UpdateUser(_UserID,_UserName,_Password,_Permissions,_Image))             
                return true; 
            return false;
        }

        static public DataTable UserList()
        {
            return clsUsersData.GetUsersList();
        }

    }
}
