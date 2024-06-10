namespace _10_06_2024
{
    //public class Student
    //{
    //    public int Age { get; init; } = 18;

    //    public Student()
    //    {
    //        Age = 20;
    //    }
    //}

    //public record Student
    //{
    //    public string Name { get; set; }
    //}

    //public record Student(string Name);

    //public record Student
    //{
    //    public string Name { get; init; }

    //    public Student(string Name)
    //    {
    //        this.Name = Name;
    //    }
    //}

    //public static class Student
    //{
    //    public static string Name { get; set; }
    //    public static readonly int age;
    //    //public string Surname { get; set; }

    //    static Student()
    //    {
    //        age = 20;
    //        Console.WriteLine("static ctor");
    //    }

    //    //public Student()
    //    //{
    //    //    //age = 19;
    //    //    Console.WriteLine("ctor");
    //    //}

    //    public static void Print()
    //    {
    //        Console.WriteLine(Name);
    //    }
    //}

    public class Student
    {
        public int Id { get; }
        private static int id { get; set; }

        public Student()
        {
            id++;
            Id = id;
        }
    }
}