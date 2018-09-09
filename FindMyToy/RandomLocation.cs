using System;

internal class RandomLocation
  : IRandomLocation
{
  private readonly IRandom _random;
  private readonly Location[] _circleTurns;

  public RandomLocation(IRandom random)
  {
    _random = random;
    _circleTurns = new [] {
      Location.Right,
      Location.DownRight,
      Location.DownLeft,
      Location.Left
    };
  }

  public Location GetInRange(int range)
  {
    var numberOfLocations = GetNumberOfLocations(range - 1) + (range - 1) * 2;
    if (range == 1)
      numberOfLocations = 1;

    var index = _random.GetNext(0, numberOfLocations);

    if (index == 0)
      return Location.Origin;

    if (index < 1 * 6 + 1) {
      var currentLocation = Location.Origin.Add(Location.UpLeft);
      for( var i = 1; i < index; i++)
      {
        var turn = _circleTurns[i - 1];
        currentLocation = currentLocation.Add(turn);
      }
      return currentLocation;
    }

    throw new NotImplementedException();
  }

  private int GetNumberOfLocations(int range)
  {
    if (range == 1)
      return 1;

    return (range - 1) * 6;
  }
}