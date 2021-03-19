using System.Collections.Generic;
using System.Linq;
using DataProvider;

namespace BussinessObject.DataAccess
{
    public class NotificationDAO
    {
        private static NotificationDAO _instance;

        public static NotificationDAO Instance
        {
            get
            {
                if (_instance == null) _instance = new NotificationDAO();
                return _instance;
            }
        }

        private NotificationDAO()
        {
        }

        public List<tblPetDiary> GetNotification()
        {
            var list = (from tblPetDiary in DBProvider.Instance.Db.tblPetDiary
                orderby tblPetDiary.createDate descending 
                select tblPetDiary).ToList();
            return list;
        }

        public void MakeRead(int id)
        {
            var item = (from tblPetDiary in DBProvider.Instance.Db.tblPetDiary
                where tblPetDiary.id == id
                select tblPetDiary).SingleOrDefault();
            if (item != null)
            {
                item.isRead = true;
                DBProvider.Instance.Db.SaveChangesAsync();
            }
        }
    }
}
