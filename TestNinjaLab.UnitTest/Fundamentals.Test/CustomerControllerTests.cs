using TestNinjaLab.Fundamentals;

namespace TestNinjaLab.UnitTest.Fundamentals.Test;

[TestFixture]
public class CustomerControllerTests
{
    [Test]
    public void GetCustomer_IdIsIsEqualZero_ReturnNotFound()
    {
        //Arrange
        var customerController = new CustomerController();
        
        //Act 
        var result = customerController.GetCustomer(0);

        //Assert
        Assert.That(result, Is.TypeOf<NotFound>());
    }
    
    [Test]
    public void GetCustomer_IdIsIsNotEqualZero_ReturnOk()
    {
        //Arrange
        var customerController = new CustomerController();
        
        //Act 
        var result = customerController.GetCustomer(1);

        //Assert
        Assert.That(result, Is.TypeOf<Ok>());
    }
    
    //Two upper methods are enough 
    //I implemented also with test case usage
    [Test]
    [TestCase(0, typeof(NotFound))]
    [TestCase(1, typeof(Ok))]
    public void GetCustomer_WhenCalled_ReturnGivenExpectedActionResult(int id, Type expectedResult)
    {
        //Arrange
        var customerController = new CustomerController();
        
        //Act
        var result = customerController.GetCustomer(id);
        
        //Assert
        Assert.That(result, Is.TypeOf(expectedResult));
    }
}