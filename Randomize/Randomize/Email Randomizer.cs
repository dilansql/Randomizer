using System;

namespace Dilan.Randomizers
{
    class EmailRandomizer : IRandomizer
    {
        public string GetRandomEntity()
            => ($"{Guid.NewGuid()}@{Guid.NewGuid()}.com");
    }
}
