public class Solution {
    public int[] TwoSum(int[] nums, int target) {

        for(var i = 0; i < nums.Length; i++) {
            var num = target - nums[i];
            var j = Array.IndexOf(nums, num, i + 1);
            if(j != -1){
                return new int[] {i, j};
            }
        }
        return null;
    }
}
