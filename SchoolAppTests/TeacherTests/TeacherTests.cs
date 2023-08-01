using SchoolApp.Person;
using SchoolApp.Students;

namespace SchoolAppTests;

public class TeacherTests
{
    [SetUp]
    public void Setup()
    {
        
    }
    RegisterNewStudent student = new RegisterNewStudent();   

    [Test]
    public void Given_NameLastNameAndAge_When_RegisterANewStudent_ThenSaveIt()
    {
        //Arrange
        
        var name = "Hugo Lara";
        var age = 18;
        var curp = "lalala";

        //Act
        student.RegisterNewStudents(name, age, curp);
        
        //Assert
        
        Assert.IsNotEmpty(student.students);
    }

    [Test]
    public void Given_AdditionalInformation_When_RegisteringANewStudent_ThenSaveInAnExistingStudent()
    {
        //Arrange
        var address = "Juan Aldama";
        var city = "Zapopan";
        
        //Act
        student.SaveAddtionalInformationOfAStudent(address, city);
        
        //Assert
        Assert.AreEqual("Juan Aldama", student.Address);
        Assert.AreEqual("Zapopan", student.City);
    }
    
}