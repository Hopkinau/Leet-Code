public class Solution {
    public int RemoveDuplicates(int[] nums) {
        if (nums.Length == 0) {
        return 0;
    }
    
    int slow = 0, fast = 0;
    while (fast < nums.Length) {
        if (nums[fast] != nums[slow]) {
            slow++;
            // Maintain nums[0..slow] with no duplicates
            nums[slow] = nums[fast];
        }
        fast++;
    }
    
    // Array length is index + 1
    return slow + 1;
    }
}