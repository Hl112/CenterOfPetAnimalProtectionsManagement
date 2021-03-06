using System;

namespace DataProvider
{
    public class DBProvider
    {
        private static DBProvider _instance;
        private DBEntities _db;
        public static DBProvider Instance
        {
            get
            {
                if (_instance == null) _instance = new DBProvider();
                return _instance;
            }
        }

        public DBEntities Db => _db;

        public DBProvider()
        {
            try
            {
                _db = new DBEntities();
            }
            catch (Exception a)
            {
                Console.WriteLine(a);
                throw;
            }
        }
    }
}
