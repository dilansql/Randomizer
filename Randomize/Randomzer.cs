using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Randomize
{
    public class Randomzer : IRandomzer
    {
        private readonly RandomizeOptions _randomizeOptions;

        public Randomzer(IOptions<RandomizeOptions> options, IOptions<MyNewOptions> options2)
        {
            _randomizeOptions = options.Value;
            var x = options2.Value;
        }

        public void DoStuff()
        {

        }
    }
}
