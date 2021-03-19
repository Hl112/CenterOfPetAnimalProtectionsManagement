using DataProvider;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessObject.DataAccess {
    public class TblPetDiaryDAO {
        private static TblPetDiaryDAO _instance;

        public static TblPetDiaryDAO Instance{
            get
            {
                if (_instance == null) _instance = new TblPetDiaryDAO();
                return _instance;
            }
        }

        private TblPetDiaryDAO() {}

        #region Diep
        //this function will insert pet diary into TblPetDiary table
        public bool CreatePetDiary(tblPetDiary diary) {
            tblPetDiary result =  DBProvider.Instance.Db.tblPetDiary.Add(diary);
            if(result != null) {
                DBProvider.Instance.Db.SaveChanges();
                return true;
            }
            return false;
        }

        //this function will return list pet diaries of the specific pet
        public List<tblPetDiary> GetPetDiariesByPetID(int petID) {
            var petDiaries = (from diary in DBProvider.Instance.Db.tblPetDiary
                             where diary.petId == petID
                             orderby diary.createDate descending
                             select diary).ToList();
            return petDiaries;
        }

        //this function will return list pet diaries of the specific adopter
        public List<tblPetDiary> GetPetDiariesByAopter(string username) {
            var petDiaries = (from diary in DBProvider.Instance.Db.tblPetDiary
                              where diary.adopter == username
                              orderby diary.createDate descending
                              select diary).ToList();
            return petDiaries;
        }
        #endregion
    }
}
