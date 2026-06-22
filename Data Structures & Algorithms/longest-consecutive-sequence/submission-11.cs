public class Solution {
    public int LongestConsecutive(int[] nums) {
        if (nums.Length == 0) return 0;
        var hashSet = new HashSet<int>(nums);
        int longest = 0;

        foreach(var num in hashSet){
            if(!hashSet.Contains(num - 1)) {
                int length = 1;
                while(hashSet.Contains(num + length))
                {
                    length++;
                }
                longest = Math.Max(longest, length);
            }
        }
        return longest;
    }
}
