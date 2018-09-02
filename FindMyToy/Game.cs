public class Game
{
  public Game(int mapSize)
  {
    PlayerLocation = new Location(0, 0);
  }

  internal Location PlayerLocation { get; private set; }
}