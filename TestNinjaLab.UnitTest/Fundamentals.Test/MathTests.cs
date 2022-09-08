using System.ComponentModel.Design;

namespace TestNinjaLab.UnitTest.Fundamentals.Test;

[TestFixture]
public class MathTests
{
    private TestNinjaLab.Fundamentals.Math _math;
    
    [SetUp]
    public void SetUp()
    {
        _math = new TestNinjaLab.Fundamentals.Math();
    }
    
    [Test]
    public void Add_WhenCalled_ReturnSumOfTheArguments()
    {
        //Arrange (SetUp)
        
        //Act 
        var result = _math.Add(1, 2);
        
        //Assert
        Assert.That(result, Is.EqualTo(3));
    }
    
    // [Test]
    // public void Max_FirstArgumentBiggerThanSecondOne_ReturnFirstArgument()
    // {
    //     //Arrange (SetUp)
    //     
    //     //Act 
    //     var result = _math.Max(2, 1);
    //     
    //     //Assert
    //     Assert.That(result, Is.EqualTo(2));
    // }
    //
    // [Test]
    // public void Max_SecondArgumentBiggerThanFirsOne_ReturnSecondArgument()
    // {
    //     //Arrange (SetUp ta arrange yaptık)
    //     
    //     //Act 
    //     var result = _math.Max(1, 2);
    //     
    //     //Assert
    //     Assert.That(result, Is.EqualTo(2));
    // }
    //
    // [Test]
    // public void Max_FirstArgumentEqualsWithSecondOne_ReturnGivenArgument()
    // {
    //     //Arrange (SetUp)
    //     
    //     //Act 
    //     var result = _math.Max(1, 1);
    //     
    //     //Assert
    //     Assert.That(result, Is.EqualTo(1));
    // }

    [Test]
    [TestCase(1,2,2)]
    [TestCase(2,1,2)]
    [TestCase(1,1,1)]
    public void Max_WhenCalled_ReturnMaxNumberOrEqualityNumber(int a, int b, int expectedResult)
    {
        //Arrange [SetUp]
        
        //Act
        var result = _math.Max(a, b);
        
        //Assert
        Assert.That(result, Is.EqualTo(expectedResult));
    }

    // [Test]
    // public void GetOddNumbers_UpToGreaterThanZeroLimit_ReturnOddNumbersAsAList()
    // {
    //     //Arrange (SetUp)
    //     
    //     //Act 
    //     var result = _math.GetOddNumbers(5);
    //     
    //     //Assert
    //     Assert.That(result, Is.Not.Null);
    //     Assert.That(result, Is.Not.Empty);
    //     Assert.That(result, Does.Contain(1));
    //     Assert.That(result, Does.Contain(3));
    //     Assert.That(result, Does.Contain(5));
    // }
    //
    // [Test]
    // public void GetOddNumbers_UpToEqualZeroLimit_ReturnEmptyList()
    // {
    //     //Arrange (SetUp)
    //     
    //     //Act 
    //     var result = _math.GetOddNumbers(0);
    //     
    //     //Assert
    //     Assert.That(result, Is.Not.Null);
    //     Assert.That(result, Is.Empty);
    // }
    //
    // [Test]
    // public void GetOddNumbers_UpToLesserThanZeroLimit_ReturnEmptyList()
    // {
    //     //Arrange (SetUp)
    //     
    //     //Act 
    //     var result = _math.GetOddNumbers(-1);
    //     
    //     //Assert
    //     Assert.That(result, Is.Not.Null);
    //     Assert.That(result, Is.Empty);
    // }

    [Test]
    [TestCase(5,new int[] {1,3,5}, TestName = "LimitGreaterThanZero")]
    [TestCase(0,new int[] {}, TestName = "LimitIsZero")]
    [TestCase(-1,new int[] {}, TestName = "LimitLowerThanZero")]
    public void GetOddNumber_WhenCalled_ReturnOddNumberUntilLimitValueWithLimitValue(int limit, IEnumerable<int> expectedResult)
    {
        //Arrange [SetUp]
        
        //Act
        var result = _math.GetOddNumbers(limit);
        
        //Assert
        Assert.That(result, Is.EqualTo(expectedResult));
    }
}
