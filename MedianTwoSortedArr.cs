using System;
using System.Collections;

public class Program
{
    // public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
    //     int[] combine = new int[nums1.Length + nums2.Length];

    //     int i1 = 0;
    //     int i2 = 0;
    //     while (i1 < nums1.Length || i2 < nums2.Length) {
    //         if (i2 < nums2.Length && (i1 == nums1.Length || nums2[i2] < nums1[i1])) {
    //             combine[i1 + i2] = nums2[i2];
    //             i2++;
    //         }
    //         else {
    //             combine[i1 + i2] = nums1[i1];
    //             i1++;
    //         }
    //         // Console.WriteLine(i1 + ";" + i2);
    //         // Console.WriteLine(combine[i1 + i2]);
    //     }

    //     if (combine.Length % 2 == 0) return (double)(combine[combine.Length / 2] + combine[combine.Length / 2 - 1]) /2;
    //     else return (double) combine[combine.Length / 2];
    // }

    public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
        int k = (nums1.Length + nums2.Length) / 2 + (nums1.Length + nums2.Length) % 2;


        int passed1 = 0;
        int passed2 = 0;
        int left1 = 1;
        int left2 = 1;

        while (k >= 0) {
            Console.WriteLine(k + "," + left1 +"," + left2);
            if (nums1.Length <= passed1) {
                passed2 += k - 1;
                if ((nums1.Length + nums2.Length) % 2 == 0) {
                   return (double)(nums2[passed2 + left2 - 1] + nums2[passed2 + left2]) / 2;
                } else {
                    return (double)nums2[passed2 + left2 - 1];
                }
            }
            if (nums2.Length <= passed2) {
                passed1 += k - 1;
                if ((nums1.Length + nums2.Length) % 2 == 0) {
                   return (double)(nums1[passed1 + left1 - 1] + nums1[passed1 + left1]) / 2;
                } else {
                    return (double)nums1[passed1 + left1 - 1];
                }
            }
            if (k == 1) break;
            var each = Math.Min(Math.Min(k / 2, nums1.Length - passed1), nums2.Length - passed2);
            left1 = each;
            left2 = each;
            Console.WriteLine(each);
            if (nums1[passed1 + left1 - 1] < nums2[passed2 + left2 - 1]) {
                passed1 += left1;
                k -= left1;
            } else {
                passed2 += left2;
                k-= left2;
            }
        }


        if ((nums1.Length + nums2.Length) % 2 == 0) return ((double)(nums1[passed1 + left1 - 1] + nums2[passed2 + left2 - 1]) / 2);
        else return (double)Math.Min(nums1[passed1 + left1 - 1], nums2[passed2 + left2 - 1]);
    }

    public static void Main(string[] args)
    {
        Program program = new Program();
        Console.WriteLine(program.FindMedianSortedArrays(new int[]{100}, new int[]{1,2,3,4}));
    }
}