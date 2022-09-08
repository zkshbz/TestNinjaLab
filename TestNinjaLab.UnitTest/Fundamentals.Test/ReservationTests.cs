using TestNinjaLab.Fundamentals;

namespace TestNinjaLab.UnitTest.Fundamentals.Test;

[TestFixture]
public class ReservationTests
{
    [Test]
    public void CanBeCancelledBy_IsUserAdmin_ReturnTrue()
    {
        //Arrange
        var reservation = new Reservation();
        var user = new User { IsAdmin = true };

        //Act
        var result = reservation.CanBeCancelledBy(user);

        //Assert
        Assert.That(result, Is.True);
    }

    [Test]
    public void CanBeCanceledBy_IsUserMadeBy_ReturnTrue()
    {
        //Arrange
        var reservation = new Reservation();
        var user = new User { IsAdmin = false };

        //Act
        reservation.MadeBy = user;
        var result = reservation.CanBeCancelledBy(user);

        //Assert
        Assert.That(result, Is.True);
    }

    [Test]
    public void CanBeCanceledBy_IsUserNotAdmin_ReturnFalse()
    {
        //Arrange
        var reservation = new Reservation();
        var user = new User { IsAdmin = false };

        //Act
        var result = reservation.CanBeCancelledBy(user);

        //Assert
        Assert.That(result, Is.False);
    }
    
    [Test]
    public void CanBeCanceledBy_IsUserNotMadeBy_ReturnFalse()
    {
        //Arrange
        var reservation = new Reservation();
        var userMadeBy = new User { IsAdmin = false };
        var userAnother = new User { IsAdmin = false };

        //Act
        reservation.MadeBy = userMadeBy;
        var result = reservation.CanBeCancelledBy(userAnother);

        //Assert
        Assert.That(result, Is.False);
    }
}
