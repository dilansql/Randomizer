using System;
using StringRandomizer = Randomizers.StringRandomizer;

namespace Randomizers
{
    class EmailRandomizer : IRandomizer
    {

        public string GetRandomEntity()
        {
            var stringRandomizer = new StringRandomizer();
            return $"{ (stringRandomizer.GetRandomEntity()).Substring(1,10).ToLower()}@{(stringRandomizer.GetRandomEntity()).Substring(15,20).ToLower()}.com";
        }
    }
}
