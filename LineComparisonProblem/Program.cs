using System;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Welcome to Line Comparison Computation Program");

        Console.Write("Enter x1: ");
        int x1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter y1: ");
        int y1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter x2: ");
        int x2 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter y2: ");
        int y2 = Convert.ToInt32(Console.ReadLine());

        CalLength line = new CalLength(x1, y1, x2, y2);
        double length = line.GetLength();

        Console.WriteLine("Length of the line: " + length);
    }
}