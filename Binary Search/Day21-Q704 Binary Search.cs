//nums = [-1,0,3,5,9,12], target = 9
public class Solution {
    public int Search(int[] nums, int target) {
        int left = 0;
        int right = nums.Length - 1;

        while (left <= right) {
            int middle = (right + left) / 2;

            if (nums[middle] == target) {
                return middle;
            }

            if (nums[middle] < target) {
                left = middle + 1;
            } else {
                right = middle - 1;
            }
        }

        return -1;
    }
}

[2, 4, 6, 8, 10, 12, 14, 16, 18, 20]
And our target element is 12, which we want to find using binary search.

Initialization:

left is initially set to 0, which points to the first element (2).
right is initially set to 9, which points to the last element (20).
First Iteration:

Calculate the middle index: middle = (0 + 9) / 2 = 4.
Compare nums[4] (which is 10) with the target 12.
Since 10 is less than 12, we update left to middle + 1, which becomes 5. This means we now search the right half of the array.
Second Iteration:

Calculate the middle index again: middle = (5 + 9) / 2 = 7.
Compare nums[7] (which is 16) with the target 12.
Since 16 is greater than 12, we update right to middle - 1, which becomes 6. This means we now search the left half of the remaining elements.
Third Iteration:

Calculate the middle index again: middle = (5 + 6) / 2 = 5.
Compare nums[5] (which is 12) with the target 12.
We have found the target element 12 at index 5.
Termination:

Since left is still less than or equal to right, we continue with the loop, but middle now points to the target element.
The loop exits because we found the target element, and we return the index 5.
So, in this example, binary search successfully found the target element 12 in the sorted array at index 5. The while (left <= right) condition ensures that the search continues until it finds the target or determines that the target is not in the array.