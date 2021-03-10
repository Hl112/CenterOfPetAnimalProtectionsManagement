using DataProvider;
using System.Linq;
using System.Collections.Generic;
using System.Data.Entity.SqlServer;
using System.Globalization;
using System;
using System.Data.Entity;
using System.Net.Http;

namespace BussinessObject.DataAccess
{
    public class TblPetDAO
    {
        private static TblPetDAO _instance;

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

        }

        public bool CreatePet(tblPet pet)
        {
            pet.tblPetType = TblPetTypeDAO.Instance.GetType(pet.typeID);
            tblPet result = DBProvider.Instance.Db.tblPet.Add(pet);
            if (result != null) DBProvider.Instance.Db.SaveChanges();
            return result != null;
        }

        public bool UpdatePet(tblPet pet)
        {
            tblPet update = DBProvider.Instance.Db.tblPet.Find(pet.id);
            
            if (update != null)
            {
                pet.createdDate = update.createdDate;
                update = pet;
                DBProvider.Instance.Db.SaveChangesAsync();
                return true;
            }

            return false;
        }

        //this function will get all pet in tblPet
        public List<tblPet> GetAllPets() {
            var pets = (from x in DBProvider.Instance.Db.tblPet
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
            if (!string.IsNullOrEmpty(searchCate)) cateID = int.Parse(searchCate);
            if (!string.IsNullOrEmpty(searchType)) typeID = int.Parse(searchType);
            var pets = (from p in DBProvider.Instance.Db.tblPet
                        where (string.IsNullOrEmpty(searchCate) ? 
                            DbFunctions.Like(p.tblPetType.tblPetCategory.id.ToString(), "%%") :
                            p.tblPetType.tblPetCategory.id == cateID)
                        && (string.IsNullOrEmpty(searchType) ?
                            DbFunctions.Like(p.tblPetType.id.ToString(), "%%") :
                            p.tblPetType.id == typeID)
                        && DbFunctions.Like(p.id.ToString(), $"%" + searchID + "%")
                        && DbFunctions.Like(p.furColor.ToString(), $"%" + searchFurColor + "%")
                        && DbFunctions.Like(p.status.ToString(), $"%" + searchStatus + "%")
                        && (isAdopted ? p.adopter != null : p.adopter == null)
                        && (isAdopted ? DbFunctions.TruncateTime(p.dateAdopted) >= DbFunctions.TruncateTime(searchAdoptedDateFrom) && DbFunctions.TruncateTime(p.dateAdopted) <= DbFunctions.TruncateTime(searchAdoptedDateTo) : true)
                       /* && (isAdopted ? DbFunctions.TruncateTime(p.dateAdopted) <= DbFunctions.TruncateTime(searchAdoptedDateTo) : true)*/
                        select p).ToList();
            return pets;
        }
    }
}
