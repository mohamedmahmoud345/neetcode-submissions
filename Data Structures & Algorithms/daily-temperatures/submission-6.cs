public class Solution {
    public int[] DailyTemperatures(int[] temperatures) {
        var stack = new Stack<int>();
        var res = new int[temperatures.Length];
        for(var i = 0; i < temperatures.Length; i++){
            while(stack.Count() >= 1 && temperatures[i] > temperatures[stack.Peek()]){
                res[stack.Peek()] = i - stack.Peek();
                stack.Pop();
            }

            stack.Push(i);
        }

        return res;
    }
}
