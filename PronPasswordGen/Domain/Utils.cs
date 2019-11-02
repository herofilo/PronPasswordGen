using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PronPasswordGen.Domain
{
    public static class Utils
    {
        private static Random _random = new Random();


        public static bool Coin()
        {
            return ((_random.Next(10) % 2) == 0);
        }



    }
}
