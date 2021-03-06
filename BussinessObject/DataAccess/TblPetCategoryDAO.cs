using DataProvider;
using System.Collections.Generic;
using System.Linq;

namespace BussinessObject.DataAccess
{
    public class TblPetCategoryDAO
    {
        private static TblPetCategoryDAO _instance;

        public static TblPetCategoryDAO Instance
        {
            get
            {
                if (_instance == null) _instance = new TblPetCategoryDAO();
                return _instance;
            }
        }

        private TblPetCategoryDAO() { }

        public List<tblPetCategory> GetAllCategories()
        {
            var result = (from tblPetCategory in DBProvider.Instance.Db.tblPetCategory select tblPetCategory)
                .ToList();
            return result;
        }

    }
}
