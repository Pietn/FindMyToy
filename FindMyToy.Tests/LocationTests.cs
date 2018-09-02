using Xunit;

public class LocationTests
{
  [Fact]
  public void When2LocationsHaveEqualXandY_ThenThyAreEqual()
  {
    var location1 = new Location(1, 2);
    var location2 = new Location(1, 2);

    var areEquel = location1.Equals(location2);

    Assert.True(areEquel);
  }

  [Fact]
  public void WhenComparedWithOtherType_ThenTheyAreNotEqual()
  {
    var location = new Location(0, 0);
    var other = new object();

    var areEquel = location.Equals(other);

    Assert.False(areEquel);
  }

  [Fact]
  public void WhenComparedWithNull_ThenTeyAreNotEqual()
  {
    var location = new Location(0, 0);

    var areEquel = location.Equals(null);

    Assert.False(areEquel);
  }
}