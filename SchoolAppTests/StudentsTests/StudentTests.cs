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
    public void Given_NameLastNameAndAge_When_RegisterANewStudent_ThenSaveIt()
    {
        //Arrange
        
        var name = "Hugo";
        var lastName = "Lara";
        var email = "lalala";

        //Act
        student.FirstRegistration(name, lastName, email);
        
        //Assert
        
        Assert.IsNotEmpty(student.students);
    }

    [Test]
    public void Given_AdditionalInformation_When_RegisteringANewStudent_ThenSaveInAnExistingStudent()
    {
        
    }
    
}