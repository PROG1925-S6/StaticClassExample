using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticClassExample
{
    internal class Calculator
    {
        static private double gravity = 9.8;

        static public int Add(int x, int y)
        {
            return x + y;
        }

        static public int Subtract(int x, int y)
        {
            return x - y;
        }

        static public double Velocity(double seconds)
        {
            double speed = gravity * seconds;
            return speed;
        }

        static public void SetGravity(double newGravity)
        {
            gravity = newGravity;
        }
    }
}
