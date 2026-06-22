public class Solution {
    public bool hasDuplicate(int[] nums) {
        var dic = new Dictionary<int, int>();

        foreach(var num in nums) {
            if(dic.ContainsKey(num))
                return true;

            dic[num] = 1;
        }

        return false;
    }
}