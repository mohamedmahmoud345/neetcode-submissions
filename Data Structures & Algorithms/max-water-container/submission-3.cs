public class Solution {
    public int MaxArea(int[] heights) {
        int left = 0;
        int right = heights.Length - 1;
        int result = -1;
        while(left < right) {
            int res = (Math.Abs(left - right) * Math.Min(heights[left] , heights[right]));
            result = Math.Max(result, res);
            if(heights[left] <= heights[right]){
                left++;
            }else 
                right--;
        }
        return result;
    }
}
