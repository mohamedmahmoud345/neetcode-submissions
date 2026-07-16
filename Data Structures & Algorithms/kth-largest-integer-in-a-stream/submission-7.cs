public class KthLargest {
    private PriorityQueue<int, int> _minHeap;
    private int _k;
    public KthLargest(int k, int[] nums) {
        _k = k;
        _minHeap = new PriorityQueue<int, int>();
        foreach(var n in nums){
            _minHeap.Enqueue(n, n);
            if(_minHeap.Count > _k){
                _minHeap.Dequeue();
            }
        }
    }
    
    public int Add(int val) {
        _minHeap.Enqueue(val, val);
        if(_minHeap.Count > _k){
            _minHeap.Dequeue();
        }
        return _minHeap.Peek();
    }
}
