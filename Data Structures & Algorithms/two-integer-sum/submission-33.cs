public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var dic = new Dictionary<int, int>();

        for(var i = 0; i < nums.Length; i++) {
            var num = target - nums[i];
            if(dic.ContainsKey(num))
                return new int[] {dic[num], i};
            
            dic[nums[i]] = i;
        }

        return null;
    }
}
