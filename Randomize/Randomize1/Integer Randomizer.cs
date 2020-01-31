using System;

namespace Randomizers
{
    class IntegerRandomizer : IRandomizer
    {
        public string GetRandomEntity()
        {
            Random randint = new Random();
            return randint.Next(1, 50).ToString();
        }
    }
}
