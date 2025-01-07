using System;
using System.Collections;
using System.Collections.Generic;

public class Program
{

	public string Convert(string s, int numRows) {
        int divide = 2 * (numRows - 1);
        if (divide == 0) return s;
        string result = "";

        var tops = s.Length / divide + 1;
        int index = 0;
        for (var i = 0; i < numRows; i++) {
        	for (int j = 0; j < tops; j++) {
        		index = divide * j + i;
        		if (index >= 0 && index < s.Length) result += s[index];
        		if (i != 0 && i != numRows - 1) {
        			index = divide * j + divide - i;
	        		if (index >= 0 && index < s.Length)
	        			result += s[index];
        		}
        	}
        }
        return result;
    }

    public static void Main(string[] args)
    {
    	var p = new Program();
    	Console.WriteLine(p.Convert("PAYPALISHIRING", 4));
    }
}
