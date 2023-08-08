using NUnit.Framework.Internal;
using SchoolApp.Person;
using SchoolApp.Students;

namespace SchoolAppTests.PersonUnitTests;

public class PersonTests
{
    [SetUp]
    public void Setup()
    {
        
    }
    Student person = new Student();
    
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
        person.FirstRegistration(name, lastName, email);
        person.FirstRegistration(name1, lastName1, email1);
        person.FirstRegistration(name2, lastName2, email2);
        
        var expected = person.persons[0].FirstName;
        var expected1 = person.persons[1].FirstName;
        var expected2 = person.persons[2].FirstName;
        
        //Assert
        Assert.IsNotEmpty(person.persons);
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
        person.ExtraInfoRegistration(id,phone,candidate);
        person.ExtraInfoRegistration(id1,phone1,candidate1);
        person.ExtraInfoRegistration(id2,phone2,candidate2);

        //Assert
        Assert.That(phone, Is.EqualTo(person.persons[id].Phone));
        Assert.That(phone1, Is.EqualTo(person.persons[id1].Phone));
        Assert.That(phone2, Is.EqualTo(person.persons[id2].Phone));
        
    }
    
}