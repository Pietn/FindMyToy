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
}