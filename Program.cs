using System.Drawing;

namespace PKPZlab1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose x:");
            float x = float.Parse(Console.ReadLine());
            Console.WriteLine("Choose y:");
            float y = float.Parse(Console.ReadLine());
            Console.WriteLine("Choose Radius:");
            float R = float.Parse(Console.ReadLine());
            Console.WriteLine(Lab.InArea(x, y, R));
        }
    }
    public static class Lab
    {
         public static string InArea(float x, float y, float R)
        {
            if (x < 0 && y > 0)
            {
                double point = (x * x + y * y);
                if (point <= R * R)
                {
                    if (point == R * R)
                    {
                        return "On the EDGE!";
                    }
                    return "In the Area!";
                }
                return "Not on the Area!";
            }
            if (x > 0 && y < 0)
            {
                double yAC = -2 * x;
                double yBC = 2 * (x - R);
                if (y >= yAC && y >= yBC)
                {
                    if (y == yAC && y == yBC) { return "On EDGE!"; }
                    return "On the Area!";
                }
            return "Not on the Area!";
            }
            return "Not on the Area!";
        }
    }
}

