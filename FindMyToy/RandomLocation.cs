using System;

internal class RandomLocation
  : IRandomLocation
{
  public readonly IRandom _random;

  public RandomLocation(IRandom random)
  {
    _random = random;
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
        currentLocation = currentLocation.Add(Location.Right);
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