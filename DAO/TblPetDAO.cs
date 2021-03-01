namespace CenterOfPetAnimalProtectionsManagement.DAO
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
            tblPet result = DataProvider.Instance.Db.tblPet.Add(pet);
            if (result != null) DataProvider.Instance.Db.SaveChanges();
            return result != null;
        }

        public bool UpdatePet(tblPet pet)
        {
            tblPet update = DataProvider.Instance.Db.tblPet.Find(pet.id);
            pet.createdDate = update.createdDate;
            if (update != null)
            {
                update = pet; 
                DataProvider.Instance.Db.SaveChanges();
                return true;
            }

            return false;
        }
    }
}
