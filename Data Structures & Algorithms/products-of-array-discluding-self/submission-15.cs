public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        var prefix = new int[nums.Length];
        prefix[0] = 1;
        for(var i = 1; i < nums.Length; i++){
            prefix[i] = prefix[i - 1] * nums[i - 1];
        }

        var suffix = new int[nums.Length];
        suffix[nums.Length - 1] = 1;
        for(var i = nums.Length - 2; i >= 0; i--){
            suffix[i] = nums[i + 1] * suffix[i + 1];
        }

        var res = new int[nums.Length];
        for(var i = 0; i < nums.Length; i++){
            res[i] = prefix[i] * suffix[i];
        }

        return res;
    }
}
