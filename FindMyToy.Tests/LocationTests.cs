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
}