namespace SchoolApp.Students;

using Person;


public class Student : Person
{
    public List<Student> students = new();
    public override void FirstRegistration(string firstName, string lastName, string email)
    {
        FirstName = firstName;
        LastName = lastName;
        Email = email;
        
        students.Add(new Student());
    }
    
    

    public override void ExtraInfoRegistration(string phone, TypeOfCandidate candidate)
    {
        throw new NotImplementedException();
    }
}