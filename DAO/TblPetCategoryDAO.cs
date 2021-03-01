using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CenterOfPetAnimalProtectionsManagement.DAO
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

        private TblPetCategoryDAO(){}

        public List<tblPetCategory> GetAllCategories()
        {
            var result = (from tblPetCategory in DataProvider.Instance.Db.tblPetCategory select tblPetCategory)
                .ToList();
            return result;
        }

    }
}
