class Student
{
    // auto-implemented properties
    public int Id { get; init; }
    public string FirstName { get; set; }
    public string LastName { get; set; }

    // default constructor
    public Student()
    {
        Id = 0;
        FirstName = "";
        LastName = "";
    }
    // parameterized constructor
    public Student(int i, string First, string Last)
    {
        Id = i;
        FirstName = First;
        LastName = Last;
    }
    public Student(int id)
    {
        Id = id;
        FirstName = string.Empty;
        LastName= string.Empty;
    }

    public void Display()
    {
        Console.WriteLine($"Id: {Id}");
        Console.WriteLine($"First Name: {FirstName}");
        Console.WriteLine($"Last Name: {LastName}");
    }


    public static void Main()
    {
        Student student1 = new(15664);
        {
            student1.FirstName = "Joy";
            student1.LastName = "Lang";
        }
        student1.Display();

        Student student2 = new Student(12254, "Joe", "Star");
        student2.Display();

    }
}
