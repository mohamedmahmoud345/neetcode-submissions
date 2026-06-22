public class Solution {
    public int MaxArea(int[] heights) {
        var list = new List<int>();
        for(var i = 0 ; i < heights.Length ; i++) {
            for(var j = i + 1; j < heights.Length; j++) {
                if(i == j) continue;
                var min = Math.Min(heights[i] , heights[j]);
                list.Add(min * Math.Abs(i - j));
            }
        }
        return list.Max();
    }
}
