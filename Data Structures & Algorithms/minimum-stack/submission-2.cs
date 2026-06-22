public class MinStack {
    private Stack<int> _stack;
    private PriorityQueue<int, int> _min;

    public MinStack() {
        _stack = new Stack<int>();
        _min = new();
    }
    
    public void Push(int val) {
        _stack.Push(val);
        _min.Enqueue(val, val);
    }
    
    public void Pop() {
        var val = _stack.Pop();
        _min.Remove(val, out int c, out int t);        
    }
    
    public int Top() {
        return _stack.Peek();
    }
    
    public int GetMin() {
        return _min.Peek();       
    }
}
