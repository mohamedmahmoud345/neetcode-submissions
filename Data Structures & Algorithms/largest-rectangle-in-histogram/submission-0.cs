public class Solution {
    public int LargestRectangleArea(int[] heights) {
        var res = new List<int>();

        for (var i = 0; i < heights.Length; i++)
        {
            List<int> area = new List<int>();
            int count = 0;
            for (var j = 0; j < heights.Length; j++)
            {
                if (heights[j] >= heights[i])
                {
                    count++;
                    area.Add(count);
                }
                else
                {
                    area.Add(count);
                    count = 0;
                }

            }
            res.Add(area.Max() * heights[i]);
        }
        return res.Max();
    }
}
