public class Solution {
    public int MaxArea(int[] heights) {
        int res = 0;

        for(var i = 0; i < heights.Length; i++){
            for(var j = i + 1; j < heights.Length; j++){
                var reminder = j - i;

                var minBar = Math.Min(heights[i], heights[j]);

                var multiResult = reminder * minBar;
                res = Math.Max(res, multiResult);
            }
        }

        return res;
    }
}
