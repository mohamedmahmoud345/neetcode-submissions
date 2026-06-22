public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        var res = new List<int>();

        for(var i = 0; i < nums.Length; i++) {
            int sum = 1;
            for(var j = 0; j < nums.Length; j++){
                if(i == j) continue;
                sum *= nums[j];
            }
            res.Add(sum);
        }

        return res.ToArray();
    }
}
