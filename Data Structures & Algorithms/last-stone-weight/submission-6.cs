public class Solution {
    public int LastStoneWeight(int[] stones) {
        var minHeap = new PriorityQueue<int, int>();
        foreach(var s in stones){
            minHeap.Enqueue(-s, -s);
        }

        while(minHeap.Count > 1){
            var first = minHeap.Dequeue();
            var second = minHeap.Dequeue();

            if(second > first){
                var diff = first - second;
                minHeap.Enqueue(diff, diff);
            }
        }

        minHeap.Enqueue(0, 0);
        return Math.Abs(minHeap.Peek());
    }
}
