using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;

namespace CenterOfPetAnimalProtectionsManagement.DAO
{
    public class TblPetTypeDAO
    {
        private static TblPetTypeDAO _instance;

        public static TblPetTypeDAO Instance
        {
            get
            {
                if (_instance == null) _instance = new TblPetTypeDAO();
                return _instance;
            }
          
        }

        private TblPetTypeDAO(){}

        public List<tblPetType> GetTypesById(int categoryId)
        {
            var result = (from tblPetType in DataProvider.Instance.Db.tblPetType
                where tblPetType.categoryID == categoryId
                select tblPetType).ToList();
            return result;
        }

        public tblPetType GetType(int typeId)
        {
            var result = DataProvider.Instance.Db.tblPetType.Find(typeId);
            return result;
        }
    }
}
