using System.ComponentModel;

namespace FirstMvcApplication.Models
{
    public class PersonModel
    {
        [DisplayName("Full Name")]
        public string Name { get; set; }
    }
}
