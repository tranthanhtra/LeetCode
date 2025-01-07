using System;
using System.Collections;
using System.Collections.Generic; 

public class Program
{
    public string LongestPalindrome(string s) {
        var max = "";
        for (var i  = 0; i < s.Length; i++) {
            var left = i;
            var right = i;
            string count = "" + s[i];
            if (count.Length > max.Length) max = count;
            while (left > 0 && right < s.Length - 1) {
                left --;
                right ++;
                if (s[left] == s[right]) {
                    count = s[left] + count + s[right];
                    if (count.Length > max.Length) max = count;
                }
                else {
                    break;
                }
            }
            if (i < s.Length - 1 && s[i] == s[i+1]) {
                left = i;
                right = i + 1;
                count =  "" + s[left] + s[right];
                if (count.Length > max.Length) max = count;
                while (left > 0 && right < s.Length - 1) {
                    left --;
                    right ++;
                    if (s[left] == s[right]) {
                        count = s[left] + count + s[right];
                        if (count.Length > max.Length) max = count;
                    }                
                    else {
                        break;
                    }
                }
            }

        }
        return max;
    }

    public static void Main(string[] args)
    {
        var p = new Program();
        Console.WriteLine(p.LongestPalindrome("ccc"));
    }
}
