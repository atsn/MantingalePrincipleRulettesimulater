using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MantingalePrincipleRulettesimulater
{
    class RulleteController
    {
        private bool betOnEven { get; set; }
        private bool BenOnOdd { get; set; }
        private bool RouletteNumber { get; set; }


        public int getrouletenumber() { int RouletteNumber = 0; return RouletteNumber; }




        public bool betEven(bool isbettingeven)
        {

            int RouletteNumber = getrouletenumber();

            if (IsOdd(RouletteNumber))
            {
                return true;
            }

            else return false;
        }
        


        private static bool IsOdd(int value)
        {
            return value % 2 != 0;
        }
    }


}

