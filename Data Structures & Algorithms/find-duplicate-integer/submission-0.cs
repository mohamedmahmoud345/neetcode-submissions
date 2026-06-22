public class Solution {
    public int FindDuplicate(int[] nums) {
        Array.Sort(nums);

        for(var i = 1; i < nums.Length; i++) {
            if(nums[i - 1] == nums[i])
                return nums[i - 1];
        }
        return -1;
    }
}
