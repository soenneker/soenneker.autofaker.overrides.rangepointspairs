using Soenneker.Dtos.RangePointsPairs;
using Soenneker.Utils.AutoBogus.Context;
using Soenneker.Utils.AutoBogus.Override;

namespace Soenneker.AutoFaker.Overrides.RangePointsPairs;

/// <summary>
/// An AutoFaker (AutoBogus) override for the object RangePointsPair
/// </summary>
public sealed class RangePointsPairOverride : AutoFakerOverride<RangePointsPairOverride>
{
    /// <summary>
    /// Executes the generate operation.
    /// </summary>
    /// <param name="context">The context.</param>
    public override void Generate(AutoFakerOverrideContext context)
    {
        var target = (context.Instance as RangePointsPair)!;
        target.Points = context.Faker.Random.Int(0, 20);
    }
}
