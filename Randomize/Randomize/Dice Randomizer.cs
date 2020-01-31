using System;

namespace Dilan.Randomizers
{
    class DiceRandomizer : IRandomizer
    {
        public string GetRandomEntity()
        {
            Random randint = new Random();
            return randint.Next(1, 7).ToString();
        }
    }
}
