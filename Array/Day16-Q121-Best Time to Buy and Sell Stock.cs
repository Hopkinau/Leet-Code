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

// 1. Initialize `buy` to the first element of the `prices` array: `buy = 7`.
// 2. Initialize `profit` to 0.
// 3. Start iterating through the array from the second element (`i = 1`).

//    - At `i = 1`, `buy` (7) is not greater than `prices[1]` (1), so we calculate the potential profit: `prices[1] - buy = 1 - 7 = -6`. Since the profit is negative, we don't update `profit`.
//    - At `i = 2`, `buy` (7) is less than `prices[2]` (5), so we update `buy` to 5, and set `prices[2]` to 0 to mark it as a purchase.
//    - At `i = 3`, `buy` (5) is not greater than `prices[3]` (3), so we calculate the potential profit: `prices[3] - buy = 3 - 5 = -2`. Since the profit is negative, we don't update `profit`.
//    - At `i = 4`, `buy` (5) is less than `prices[4]` (6), so we calculate the potential profit: `prices[4] - buy = 6 - 5 = 1`. We update `profit` to 1 because it's the maximum profit seen so far.
//    - At `i = 5`, `buy` (5) is less than `prices[5]` (4), so we calculate the potential profit: `prices[5] - buy = 4 - 5 = -1`. Since the profit is negative, we don't update `profit`.

// 4. After the loop finishes, the `profit` variable holds the maximum profit, which is 1.

// So, for the input `prices = [7,1,5,3,6,4]`, the `MaxProfit` function returns a maximum profit of 1, which means the best strategy is to buy at a price of 5 and sell at a price of 6 to achieve a profit of 1.