using Xunit;

public class GameTests
{
  [Fact]
  public void WhenNewGameWithMapSize1_ThenPlayerStartsAtOrigin()
  {
    var game = new Game(1);
    Assert.Equal(new Location(0, 0), game.PlayerLocation);
  }
}