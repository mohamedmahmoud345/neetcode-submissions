public class Solution {
    public int EvalRPN(string[] tokens) {
        var stack = new Stack<int>();

        foreach (var token in tokens) {
            if (IsOperator(token)) {
                int right = stack.Pop();
                int left = stack.Pop();
                stack.Push(Calc(left, right, token));
            } else {
                stack.Push(int.Parse(token));
            }
        }

        return stack.Pop();
    }

    private bool IsOperator(string token) {
        return token == "+" || token == "-" || token == "*" || token == "/";
    }

    private int Calc(int left, int right, string op) {
        return op switch {
            "+" => left + right,
            "-" => left - right,
            "*" => left * right,
            "/" => left / right,
            _ => throw new InvalidOperationException("Unknown operator")
        };
    }
}
