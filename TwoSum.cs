using System;
using System.Collections;

public class Program
{
    public int[] TwoSum(int[] nums, int target) {
        Hashtable hashTable = new Hashtable();

        int sum1 = 0;
        int sum2 = 0;
        int[] result = new int[2];
        for (var i = 0; i < nums.Length; i++) {
            if (hashTable.ContainsKey(nums[i])) {
                    sum1 = i;
                    sum2 = (int)hashTable[nums[i]];
                    break;
            }
            else if (!hashTable.ContainsKey(target - nums[i]))hashTable.Add(target - nums[i], i);
        }
        result[0] = sum1;
        result[1] = sum2;

        return result;
    }

    public static void Main(string[] args)
    {
        Program program = new Program();
        var result = program.TwoSum( new int[] {1,1,1,1,1,1,1,7,5}, 12);
        Console.WriteLine(result[0]);
        Console.WriteLine(result[1]);
    }
}
