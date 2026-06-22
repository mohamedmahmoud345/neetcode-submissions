public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int n = nums.Length;

        int[] res = new int[n];
        int[] pref = new int[n];
        int[] sufx = new int[n];

        pref[0] = 1;
        for(var i = 1; i < n; i++){
            pref[i] = nums[i - 1] * pref[i - 1];
        }
        sufx[n - 1] = 1;
        for(var i = n - 2; i >=0; i--) {
            sufx[i] = nums[i + 1] * sufx[i + 1];
        }
        for(var i = 0 ; i < n; i++){
            res[i] = pref[i] * sufx[i];
        }
        return res;
    }
}
