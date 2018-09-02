using Moq;
using Xunit;

public class GameTests
{
  [Fact]
  public void WhenNewGame_ThenGetRandomLocationForPlayer()
  {
    var randomLocation = new Mock<IRandomLocation>();
    randomLocation
      .Setup(t => t.GetInRange(2))
      .Returns(() => new Location(0, 1));
    var game = new Game(2, randomLocation.Object);

    Assert.Equal(new Location(0, 1), game.PlayerLocation);
  }
}