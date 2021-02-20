using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace CenterOfPetAnimalProtectionsManagement.DAO
{
    class TblAccountDao
    {
        private static TblAccountDao _instance;
        private DBEntities _db;
        private tblAccount acc = null;
        public static TblAccountDao Instance
        {
            get { return _instance ?? (_instance = new TblAccountDao()); }
        }

        private TblAccountDao()
        {
            _db = new DBEntities();
        }

        public tblAccount Acc => acc;


        public bool CheckLogin(string username, string password)
        {
            var result = DataProvider.Instance.Db.tblAccount.Find(username);
            if (result != null)
            {
                if (result.password.Equals(password))
                {
                    acc = result;
                    return true;
                }
            }
            return false;
        }
    }
}
