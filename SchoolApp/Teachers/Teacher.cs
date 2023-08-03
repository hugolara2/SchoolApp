namespace SchoolApp.Teachers;

using Person;

public class Teacher : Person
{
    private string _rfc;

    public string Rfc
    {
        get => _rfc;
        set => _rfc = value;
    }
}