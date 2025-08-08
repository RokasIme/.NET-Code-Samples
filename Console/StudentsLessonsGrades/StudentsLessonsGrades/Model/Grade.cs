
namespace StudentsLessonsGrades.Model
{
    public class Grade
    {
        public List<int>? Math { get; set; }
        public List<int>? Biology { get; set; }

        public Grade()
        {
            Math = new List<int>();
            Biology = new List<int>();
        }
    }
}
