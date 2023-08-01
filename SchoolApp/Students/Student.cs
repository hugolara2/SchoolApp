namespace SchoolApp.Students;

using Person;

public class Student : Person
{
    private string _curp;

    public string Curp
    {
        get => _curp;
        set => _curp = value;
    }

    
    
    
}