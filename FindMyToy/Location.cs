internal class Location
{
  public static Location Origin { get; }
  public static Location UpLeft { get; }
  public static Location DownLeft { get; }
  public static Location Right { get; }
  public static Location DownRight { get; }

  static Location()
  {
    Origin = new Location(0, 0);
    UpLeft = new Location(0, 1);
    Right = new Location(1, -1);
    DownRight = new Location(0, -1);
    DownLeft = new Location(-1, 0);
  }

  public Location(int x, int y)
  {
    X = x;
    Y = y;
  }

  public int X { get; }

  public int Y { get; }

  public Location Add(Location location)
  {
    return new Location(X + location.X, Y + location.Y);
  }

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