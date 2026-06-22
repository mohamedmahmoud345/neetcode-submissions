public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        var list = new List<int>();

        for(var i = 0; i < nums.Length; i++) {
            int num= 1;
            for(var j = 0; j < nums.Length; j++) {
                if(j == i)
                    continue;
                num *= nums[j];
            }
            list.Add(num);
        }
        return list.ToArray();
    }
}
