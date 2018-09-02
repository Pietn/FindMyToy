internal class Location
{
  public Location(int x, int y)
  {
    X = x;
    Y = y;
  }

  public int X { get; }

  public int Y { get; }

  public override bool Equals(object obj)
  {
    var other = obj as Location;

    if (other == null)
      return false;

    return other.X == X && other.Y == Y;
  }

  public override int GetHashCode()
  {
    var hash = 13;
    hash = hash * 7 + X.GetHashCode();
    hash = hash * 7 + Y.GetHashCode();
    return hash;
  }
}