using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparision
{
    public class CalculateLength
    {
        int x1, y1, x2, y2;
        public CalculateLength(int x1, int y1, int x2, int y2)
        {
            this.x1 = x1;
            this.y1 = y1;
            this.x2 = x2;
            this.y2 = y2;
        }
        public double calculate()
        {
            double length = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
            return length;
        }
        public void equalChceck(double line1, double line2)
        {
            if (line1.Equals(line2))
                Console.WriteLine("Both lines are equal");
            else
                Console.WriteLine("Lines are not equal");
        }
    }
}