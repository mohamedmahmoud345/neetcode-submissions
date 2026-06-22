public class Solution {
    public int LargestRectangleArea(int[] heights) {
       int n = heights.Length;
       int maxArea = 0;
       var stack = new Stack<int>();

       for(var i = 0; i <= n; i++){
        while(stack.Count > 0 && 
        (i == n || heights[stack.Peek()] >= heights[i])){
            var height = heights[stack.Pop()];
            int width = stack.Count == 0 ? i : i- stack.Peek() - 1;
            maxArea = Math.Max(maxArea, height * width);
        }
        stack.Push(i);
       } 
       return maxArea;
    }
}
