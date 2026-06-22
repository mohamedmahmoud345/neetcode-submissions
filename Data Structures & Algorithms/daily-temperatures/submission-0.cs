public class Solution {
    public int[] DailyTemperatures(int[] temperatures) {
        var res = new int[temperatures.Length];
        var stack = new Stack<int[]>();

        for(var i = 0; i < temperatures.Length; i++){
            int t = temperatures[i];
            while(stack.Count > 0 && t > stack.Peek()[0]){
                int[] pair = stack.Pop();
                res[pair[1]] = i - pair[1];
            }
            stack.Push(new int[] {t , i});
        }
        return res;
    }
}
