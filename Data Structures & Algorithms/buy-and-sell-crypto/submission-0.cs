public class Solution {
    public int MaxProfit(int[] prices) {
        int left = 0;
    int right = 1;
    int maxProf = 0;
    while ( right < prices.Length)
    {
        if (prices[right] > prices[left])
        {
            int profit = prices[right] - prices[left];
            maxProf = Math.Max(maxProf,profit );
        }
        else 
            left = right;
        right++;
    }
    return maxProf;
    }
}
