public class Solution {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
        int[] merged = nums1.Concat(nums2).OrderBy(x => x).ToArray();
    var half = merged.Length / 2;

     int totalLen = merged.Length;
        if (totalLen % 2 == 0) {
            return (merged[totalLen / 2 - 1] + merged[totalLen / 2]) / 2.0;
        } else {
            return merged[totalLen / 2];
        }
    }
}
