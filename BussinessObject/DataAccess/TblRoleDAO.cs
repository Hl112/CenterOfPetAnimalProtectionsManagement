using DataProvider;

namespace BussinessObject.DataAccess
{
    class TblRoleDAO
    {
        private static TblRoleDAO _instance;

        public static TblRoleDAO Instance
        {
            get
            {
                if (_instance == null) _instance = new TblRoleDAO();
                return _instance;
            }
        }

        private TblRoleDAO()
        {
        }

        public tblRole GetRoleById(int roleId)
        {
            var role = DBProvider.Instance.Db.tblRole.Find(roleId);
            return role;
        } 
    }
}