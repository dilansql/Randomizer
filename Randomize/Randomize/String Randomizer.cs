using System;
using System.Linq;

namespace Dilan.Randomizers
{
    class String_Randomizer : IRandomizer
    {
        public void GetRandomEntity()
        {
            var alphabet = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
            var randint = new Random();

            var newarrayint = new int[50]
                .Select(i => alphabet[randint.Next(0, alphabet.Length)]);

            Console.WriteLine(String.Join("", newarrayint));
        }
    }
}
