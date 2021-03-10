using System.Collections.Generic;
using System.Linq;
using DataProvider;

namespace BussinessObject.DataAccess
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
            _db = DBProvider.Instance.Db;

        }

        public tblAccount Acc => acc;

        public tblAccount CheckLogin(string Username, string Password)
        {
            var user = (from u in _db.tblAccount
                        where u.username == Username && u.password == Password
                        select u).SingleOrDefault();
            return user;
        }

        public bool CreateAdopter(tblAccount adopter)
        {
            adopter.tblRole = TblRoleDAO.Instance.GetRoleById(adopter.roleID);
            tblAccount result = DBProvider.Instance.Db.tblAccount.Add(adopter);
            if (result != null) DBProvider.Instance.Db.SaveChanges();
            return result != null;
        }

        public List<tblAccount> GetAllAdopters()
        {
            var listAdopters = (from a in _db.tblAccount
                where a.roleID == 2 && a.status == true
                select a).ToList();
            return listAdopters;
        }
    }
}
