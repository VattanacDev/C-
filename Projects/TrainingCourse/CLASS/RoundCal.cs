using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLASS
{
    class RoundCal
    {
        public float R=0f;
        public double S(float R)
        { 
            double SS=3.14*R*R;
            return SS;
        }
        public double P(float R)
        {
            double PP = 6.28 * R;
            return PP;
        }
    }
}
