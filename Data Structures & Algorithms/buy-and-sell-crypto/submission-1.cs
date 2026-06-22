public class Solution {
    public int MaxProfit(int[] prices) {
        int left = 0;
        int right = 1;
        int res = 0;

        while(right < prices.Length){
            if(prices[left] < prices[right]){
                int maxProfit  = prices[right] - prices[left];
                res = Math.Max(res , maxProfit);
            }
            else 
                left = right ;
           right++;
        }
        return res;
    }
}
