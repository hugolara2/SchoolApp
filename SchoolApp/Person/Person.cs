namespace SchoolApp.Person;

public class Person
{
    private string _firstname;
    private string _lastName;
    private int _age;
    private string _curp;
    private string _eid;
    private DateTime _birthday;
    private string _address;
    private string _city;
    private string _phone;
    private string _email;
    private TypeOfCandidate _candidate;

    public string FirstName
    {
        get => _firstname;
        set => _firstname = value;
    }

    public string LastName
    {
        get => _lastName;
        set => _lastName = value;
    }

    public int Age
    {
        get => _age;
        set => _age = value;
    }

    public string Curp
    {
        get => _curp;
        set => _curp = value;
    }

    public string Eid
    {
        get => _eid;
        set => _eid = value;
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

    public string Phone
    {
        get => _phone;
        set => _phone = value;
    }

    public string Email
    {
        get => _email;
        set => _email = value;
    }

    public TypeOfCandidate Candidate
    {
        get => _candidate;
        set => _candidate = value;
    }

    public List<Person>? persons = new();
    public void FirstRegistration(string firstName, string lastName, string email)
    {
        if (persons.Count == 0)
        { 
            persons.Add(new Person());
            persons[0].FirstName = firstName;
            persons[0].LastName = lastName;
            persons[0].Email = email;
        }
        else if(persons.Count >= 1)
        {
            persons.Add(new Person());
            var i = persons.Count - 1;
            
            persons[i].FirstName = firstName;
            persons[i].LastName = lastName;
            persons[i].Email = email;
            
        }
            
        
    }

    public void ExtraInfoRegistration(int id, string phone, TypeOfCandidate candidate)
    {
        if (persons != null)
        {
            persons[id].Phone = phone;
            persons[id].Candidate = candidate;
        }
    }

}

public enum TypeOfCandidate
{
    Student = 1,
    Teacher = 2,
    Employee = 3
}