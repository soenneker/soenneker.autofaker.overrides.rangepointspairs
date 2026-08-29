using AwesomeAssertions;
using Soenneker.Dtos.RangePointsPairs;
using Soenneker.Tests.Unit;

namespace Soenneker.AutoFaker.Overrides.RangePointsPairs.Tests;

public sealed class RangePointsPairOverrideTests : UnitTest
{
    [Test]
    public void Generates_points_for_range_points_pair()
    {
        var autoFaker = new Soenneker.Utils.AutoBogus.AutoFaker();
        autoFaker.Config.Overrides = [new RangePointsPairOverride()];

        RangePointsPair result = autoFaker.Generate<RangePointsPair>();

        result.Points.Should().BeInRange(0, 20);
    }
}
