public class Solution {
    public int[] TwoSum(int[] nums, int target) {

        var dic = new Dictionary<int,int>();

        for(var i= 0; i < nums.Length ; i++) {
            var res = target - nums[i];

            if(dic.ContainsKey(res)){
                return new int[] {dic[res] , i};
            }
            else 
                dic[nums[i]] = i;
        }
        return new int[] {};
    }
}
