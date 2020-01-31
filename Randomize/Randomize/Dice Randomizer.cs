using System;
using System.Collections.Generic;
using System.Text;

namespace Dilan.Randomizers
{
    class DiceRandomizer : IRandomizer
    {
        public string GetRandomEntity()
        {
            Random randint = new Random();
            var finalNum = randint.Next(1, 7);
            Console.WriteLine(finalNum);
        }
    }
}
