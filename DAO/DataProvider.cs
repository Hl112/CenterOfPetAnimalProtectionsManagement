using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CenterOfPetAnimalProtectionsManagement.DAO
{
    class DataProvider
    {
        private static DataProvider _instance;
        private DBEntities _db;
        public static DataProvider Instance
        {
            get
            {
                if (_instance == null) _instance = new DataProvider();
                return _instance;
            }
        }

        public DBEntities Db => _db;

        private DataProvider()
        {
            _db = new DBEntities();
        }
    }
}
