using Moq;
using Xunit;

public class RandomLocationTests
{
  [Fact]
  public void WhenRangeIs1_ThenRandomLocationsIs1()
  {
    var random = new Mock<IRandom>();
    var randomLocation = new RandomLocation(random.Object);
    randomLocation.GetInRange(1);

    random.Verify(t => t.GetNext(0, 1), Times.AtLeastOnce);
  }
  
  [Fact]
  public void WhenRangeIs2_ThenRandomLocationsIs3()
  {
    var random = new Mock<IRandom>();
    var randomLocation = new RandomLocation(random.Object);
    randomLocation.GetInRange(2);

    random.Verify(t => t.GetNext(0, 3), Times.AtLeastOnce);
  }
  
  [Fact]
  public void WhenRangeIs3_ThenRandomLocationsIs11()
  {
    var random = new Mock<IRandom>();
    var randomLocation = new RandomLocation(random.Object);
    randomLocation.GetInRange(2);

    random.Verify(t => t.GetNext(0, 3), Times.AtLeastOnce);
  }

  [Fact]
  public void WhenRandomLocationIs0_ThenLocationIsAtX0Y0()
  {
    var random = new Mock<IRandom>();
    random
      .Setup(t => t.GetNext(0, It.IsAny<int>()))
      .Returns(() => 0);
    var randomLocation = new RandomLocation(random.Object);

    var location = randomLocation.GetInRange(3);

    Assert.Equal(new Location(0, 0), location);
  }
}