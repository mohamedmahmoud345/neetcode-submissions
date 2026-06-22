public class Solution {
    public int[] DailyTemperatures(int[] temperatures) {
        var result = new int[temperatures.Length];
        var stack = new Stack<int[]>();

        for(var i = 0; i < temperatures.Length; i++){
            var temp = temperatures[i];
            while(stack.Count > 0 && stack.Peek()[0] < temp) {
                var pair  =stack.Pop();
                result[pair[1]] = i - pair[1];
            }
            stack.Push(new int[] {temp, i});
        }

        return result;
    }
}
