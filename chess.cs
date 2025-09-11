using System.Security.Cryptography.X509Certificates;

namespace PKPZlab1
{
    public static class Chess
    {
        public static int[] Input()
        {
            int[] outp = new int[2];
            Console.WriteLine("Enter X:");
            outp[0] = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Y:");
            outp[1] = int.Parse(Console.ReadLine());
            if (outp[0] > 8 || outp[0] < 0 || outp[1] > 8 || outp[1] < 0)
            {
                Console.WriteLine("Entered wrong value! Start again");
                Input();
            }
            return outp;
        }

        public static bool CheckArrInent(int[] arr1, int[] arr2)
        {
            if (arr1[0] == arr2[0] && arr1[1] == arr2[1])
            {
                return true;
            }
            return false;
        }

        public static bool HorseReach(int[] enemy, int[] horse)
        {
            int[][] moves = new int[][]
           {
                new int[] { 2, 1 }, new int[] { 1, 2 }, new int[] { -1, 2 }, new int[] { -2, 1 },
                new int[] { -2, -1 }, new int[] { -1, -2 }, new int[] { 1, -2 }, new int[] { 2, -1 }
           };

            foreach (var move in moves)
            {
                int newX = horse[0] + move[0];
                int newY = horse[1] + move[1];
                if (newX == enemy[0] && newY == enemy[1])
                {
                    return true;
                }

            }
            return false;
        }
        public static void Chessplay(int[] white_king, int[] black_horse, int[] black_bishop)
        {
            Console.WriteLine("If white king moves first: \n");
            if (Math.Abs(black_horse[0] -  white_king[0]) == 1 || Math.Abs(black_horse[1] - white_king[1]) == 1) {
                //King kills black horse//
                white_king = black_horse;
                // diagonal: |x1 - x2| == |y1 - y2|
                if (Math.Abs(white_king[0] - black_bishop[0]) == Math.Abs(white_king[1] - black_bishop[1]))
                {
                    Console.WriteLine("Defence! white king kills black horse and black bishop kills the king!");
                }
                else
                {
                    Console.WriteLine("Attack! white king kills black horse!");
                }
            }
            if ((Math.Abs(black_horse[0] - white_king[0]) == 1 || Math.Abs(black_horse[1] - white_king[1]) == 1))
            {
                // king kills bishop//
                int[] newCor = white_king;
                newCor = black_bishop;
                if (Chess.HorseReach(newCor, black_horse))
                {
                    Console.WriteLine("Attack! white king kills black bishop and black horse kills the king!");
                }
                else 
                { 
                    Console.WriteLine("Nothing happens, just regular move");
                }
            }
            Console.WriteLine("If black horse moves first \n");
            if (HorseReach(white_king, black_horse))
            {
                Console.WriteLine("Attack! Black horse kills white king!");
            }
            else
            {
                Console.WriteLine("Nothing happens, regular move.");
            }
            Console.WriteLine("If black bishop moves first");
            if (Math.Abs(white_king[0] - black_bishop[0]) == Math.Abs(white_king[1] - black_bishop[1]))
            {
                Console.WriteLine("Attack! Black Bishop kills white king!");
                return;
            }
            Console.WriteLine("Nothing happens. Regular move.");
        }
    }

}

