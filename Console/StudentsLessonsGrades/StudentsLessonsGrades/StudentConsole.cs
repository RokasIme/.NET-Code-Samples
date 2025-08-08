using StudentsLessonsGrades.Model;


namespace StudentsLessonsGrades
{
    public class StudentConsole
    {
        public List<Student> students = new List<Student>();

        public void AddStudyingStudents()
        {
            students.Add(new Student() { Name = "Jonas", Surname = "Petrauskas" });
            students.Add(new Student() { Name = "Petras", Surname = "Jonauskas" });
            students.Add(new Student() { Name = "Juozas", Surname = "Parapitavičius" });
            students.Add(new Student() { Name = "Algimantas", Surname = "Antanavičius" });
        }

        public void AddStudent()
        {
            Console.WriteLine("Enter student's name:");
            string name = Console.ReadLine();

            Console.WriteLine("Enter student's surname:");
            string surname = Console.ReadLine();

            Student student = new Student();
            student.Name = name;
            student.Surname = surname;
            student.Grades = new Grade();
            students.Add(student);
        }

        public void ShowStudentsList()
        {
            foreach (var std in students)
            {
                string mathGrades = String.Join(", ", std.Grades?.Math ?? new List<int>());
                string biologyGrades = String.Join(", ", std.Grades?.Biology ?? new List<int>());

                Console.WriteLine($"Student: {std.Name} {std.Surname} \n " +
                    $"Grades Biology: {biologyGrades} \n Grades Math: {mathGrades} \n");
            }
        }

        public void GenerateGrades()
        {
            foreach (var std in students)
            {
                Random random = new Random();
                int grade = random.Next(1, 11);

                var randomRange = random.Next(5, 8);
                std.Grades = new Grade();
                var mathGrades = new List<int>();
                var biologyGrades = new List<int>();

                for (int i = 0; i < randomRange; i++)
                {
                    grade = random.Next(1, 11);
                    mathGrades.Add(grade);
                }

                randomRange = random.Next(5, 8);

                for (int i = 0; i < randomRange; i++)
                {
                    grade = random.Next(1, 11);
                    biologyGrades.Add(grade);
                }

                std.Grades.Math = mathGrades;
                std.Grades.Biology = biologyGrades;
            }
        }

        public void AddGradeToStudent()
        {
            Console.WriteLine("Enter student's name:");
            string name = Console.ReadLine();

            Console.WriteLine("Enter student's surname:");
            string surname = Console.ReadLine();

            Console.WriteLine("Enter lesson 'math' or 'biology':");
            string lesson = Console.ReadLine();

            Console.WriteLine("Enter new lesson grade:");
            string gradeString = Console.ReadLine();
            int grade = Int32.Parse(gradeString);

            var student = students.FirstOrDefault(s => s.Name == name && s.Surname == surname);
            if (student != null)
            {
                if (lesson.ToLower() == "math")
                {
                    student.Grades.Math.Add(grade);
                }
                else if (lesson.ToLower() == "biology")
                {
                    student.Grades.Biology.Add(grade);
                }
                else
                {
                    Console.WriteLine("Invalid subject");
                }
            }
            else
            {
                Console.WriteLine("Student not found");
            }
        }


    }
}
