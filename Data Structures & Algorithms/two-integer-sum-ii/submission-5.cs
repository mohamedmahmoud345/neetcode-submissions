public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        int l = 0;
        int r = numbers.Length - 1;

        while(l < r) {
            var sum = numbers[l] + numbers[r];

            if(sum == target){
                return [l + 1,r + 1];
            }
            else if(sum >= target){
                r--;
            }else {
                l++;
            }
        }   

        return null;
    }
}
