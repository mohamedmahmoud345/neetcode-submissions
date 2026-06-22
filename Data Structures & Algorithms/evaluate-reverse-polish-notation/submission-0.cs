public class Solution {
    public int EvalRPN(string[] tokens)
    {
        var stack = new Stack<int>();

        foreach (var ch in tokens)
        {
            if (int.TryParse(ch, out int num))
            {
                stack.Push(num);
            }
            else
            {
                int num1 = stack.Pop();
                int num2 = stack.Pop();
                var result = Calc(num1, num2, ch);
                stack.Push(result);
            }
        }
        return stack.Pop();
    }
    private int Calc(int num1, int num2, string token)
    {
        int result = token switch
        {
            "+" => num2 + num1,
            "-" => num2 - num1,
            "*" => num2 * num1,
            "/" => num2 / num1
        };
        return result;
    }
}
