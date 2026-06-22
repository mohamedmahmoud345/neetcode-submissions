public class Solution {
    public bool hasDuplicate(int[] nums)
{
    for (var j = 0; j < nums.Length; j++)
    {
        for (var i = 0; i < nums.Length; i++)
        {
            if (j == i)
                continue;
            if (nums[j] == nums[i])
            {
                return true;
            }
        }
    }
    return false;
}
}
