public class Solution {
    public int FindDuplicate(int[] nums) {
        var hashSet = new HashSet<int>();

        foreach(var num in nums) {
            if(hashSet.Contains(num))
                return num;
            hashSet.Add(num);
        }
        return -1;
        
    }
}
