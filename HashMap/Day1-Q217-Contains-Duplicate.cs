//https://leetcode.com/problems/contains-duplicate/ 217. Contains Duplicate
//https://www.youtube.com/watch?v=3OamzN90kPg


//This question is use hashset to solve it.
//Time complexity: O(n)
//Space complexity: O(n)

public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        HashSet<int> set = new HashSet<int>();
        
        foreach (int x in nums){
            if (set.Contains(x)) return true;
            set.Add(x);
        }
        return false;
    }
}