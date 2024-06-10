namespace Task;

public class Student
{
    private static int _id;
    private string _groupNo;

    public int Id { get; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public string GroupNo 
    { 
        get => _groupNo;
        set
        {
            if(CheckGroupNo(value))
                _groupNo = value;
        } 
    }

    public Student(string name, string surname, string groupNo)
    {
        //_id++;
        Id = ++_id;
        Name = name;
        Surname = surname;
        GroupNo = groupNo;
    }

    public static bool CheckGroupNo(string groupNo)
    {
        return groupNo.Length == 5 && char.IsUpper(groupNo[0]) && char.IsUpper(groupNo[1]) && char.IsDigit(groupNo[2]) && char.IsDigit(groupNo[3]) && char.IsDigit(groupNo[4]);
    }

    public string StudentInfo() 
        => $"Id: {Id} - Name: {Name} - Surname: {Surname} - GroupNo: {GroupNo}";
}