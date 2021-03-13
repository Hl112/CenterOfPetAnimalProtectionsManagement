using DataProvider;
using System.Linq;
using System.Collections.Generic;
using System;
using System.Data.Entity;

namespace BussinessObject.DataAccess
{
    public class TblPetDAO
    {
        private static TblPetDAO _instance;
        private DBEntities _db;

        public static TblPetDAO Instance
        {
            get
            {
                if (_instance == null) _instance = new TblPetDAO();
                return _instance;
            }

        }

        private TblPetDAO()
        {
            _db = DBProvider.Instance.Db;
        }

        #region HL
        // HL - This function will create pet
        public bool CreatePet(tblPet pet)
        {
            pet.tblPetType = TblPetTypeDAO.Instance.GetType(pet.typeID);
            tblPet result = DBProvider.Instance.Db.tblPet.Add(pet);
            if (result != null) DBProvider.Instance.Db.SaveChanges();
            return result != null;
        }
        // HL - This function will update pet
        public bool UpdatePet(tblPet pet)
        {
            var update = (from tblPet in DBProvider.Instance.Db.tblPet where tblPet.id == pet.id select tblPet)
                .SingleOrDefault();
            if (update != null)
            {
                update.name = pet.name;
                update.age = pet.age;
                update.image = pet.image;
                update.gender = pet.gender;
                update.description = pet.description;
                update.isSterilized = pet.isSterilized;
                update.adopter = pet.adopter;
                update.furColor = pet.furColor;
                update.typeID = pet.typeID;
                update.dateAdopted = pet.dateAdopted;
                DBProvider.Instance.Db.SaveChangesAsync();
                return true;
            }
            return false;
        }
        #endregion

        #region Diep
        //this function will get all pet in tblPet
        public List<tblPet> GetAllPets() {
            var pets = (from x in DBProvider.Instance.Db.tblPet
                        where x.status == true
                        select x).ToList();
            return pets;
        }

        //this function will return a Pet by ID
        public tblPet GetPetByID(int pID) {
            return DBProvider.Instance.Db.tblPet.Find(pID);
        }

        //this function will set pet's status to false
        public bool DeletePet(int pID) {
            tblPet pet = DBProvider.Instance.Db.tblPet.Find(pID);
            if(pet != null) {
                pet.status = false;
                DBProvider.Instance.Db.SaveChanges();
                return true;
            }
            return false;
        }

        //search pets
        //truncateTime: only compare date (ignore time)
        public List<tblPet> SearchPets(string searchCate, string searchType, string searchID, string
                searchFurColor, string searchStatus, bool isAdopted, DateTime searchAdoptedDateFrom,
                DateTime searchAdoptedDateTo) {
            int cateID = 0;
            int typeID = 0;
            int id = 0;
            if (!string.IsNullOrEmpty(searchCate)) cateID = int.Parse(searchCate);
            if (!string.IsNullOrEmpty(searchType)) typeID = int.Parse(searchType);
            if (!string.IsNullOrEmpty(searchID)) id = int.Parse(searchID);
            var pets = (from p in DBProvider.Instance.Db.tblPet
                        where (string.IsNullOrEmpty(searchCate) ? 
                            DbFunctions.Like(p.tblPetType.tblPetCategory.id.ToString(), "%%") :
                            p.tblPetType.tblPetCategory.id == cateID)
                        && (string.IsNullOrEmpty(searchType) ?
                            DbFunctions.Like(p.tblPetType.id.ToString(), "%%") :
                            p.tblPetType.id == typeID)
                        && (string.IsNullOrEmpty(searchID) ?
                            DbFunctions.Like(p.tblPetType.id.ToString(), "%%") :
                            p.id == id)
                        && DbFunctions.Like(p.furColor.ToString(), $"%" + searchFurColor + "%")
                        && DbFunctions.Like(p.status.ToString(), $"%" + searchStatus + "%")
                        && (isAdopted ? p.adopter != null : p.adopter == null)
                        && (isAdopted ? DbFunctions.TruncateTime(p.dateAdopted) >=
                            DbFunctions.TruncateTime(searchAdoptedDateFrom) &&
                            DbFunctions.TruncateTime(p.dateAdopted) <=
                            DbFunctions.TruncateTime(searchAdoptedDateTo) : true)
                        select p).ToList();
            return pets;
        }
        #endregion


        #region Thu

        public List<tblPet> GetPetsByAdopterUsername(string username)
        {
            var result = (from p in _db.tblPet
                    where  p.adopter == username
                    select p).ToList();

            return result;
        }

        #endregion
    }
}
