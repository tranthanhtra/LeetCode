using System;
using System.Collections;



public class Program
{

    const int MAX = 2147483647;
    const int MIN = -2147483648;
    public int Reverse(int x) {
        int rev = 0;
        while (x != 0) {
            int pop = x % 10;
            x /= 10;
            if (rev > int.MaxValue / 10 ||
                (rev == int.MaxValue / 10 && pop > 7))
                return 0;
            if (rev < int.MinValue / 10 ||
                (rev == int.MinValue / 10 && pop < -8))
                return 0;
            rev = rev * 10 + pop;
        }

        return rev;
    }

    public static void Main(string[] args)
    {
        Program program = new Program();
        Console.WriteLine(program.Reverse(563847412));
    }
}
