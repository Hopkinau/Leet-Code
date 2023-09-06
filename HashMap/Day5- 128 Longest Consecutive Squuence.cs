public class Solution {
    public int LongestConsecutive(int[] nums) {
        // If the array has less than 2 elements, return its length
        if (nums.Length < 2) return nums.Length;

        // Create a HashSet to store the unique numbers in the input array
        var set = new HashSet<int>(nums);

        // Initialize a variable to store the length of the longest consecutive subsequence
        var longest = 0;

        // Iterate through each number in the HashSet
        foreach (var n in set) {
            // Check if the current number is the start of a sequence
            if (!set.Contains(n - 1)) {
                var length = 0;

                // Continue checking the next consecutive numbers
                while (set.Contains(n + length)) {
                    length++;
                    // Update the longest length if the current sequence is longer
                    longest = Math.Max(longest, length);
                }
            }
        }

        // Return the length of the longest consecutive subsequence
        return longest;
    }
}
