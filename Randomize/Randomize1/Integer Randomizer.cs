using System;
using System.Collections.Generic;
using System.Text;

namespace Randomizers
{
    class IntegerRandomizer : IRandomizer, IGeneralRandomizer
    {

        public string GetRandomEntity()
        {
            Random randint = new Random();
            return randint.Next(1, 50).ToString();
        }

        public string GetRandomEntity(int p)
        {
            Random randint = new Random();
            var values = new List<int>();
            
            for (int i = 0; i <= p-1; i++) 
            { 
                values.Add(randint.Next(1, 9));
            }

            var stringBuilder = new StringBuilder();
            foreach (var i in values)
            {
                stringBuilder.Append(i.ToString());
            }

            return stringBuilder.ToString();
        }
    }
}
