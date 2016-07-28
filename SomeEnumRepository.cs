using System;
using System.Collections.Generic;
using System.Linq;

namespace EnumBenchmarkApplication
{
public static class SomeEnumRepository {
    private static readonly Dictionary<SomeEnum, string> _namesBySomeEnum;

    static SomeEnumRepository()
    {
        _namesBySomeEnum = Enum.GetValues(typeof(SomeEnum))
            .Cast<SomeEnum>()
            .ToDictionary(v=>v, v=>v.ToString());
    }

    public static string ToStringFromDictionary(this SomeEnum se)
    {
        return _namesBySomeEnum[se];
    }
}
}