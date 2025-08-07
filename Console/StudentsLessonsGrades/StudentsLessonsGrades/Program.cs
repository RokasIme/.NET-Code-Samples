using StudentsLessonsGrades;

StudentConsole studentConsole = new StudentConsole();
studentConsole.AddStudyingStudents();
studentConsole.GenerateGrades();

while (true)
{
    Console.WriteLine("Enter 'List' to see all students, 'Add' to add new student, 'Grade' to write new grade for lesson to student or 'exit' to quit:");
    string comand = Console.ReadLine();

    if (comand.ToLower() == "list")
    {
        studentConsole.ShowStudentsList();
    }

    else if (comand.ToLower() == "add")
    {
        studentConsole.AddStudent();
    }

    else if (comand.ToLower() == "grade")
    {
        studentConsole.AddGradeToStudent();
    }

    else if (comand.ToLower() == "exit")
    {
        return;
    }

    else
    {
        Console.WriteLine("Invalid input");
    }
}