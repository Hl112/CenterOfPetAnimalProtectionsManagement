using DataProvider;

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
                DBProvider.Instance.Db.SaveChanges();
                return true;
            }

            return false;
        }
    }
}
