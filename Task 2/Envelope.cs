using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Envelope
    {
        public Envelope(double a, double b)
        {
            SideA = a;
            SideB = b;
        }
        public double SideA { get; init; }
        public double SideB { get; init; }
        public bool CanBeInsertedIn(Envelope env)
        {
            if (SideA < env.SideA && SideB < env.SideB)
                return true;
            if (SideA < env.SideB && SideB < env.SideA)
                return true;

            return false;
        }
    }
}
