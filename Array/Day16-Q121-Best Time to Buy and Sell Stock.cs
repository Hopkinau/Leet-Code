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
// If you input the array `prices = [7,1,5,3,6,4]` into the `MaxProfit` function, it will calculate the maximum profit that can be obtained from buying and selling stocks with these prices. Let's walk through the calculation step by step:

// Initialize buy to the first element of the prices array: buy = 7.

// Initialize profit to 0.

// Start iterating through the array from the second element (i = 1).

// At i = 1, buy (7) is greater than prices[1] (1), so we update buy to 1, and set prices[1] to 0 to mark it as a purchase.
// At i = 2, buy (1) is less than prices[2] (5), so we calculate the potential profit: prices[2] - buy = 5 - 1 = 4. We update profit to 4 because it's the maximum profit seen so far.
// At i = 3, buy (1) is less than prices[3] (3), so we calculate the potential profit: prices[3] - buy = 3 - 1 = 2. We update profit to 4 because it's still the maximum profit seen so far.
// At i = 4, buy (1) is less than prices[4] (6), so we calculate the potential profit: prices[4] - buy = 6 - 1 = 5. We update profit to 5 because it's the maximum profit seen so far.
// At i = 5, buy (1) is less than prices[5] (4), so we calculate the potential profit: prices[5] - buy = 4 - 1 = 3. We update profit to 5 because it's still the maximum profit seen so far.
// After the loop finishes, the profit variable holds the correct maximum profit, which is 5.

// So, for the input prices = [7,1,5,3,6,4], the maximum profit is indeed 5, achieved by buying at a price of 1 and selling at a price of 6.