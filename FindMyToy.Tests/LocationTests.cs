using Xunit;

public class LocationTests
{
  [Fact]
  public void When2LocationsHaveEqualXandY_ThenTheyAreEqual()
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
  public void WhenComparedWithNull_ThenTheyAreNotEqual()
  {
    var location = new Location(0, 0);

    var areEquel = location.Equals(null);

    Assert.False(areEquel);
  }

  [Fact]
  public void When2LocationsHaveDifferentX_ThenTheyAreNotEqual()
  {
    var location1 = new Location(1, 2);
    var location2 = new Location(3, 2);

    var areEquel = location1.Equals(location2);

    Assert.False(areEquel);
  }
  
  [Fact]
  public void When2LocationsHaveDifferentY_ThenTheyAreNotEqual()
  {
    var location1 = new Location(1, 2);
    var location2 = new Location(1, 4);

    var areEquel = location1.Equals(location2);

    Assert.False(areEquel);
  }

  [Fact]
  public void When2LocationsHaveEqualXAndY_ThenTheyHaveSameHashCode()
  {
    var location1 = new Location(1, 2);
    var location2 = new Location(1, 2);

    var areEquel = location1.GetHashCode().Equals(location2.GetHashCode());

    Assert.True(areEquel);
  }
}