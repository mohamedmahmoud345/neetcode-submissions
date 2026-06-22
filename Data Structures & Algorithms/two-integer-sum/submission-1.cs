public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var map = new Dictionary<int,int>();

        for(var i = 0; i < nums.Length; i++) {
            var sub = target - nums[i];
            if(map.ContainsKey(sub))
                return new int[] {map[sub] , i};
            map.Add(nums[i] , i);
        }

        return new int[] {};
    }
}
