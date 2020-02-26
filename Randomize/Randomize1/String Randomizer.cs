using System;
using System.Linq;

namespace Randomizers
{
    class StringRandomizer : IRandomizer, IGeneralRandomizer
    {
        public string GetRandomEntity()
        {
            var alphabet = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
            var randint = new Random();

            var newarrayint = new int[50]
                .Select(i => alphabet[randint.Next(0, alphabet.Length)]);

            return String.Join("", newarrayint);
        }

        public string GetRandomEntity(int value)
        {
            var alphabet = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
            var randint = new Random();

            var newarrayint = new int[value]
                .Select(i => alphabet[randint.Next(0, alphabet.Length)]);

            return String.Join("", newarrayint);
        }
    }
}
