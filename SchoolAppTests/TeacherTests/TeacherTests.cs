using SchoolApp.Person;
using SchoolApp.Teachers;

namespace SchoolAppTests;

public class TeacherTests
{
    [SetUp]
    public void Setup()
    {
        
    }

    Teacher teacher = new Teacher();
    
    [Test]
    public void Given_NameLastNameAndEmail_When_FirstRegistration_ThenSaveIt()
    {
        //Arrange
        var name = "Hugo";
        var lastName = "Lara";
        var email = "lalala";
        
        var name1 = "Karen";
        var lastName1 = "Ruiz";
        var email1 = "rarara";
        
        var name2 = "Paco";
        var lastName2 = "Flores";
        var email2 = "fafafa";

        
        //Act
        teacher.FirstRegistration(name, lastName, email);
        teacher.FirstRegistration(name1, lastName1, email1);
        teacher.FirstRegistration(name2, lastName2, email2);
        
        var expected = teacher.teachers[0].FirstName;
        var expected1 = teacher.teachers[1].FirstName;
        var expected2 = teacher.teachers[2].FirstName;
        
        //Assert
        Assert.IsNotEmpty(teacher.teachers);
        Assert.That(name, Is.EqualTo(expected));
        Assert.That(name1, Is.EqualTo(expected1));
        Assert.That(name2, Is.EqualTo(expected2));
    }

    [Test]
    public void Given_PhoneAndStudentCandidate_When_GivenExtraInfoRegistration_ThenSaveInAnExistingStudent()
    {
        //Arrange
        var id = 0;
        var phone = "2314556";
        var candidate = TypeOfCandidate.Student;
        
        var id1 = 1;
        var phone1 = "123445";
        var candidate1 = TypeOfCandidate.Student;
        
        var id2 = 2;
        var phone2 = "54321";
        var candidate2 = TypeOfCandidate.Student;
        
        //Act
        teacher.ExtraInfoRegistration(id,phone,candidate);
        teacher.ExtraInfoRegistration(id1,phone1,candidate1);
        teacher.ExtraInfoRegistration(id2,phone2,candidate2);

        //Assert
        Assert.That(phone, Is.EqualTo(teacher.teachers[id].Phone));
        Assert.That(phone1, Is.EqualTo(teacher.teachers[id1].Phone));
        Assert.That(phone2, Is.EqualTo(teacher.teachers[id2].Phone));
        
    }
    
}