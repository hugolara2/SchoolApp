namespace SchoolApp.Person;

public abstract class Person
{
    private string _name;
    private int _age;
    private DateTime _birthday;
    private string _address;
    private string _city;

    public string Name
    {
        get => _name;
        set => _name = value;
    }

    public int Age
    {
        get => _age;
        set => _age = value;
    }

    public DateTime Birthday
    {
        get => _birthday;
        set => _birthday = value;
    }

    public string Address
    {
        get => _address;
        set => _address = value;
    }

    public string City
    {
        get => _city;
        set => _city = value;
    }

}