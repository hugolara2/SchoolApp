namespace SchoolApp.Teachers;

using Person;

public class Teacher : Person
{
    public List<Teacher> teachers = new();
    public override void FirstRegistration(string firstName, string lastName, string email)
    {
        if (teachers.Count == 0)
        { 
            teachers.Add(new Teacher());
            teachers[0].FirstName = firstName;
            teachers[0].LastName = lastName;
            teachers[0].Email = email;
        }
        else if(teachers.Count >= 1)
        {
            teachers.Add(new Teacher());
            var i = teachers.Count - 1;
            
            teachers[i].FirstName = firstName;
            teachers[i].LastName = lastName;
            teachers[i].Email = email;
            
        }
    }

    public override void ExtraInfoRegistration(int id, string phone, TypeOfCandidate candidate)
    {
        teachers[id].Phone = phone;
        teachers[id].Candidate = candidate;
    }
}