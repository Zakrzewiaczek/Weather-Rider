using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weather_Rider
{
    public static class Conversion
    {
        public static int KphToBeaufort(double kph)
        {
            if (kph < 1)
                return 0;
            if (kph < 6)
                return 1;
            if (kph < 12)
                return 2;
            if (kph < 20)
                return 3;
            if (kph < 29)
                return 4;
            if (kph < 39)
                return 5;
            if (kph < 50)
                return 6;
            if (kph < 62)
                return 7;
            if (kph < 75)
                return 8;
            if (kph < 89)
                return 9;
            if (kph < 103)
                return 10;
            if (kph < 118)
                return 11;
            return 12;
        }
    }
}
