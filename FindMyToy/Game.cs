public class Game
{
  internal Game(int mapSize, IRandomLocation randomLocation)
  {
    PlayerLocation = randomLocation.GetInRange(mapSize);
  }

  internal Location PlayerLocation { get; private set; }

  public void MoveUpLeft()
  {
    PlayerLocation = PlayerLocation.Add(Location.UpLeft);
  }
}