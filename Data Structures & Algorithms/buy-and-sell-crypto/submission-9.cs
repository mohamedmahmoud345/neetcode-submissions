public class Solution {
    public int MaxProfit(int[] prices) {
        int l = 0;
        int maxProfit = 0;

        for(var r = 1; r < prices.Length; r++){
            while(l < r && prices[l] > prices[r]){
                l++;
            }
            var profit = prices[r] - prices[l];
            maxProfit = Math.Max(maxProfit, profit);
        }
        return maxProfit;
    }
}
