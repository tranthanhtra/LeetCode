using System;
using System.Collections;

public class Program
{
    public bool IsPalindrome(int x) {
        if (x < 0) return false;
        int temp = x;
        int reverse = 0;
        while (temp > 0) {
            reverse = reverse * 10 + temp % 10;
            temp = temp / 10;
        }

        return reverse == x;
    }

    public static void Main(string[] args)
    {
        Program program = new Program();
        Console.WriteLine(program.IsPalindrome(313));
    }
}
