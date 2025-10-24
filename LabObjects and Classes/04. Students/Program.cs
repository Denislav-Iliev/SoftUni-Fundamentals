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
            Student student = new()
            {
                FirstName = firstName,
                LastName = lastName,
                Age = age,
                HomeTown = homeTown
            };
            students.Add(student);
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
}
public class Student
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
    public string HomeTown { get; set; }
}
