[![](https://img.shields.io/nuget/v/soenneker.autofaker.overrides.rangepointspairs.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.autofaker.overrides.rangepointspairs/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.autofaker.overrides.rangepointspairs/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.autofaker.overrides.rangepointspairs/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.autofaker.overrides.rangepointspairs.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.autofaker.overrides.rangepointspairs/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.autofaker.overrides.rangepointspairs/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.autofaker.overrides.rangepointspairs/actions/workflows/codeql.yml)

# Soenneker.AutoFaker.Overrides.RangePointsPairs

An AutoFaker override for the points value in a `RangePointsPair` fixture.

## Installation

```bash
dotnet add package Soenneker.AutoFaker.Overrides.RangePointsPairs
```

## Usage

```csharp
using Soenneker.AutoFaker.Overrides.MinMax;
using Soenneker.AutoFaker.Overrides.RangePointsPairs;
using Soenneker.Dtos.RangePointsPairs;
using Soenneker.Utils.AutoBogus;

var autoFaker = new AutoFaker();
autoFaker.Config.Overrides =
[
    new MinMaxOverride(),
    new RangePointsPairOverride()
];

RangePointsPair pair = autoFaker.Generate<RangePointsPair>();
```

The override assigns `Points` an integer from `0` through `20`, inclusive. Register `MinMaxOverride` as shown when the nested `Range` must also preserve ordered bounds.
