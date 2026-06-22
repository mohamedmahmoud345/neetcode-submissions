public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        int l = 0;
        int r = numbers.Length - 1;

        while(l < r) {
            var res = numbers[l] + numbers[r];

            if(res == target)   
                return new int[] {l + 1 , r + 1};

            if(res < target)
                l++;
            else 
                r--;
        }
        return new int[] {};
    }
}
