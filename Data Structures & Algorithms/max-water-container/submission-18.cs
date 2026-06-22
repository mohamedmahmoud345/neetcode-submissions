public class Solution {
    public int MaxArea(int[] heights) {
        int l = 0; 
        int r = heights.Length - 1;
        var res = 0;

        while(l < r){
            
            var minBar = Math.Min(heights[l], heights[r]);
            var area = (r - l) * minBar;
            res = Math.Max(res, area);

            if(heights[l] <= heights[r])
                l++;
            else 
                r--;
        }

        return res;
    }
}
