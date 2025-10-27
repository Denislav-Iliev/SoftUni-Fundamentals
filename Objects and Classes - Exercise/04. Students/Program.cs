class Program
{
    static void Main()
    {
        int studentCount = int.Parse(Console.ReadLine());
        List<Student> students = new List<Student>(studentCount);
        for (int i = 0; i < studentCount; i++)
        {
            string[] arguments = Console.ReadLine().Split();
            students.Add(new Student(arguments[0], arguments[1], float.Parse(arguments[2])));
        }
        var orderedStudents = students.OrderByDescending(s => s.Grade);
        Console.WriteLine(string.Join("\n", orderedStudents));
    }
}
class Student
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public float Grade { get; set; }
    public Student(string firstName, string lastName, float grade)
    {
        FirstName = firstName;
        LastName = lastName;
        Grade = grade;
    }
    public override string ToString()
    {
        return $"{FirstName} {LastName}: {Grade:F2}";
    }
}
