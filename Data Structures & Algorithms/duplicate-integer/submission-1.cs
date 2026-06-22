public class Solution {
    public bool hasDuplicate(int[] nums) {
        var hashset = new HashSet<int>(nums);

        return hashset.Count != nums.Length;
    }
}