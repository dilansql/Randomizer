using System;

namespace Randomizers
{
    class EmailRandomizer : IRandomizer
    {
        public string GetRandomEntity()
            => ($"{Guid.NewGuid()}@{Guid.NewGuid()}.com");
    }
}
