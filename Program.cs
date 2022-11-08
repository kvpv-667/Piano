internal class Program
{
    static void Main()
    {
        Console.WriteLine("Piano octaves n switching");
        ccc();
    }
    static void ccc()
    {
        int[] one = new int[12] { 3270, 3460, 3670, 3880, 4120, 4360, 4620, 4900, 5190, 5500, 5820, 6170 };
        int[] two = new int[12] { 6540, 6930, 7340, 7770, 8240, 8730, 9250, 9800, 10300, 11000, 11600, 12300 };

        while (true)
        {

            ConsoleKeyInfo x = Console.ReadKey();


            if (x.Key == ConsoleKey.F1)
            {
                oct(one);
            }
            if (x.Key == ConsoleKey.F2)
            {
                oct(two);
            }
        }
    }
    static void oct(int[] aezakmi)
    {
        ConsoleKeyInfo i = Console.ReadKey();
        while (i.Key != ConsoleKey.Escape)
        {
            if (i.Key == ConsoleKey.Z)
            {
                Console.Beep(aezakmi[0], 400);
            }
            if (i.Key == ConsoleKey.X)
            {
                Console.Beep(aezakmi[1], 400);
            }
            if (i.Key == ConsoleKey.C)
            {
                Console.Beep(aezakmi[2], 400);
            }
            if (i.Key == ConsoleKey.V)
            {
                Console.Beep(aezakmi[3], 400);
            }
            if (i.Key == ConsoleKey.B)
            {
                Console.Beep(aezakmi[4], 400);
            }
            if (i.Key == ConsoleKey.N)
            {
                Console.Beep(aezakmi[5], 400);
            }
            if (i.Key == ConsoleKey.M)
            {
                Console.Beep(aezakmi[6], 400);
            }
            if (i.Key == ConsoleKey.A)
            {
                Console.Beep(aezakmi[7], 400);
            }
            if (i.Key == ConsoleKey.S)
            {
                Console.Beep(aezakmi[8], 400);
            }
            if (i.Key == ConsoleKey.D)
            {
                Console.Beep(aezakmi[9], 400);
            }
            if (i.Key == ConsoleKey.F)
            {
                Console.Beep(aezakmi[10], 400);
            }
            if (i.Key == ConsoleKey.G)
            {
                Console.Beep(aezakmi[11], 400);
            }
            i = Console.ReadKey();
        }
    }

}