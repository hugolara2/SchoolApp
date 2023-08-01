using SchoolApp.Students;

namespace SchoolApp.Person;

public class RegisterNewStudent : Student
{
    public List<Student> students = new();
    
    
    public List<Student> RegisterNewStudents(string name, int age, string curp)
    {
        Name = name;
        Age = age;
        Curp = curp;
        
        students.Add(new Student());
        return students;
    }

    public void SaveAddtionalInformationOfAStudent(string address, string city)
    {
        Address = address;
        City = city;
    }
}