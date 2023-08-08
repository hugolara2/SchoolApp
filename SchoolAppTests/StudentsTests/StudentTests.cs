using NUnit.Framework.Internal;
using SchoolApp.Person;
using SchoolApp.Students;

namespace SchoolAppTests;

public class StudentTests
{
    [SetUp]
    public void Setup()
    {
        
    }
    Student student = new Student();
    
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
        student.FirstRegistration(name, lastName, email);
        student.FirstRegistration(name1, lastName1, email1);
        student.FirstRegistration(name2, lastName2, email2);
        
        var expected = student.students[0].FirstName;
        var expected1 = student.students[1].FirstName;
        var expected2 = student.students[2].FirstName;
        
        //Assert
        Assert.IsNotEmpty(student.students);
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
        student.ExtraInfoRegistration(id,phone,candidate);
        student.ExtraInfoRegistration(id1,phone1,candidate1);
        student.ExtraInfoRegistration(id2,phone2,candidate2);

        //Assert
        Assert.That(phone, Is.EqualTo(student.students[id].Phone));
        Assert.That(phone1, Is.EqualTo(student.students[id1].Phone));
        Assert.That(phone2, Is.EqualTo(student.students[id2].Phone));
        
    }
    
}