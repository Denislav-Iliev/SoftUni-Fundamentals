

internal class Program
{
    static void Main(string[] args)
    {
        List<Student> students = new();
        string command = "";
        while ((command = Console.ReadLine()) != "end")
        {
            string[] input = command.Split();
            string firstName = input[0];
            string lastName = input[1];
            int age = int.Parse(input[2]);
            string homeTown = input[3];
            if (IsStudentExisting(students, firstName, lastName))
            {
                Student student = GetStudent(students, firstName, lastName);
                student.FirstName = firstName;
                student.LastName = lastName;
                student.Age = age;
                student.HomeTown = homeTown;
            }
            else
            {
                Student student = new()
                {
                    FirstName = firstName,
                    LastName = lastName,
                    Age = age,
                    HomeTown = homeTown
                };

                students.Add(student);
            }
        }
        string filterCity = Console.ReadLine();

        foreach (Student student in students)
        {
            if (student.HomeTown == filterCity)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
            }
        }
    }

    private static Student GetStudent(List<Student> students, string firstName, string lastName)
    {
        Student existingStudent = null;
        foreach (Student student in students)
        {
            if (student.FirstName == firstName && student.LastName == lastName)
            {
                existingStudent = student;
            }
        }
        return existingStudent;
    }

    private static bool IsStudentExisting(List<Student> students, string firstName, string lastName)
    {
        foreach (Student student in students)
        {
            if (student.FirstName == firstName && student.LastName == lastName)
            {
                return true; 
            }      
   
        }
        return false;
    }
}
public class Student
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
    public string HomeTown { get; set; }
}