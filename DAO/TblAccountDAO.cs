using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace CenterOfPetAnimalProtectionsManagement.DAO
{
    public class TblAccountDao
    {
        private static TblAccountDao _instance;
        private DBEntities _db;
        private tblAccount acc = null;
        public static TblAccountDao Instance
        {
            get { return _instance ?? (_instance = new TblAccountDao()); }
        }

        public TblAccountDao()
        {
            _db = DataProvider.Instance.Db;
            
        }

        public tblAccount Acc => acc;


        //public bool CheckLogin(string username, string password)
        //{
        //    var result = _db.tblAccount.Find(username);
        //    if (result != null)
        //    {
        //        if (result.password.Equals(password))
        //        {
        //            acc = result;
        //            return true;
        //        }
        //    }
        //    return false;
        //}

        public tblAccount CheckLogin(string Username, string Password)
        {
            var user = (from u in _db.tblAccount
                        where u.username == Username && u.password == Password
                        select u).SingleOrDefault();
            return user;
        }
    }
}
