using System;

internal class RandomLocation
  : IRandomLocation
{
  private readonly IRandom _random;
  private readonly Location[] _circleTurns;

  public RandomLocation(IRandom random)
  {
    _random = random;
    _circleTurns = new[] {
      Location.Right,
      Location.DownRight,
      Location.DownLeft,
      Location.Left,
      Location.UpLeft
    };
  }

  public Location GetInRange(int range)
  {
    var numberOfLocations = GetNumberOfLocations(range);
    var index = _random.GetNext(0, numberOfLocations);

    if (index == 0)
      return Location.Origin;

    var currentLocation = Location.Origin.Add(Location.UpLeft);
    for (var i = 1; i < index; i++)
    {
      var turn = _circleTurns[i - 1];
      currentLocation = currentLocation.Add(turn);
    }
    return currentLocation;
  }

  private int GetNumberOfLocations(int range)
  {
    if (range == 0)
      return 1;

    return range * 6 + GetNumberOfLocations(range - 1);
  }
}