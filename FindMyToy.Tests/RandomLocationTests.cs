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
}