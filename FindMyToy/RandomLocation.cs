internal class RandomLocation
  : IRandomLocation
{
  public readonly IRandom _random;

  public RandomLocation(IRandom random) {
    _random = random;
  }

  public Location GetInRange(int range)
  {
    var numberOfLocations = 1 + (range - 1) * 2;
    var index = _random.GetNext(0, numberOfLocations);
    return new Location(0, 0);
  }
}