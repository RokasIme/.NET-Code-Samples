using FirstMvcApplication.Models;

namespace FirstMvcApplication.Services
{
    public class DataService
    {
        private List<PersonModel> persons = new List<PersonModel>()
        {
            new PersonModel() {Name = "Rokas Imelinskas"},
            new PersonModel() {Name = "Dovilė Imelinskė"},
            new PersonModel() {Name = "Jaunasis Imelinskas"},
        };

        public List<PersonModel> GetAll()
        {
            return persons;
        }

        public void Add(PersonModel personModel)
        {
            persons.Add(personModel);
        }
    }
}
