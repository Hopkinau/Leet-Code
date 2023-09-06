public class Solution {
    public int MaxProfit(int[] prices) {
        if (prices == null || prices.Length == 0)
    {
        return 0;
    }

    int buy = prices[0];
    prices[0] = 0;
    int profit = 0;

    for (int i = 1; i < prices.Length; i++)
    {
        if (buy > prices[i])
        {
            buy = prices[i];
            prices[i] = 0;
        }
        else
        {
            profit = Math.Max(prices[i] - buy, profit);
        }
    }

    return profit;
    }
}