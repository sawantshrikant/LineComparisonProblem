using System;
namespace LineComparision
{
    public class Program
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Welcome to line calculator");
            Console.WriteLine("Enter x1: ");
            int x1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter y1: ");
            int y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter x2: ");
            int x2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter y2: ");
            int y2 = Convert.ToInt32(Console.ReadLine());
            CalculateLength calculateLength = new CalculateLength(x1, y1, x2, y2);
            double line1 = calculateLength.calculate();
            Console.WriteLine("Enter x3: ");
            int x3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter y3: ");
            int y3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter x4: ");
            int x4 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter y4: ");
            int y4 = Convert.ToInt32(Console.ReadLine());
            CalculateLength calculateLength1 = new CalculateLength(x3, y3, x4, y4);
            double line2 = calculateLength.calculate();
            calculateLength1.EqualityCheck(line1, line2);
        }
    }
}