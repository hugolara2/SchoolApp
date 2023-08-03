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

    public override void FirstRegistration(string firstName, string lastName, string email)
    {
        throw new NotImplementedException();
    }

    public override void ExtraInfoRegistration(int id, string phone, TypeOfCandidate candidate)
    {
        throw new NotImplementedException();
    }
}