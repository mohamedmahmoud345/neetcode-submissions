public class Solution {
    public int MaxArea(int[] heights) {
        int i = 0;
        int j = heights.Length - 1;
        var res = -1;
        while(i < j) {
            var result = (j - i) * Math.Min(heights[i], heights[j]);
            res = Math.Max(result, res);
            if(heights[i] <= heights[j]){
                i++;
            }
            else {
                j--;
            }
        }
        return res;
    }
}
