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
    var numberOfLocations = GetNumberOfLocations(range) - range * 4;
    var index = _random.GetNext(0, numberOfLocations);
    var location = GetLocationAtIndex(index);

    return location;
  }

  private int GetNumberOfLocations(int range)
  {
    if (range == 0)
      return 1;

    return range * 6 + GetNumberOfLocations(range - 1);
  }

  private Location GetLocationAtIndex(int index)
  {
    if (index == 0)
      return Location.Origin;

    var range = GetRangeForIndex(index);
    var currentLocation = GetStartLocationForRange(range);
    var startIndex = GetNumberOfLocations(range - 1);

    for (var i = startIndex; i < index; i++)
    {
      var turn = _circleTurns[(i - startIndex) / range];
      currentLocation = currentLocation.Add(turn);
    }
    return currentLocation;
  }

  private int GetRangeForIndex(int index)
  {
    var range = 0;

    while (GetNumberOfLocations(range) <= index)
      range++;

    return range;
  }

  private Location GetStartLocationForRange(int range)
  {
    var location = Location.Origin;

    for (var i = 0; i < range; i++)
      location = location.Add(Location.UpLeft);

    return location;
  }
}