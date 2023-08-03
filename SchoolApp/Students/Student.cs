namespace SchoolApp.Students;

using Person;


public class Student : Person
{
    public List<Student> students = new();
    public override void FirstRegistration(string firstName, string lastName, string email)
    {
        if (students.Count == 0)
        { 
            students.Add(new Student());
            students[0].FirstName = firstName;
            students[0].LastName = lastName;
            students[0].Email = email;
        }
        else if(students.Count >= 1)
        {
            students.Add(new Student());
            var i = students.Count - 1;
            
            students[i].FirstName = firstName;
            students[i].LastName = lastName;
            students[i].Email = email;
            
        }
            
        
    }

    public override void ExtraInfoRegistration(int id, string phone, TypeOfCandidate candidate)
    {
        students[id].Phone = phone;
        students[id].Candidate = candidate;
    }
}