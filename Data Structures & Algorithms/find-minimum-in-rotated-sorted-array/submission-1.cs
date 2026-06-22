public class Solution {
    public int FindMin(int[] nums) {
        int l = 0;
        int r = nums.Length - 1;
        int res = int.MaxValue;
        while (l <= r)
        {
            int mid = (l + r) / 2;
            res = Math.Min(res, nums[mid]);
            if (nums[r] < nums[mid])
            {
                l = mid + 1;
            }
            else
                r = mid - 1;
        }

        return res;
    }
}
