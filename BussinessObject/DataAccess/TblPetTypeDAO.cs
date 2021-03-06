using DataProvider;
using System.Collections.Generic;
using System.Linq;

namespace BussinessObject.DataAccess
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

        private TblPetTypeDAO() { }

        public List<tblPetType> GetTypesById(int categoryId)
        {
            var result = (from tblPetType in DBProvider.Instance.Db.tblPetType
                          where tblPetType.categoryID == categoryId
                          select tblPetType).ToList();
            return result;
        }

        public tblPetType GetType(int typeId)
        {
            var result = DBProvider.Instance.Db.tblPetType.Find(typeId);
            return result;

        }
    }
}
