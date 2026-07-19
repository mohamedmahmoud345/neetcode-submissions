public class Solution {
    public int FindKthLargest(int[] nums, int k) {
        var heap = new PriorityQueue<int, int>();

        for(var i = 0; i < nums.Length; i++){
            heap.Enqueue(-nums[i], -nums[i]);
        }

        var res = 0;
        while(k > 0){
            res = heap.Dequeue();
            k--;
        }

        return res * -1;
    }
}
