using System;
using StringRandomizer = Randomizers.StringRandomizer;

namespace Randomizers
{
    class EmailRandomizer : IRandomizer
    {

        public string GetRandomEntity()
        {
            var stringRandomizer = new StringRandomizer();
            return $"{ (stringRandomizer.GetRandomEntity()).Substring(40).ToLower()}@{(stringRandomizer.GetRandomEntity()).Substring(40).ToLower()}.com";
        }
    }
}
