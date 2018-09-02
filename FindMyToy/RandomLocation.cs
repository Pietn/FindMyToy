internal class RandomLocation
  : IRandomLocation
{
  public readonly IRandom _random;

  public RandomLocation(IRandom random) {
    _random = random;
  }

  public Location GetInRange(int range)
  {
    var index = _random.GetNext(0, 1);
    return new Location(0, 0);
  }
}