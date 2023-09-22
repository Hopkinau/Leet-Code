//https://www.youtube.com/watch?v=KLlXCFG5TnA&t=4s
//https://leetcode.com/problems/two-sum/


//use hashmap to solve this problems
//hashmap key is the value of the array

public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> indices = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++) {
            var diff = target - nums[i];
            if (indices.ContainsKey(diff)) {
                return new int[] {indices[diff], i};
            }
            indices[nums[i]] = i;
        }
        return null;
    }
}

For Example: nums = [ 1,3,9,11], target = 10;
1. i = 0, diff = 10 - 1 = 9, indices does not contain 9, so add 1 to indices, indices = {1:0}
2. i = 1, diff = 10 - 3 = 7, indices does not contain 7, so add 3 to indices, indices = {1:0, 3:1}
3. i = 2, diff = 10 - 9 = 1, indices contains 1, so return [indices[1], 2] = [0,2]
4. i = 3, diff = 10 - 11 = -1, indices does not contain -1, so add 11 to indices, indices = {1:0, 3:1, 11:3}



