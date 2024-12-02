using System;
using System.Collections;
using System.Collections.Generic; 

public class Program
{
    public int LengthOfLongestSubstring(string s) {
        Dictionary<char, int> charCount = new Dictionary<char, int>();
        int startCount = 0;
        int max = 0;
        for (int i = 0; i < s.Length; i++) {
            if (charCount.ContainsKey(s[i])) {
                if (charCount[s[i]] < startCount) charCount[s[i]] = i;
                else {
                    var between = i - startCount;
                    if (between > max) max = between;
                    startCount = charCount[s[i]] + 1;
                    charCount[s[i]] = i;
                }
            }
            else {
                charCount.Add(s[i], i);
            }

            if (i == s.Length - 1 && i - startCount + 1 > max) max = i - startCount +1;

        }

        return max;
    }

    public static void Main(string[] args)
    {
        var p = new Program();
        Console.Write(p.LengthOfLongestSubstring("dassad"));
    }
}
