public class Solution {
    public int[][] KClosest(int[][] points, int k) {
        var minHeap = new PriorityQueue<int[], int>();

        foreach(var point in points){
            var val = point[0] * point[0] + point[1] * point[1];
            minHeap.Enqueue(point, val);
        }

        var res = new int[k][];
        for (var i = 0; i < k; i++) {
            res[i] = minHeap.Dequeue();
        }

        return res;
    }
}
