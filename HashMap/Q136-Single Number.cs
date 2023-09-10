public class Solution {
    public int SingleNumber(int[] nums) {
        return new HashSet<int>(nums).ToArray().Sum() * 2 - nums.Sum();
    }
}


Let's use the provided nums array, which is [2, 2, 1], as an example to understand how the SingleNumber method works with this input:

new HashSet<int>(nums): This creates a HashSet from the input array, removing duplicates. In this case, it becomes {2, 1}.

.ToArray(): Converts the HashSet back to an array. The order might not be preserved, so it could be either [2, 1] or [1, 2].

.Sum(): Calculates the sum of all elements in the array. If the order is [2, 1], then the sum is 2 + 1 = 3. If the order is [1, 2], the sum is still 2 + 1 = 3. The order doesn't matter because addition is commutative.

* 2: Multiplies the sum by 2. In both cases, it's 3 * 2 = 6.

- nums.Sum(): Subtracts the sum of all elements in the original input array nums. The sum of [2, 2, 1] is 2 + 2 + 1 = 5.

Now, let's compute the final result:

If the order of the HashSet's elements is [2, 1], then 6 - 5 = 1.
If the order is [1, 2], then 6 - 5 = 1.
In either case, the result is 1, which is the single number that occurs only once in the nums array [2, 2, 1].

So, when you call SingleNumber([2, 2, 1]), it will return 1.