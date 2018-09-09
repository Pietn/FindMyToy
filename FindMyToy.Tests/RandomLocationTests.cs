using Moq;
using Xunit;

public class RandomLocationTests
{
  [Theory]
  [InlineData(0, 1)]
  [InlineData(1, 7)]
  [InlineData(2, 19)]
  public void WhenRangeIsRange_ThenRandomLocationsIsNumberOfLocations(int range, int numberOfLocations)
  {
    var random = new Mock<IRandom>();
    var randomLocation = new RandomLocation(random.Object);
    randomLocation.GetInRange(range);

    random.Verify(t => t.GetNext(0, numberOfLocations), Times.AtLeastOnce);
  }

  [Theory]
  [InlineData(0, 0, 0)]
  [InlineData(1, 0, 1)]
  [InlineData(2, 1, 0)]
  [InlineData(3, 1, -1)]
  [InlineData(4, 0, -1)]
  [InlineData(5, -1, 0)]
  [InlineData(6, -1, 1)]
  [InlineData(7, 0, 2)]
  [InlineData(9, 2, 0)]
  [InlineData(11, 2, -2)]
  public void WhenRandomLocationIsIndex_ThenLocationIsAtXAndY(int index, int x, int y)
  {
    var random = new Mock<IRandom>();
    random
      .Setup(t => t.GetNext(0, It.IsAny<int>()))
      .Returns(() => index);
    var randomLocation = new RandomLocation(random.Object);

    var location = randomLocation.GetInRange(3);

    Assert.Equal(new Location(x, y), location);
  }
}