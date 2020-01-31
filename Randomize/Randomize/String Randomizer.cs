using System;
using System.Linq;

namespace Dilan.Randomizers
{
    class StringRandomizer : IRandomizer
    {
        public string GetRandomEntity()
        {
            var alphabet = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
            var randint = new Random();

            var newarrayint = new int[50]
                .Select(i => alphabet[randint.Next(0, alphabet.Length)]);

            return String.Join("", newarrayint);
        }
    }
}
