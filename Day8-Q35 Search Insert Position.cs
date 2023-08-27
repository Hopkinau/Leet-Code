//https://www.youtube.com/watch?v=0A40XJH_VvE

public class Solution {
    public int SearchInsert(int[] nums, int target) {
        return LeftBound(nums, target);
    }

    // Left bound binary search algorithm
    private int LeftBound(int[] nums, int target) {
        if(nums.Length==0){
            return -1;
        };
        int left = 0;
        int right = nums.Length;
        while (left <right){
            int mid = left +(right-left)/2;
            if(nums[mid]==target){
                return mid;
            }
            else if (nums[mid]<target){
                left = mid +1;
            }
            else {
                right = mid -1;
            }
        }
        return left;

        
    }
}

