using System.Drawing;


namespace PKPZlab1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Choose x:");
            //float x = float.Parse(Console.ReadLine());
            //Console.WriteLine("Choose y:");
            //float y = float.Parse(Console.ReadLine());
            //Console.WriteLine("Choose Radius:");
            //float R = float.Parse(Console.ReadLine());
            //Console.WriteLine(Lab.InArea(x, y, R));
            Console.WriteLine("Enter white king coordinates");
            int[] wk = Chess.Input();
            Console.WriteLine("Enter black horse coordinates");
            int[] bh = Chess.Input();
            Console.WriteLine("Enter black bishop coordinates");
            int[] bb = Chess.Input();
            if (Chess.CheckArrInent(wk,bh) || Chess.CheckArrInent(bh,bb) || Chess.CheckArrInent(wk,bb))
            {
                Console.WriteLine("Chesspieces are on the same x and y! retry!!!");
                Main(args);
            }
            Chess.Chessplay(wk, bh, bb);
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

