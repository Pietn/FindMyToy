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
      var start = Location.Origin.Add(Location.UpLeft);
      return start;
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