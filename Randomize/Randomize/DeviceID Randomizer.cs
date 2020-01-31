using Dilan.Randomizers;
using System;
using System.Text;

namespace Randomize.Randomize
{
    class DeviceIDRandomizer : IRandomizer
    {
        public string GetRandomEntity()
            => GenerateDeviceId();

        public static string GenerateDeviceId()
        {
            var guid = Guid.NewGuid().ToString().Replace("-", "").Substring(0, 16);
            var count = 0;
            var eui64 = new StringBuilder();
            foreach (var character in guid)
            {
                if (count % 2 == 0 && count > 0)
                    eui64.Append($"-{character}");
                else
                    eui64.Append(character);

                count++;
            }

            return eui64.ToString().ToUpper();
        }
    }
}
