public class Solution {
    public void Merge(int[] nums1, int m, int[] nums2, int n) {
         int i = m - 1, j = n - 1;
    int p = nums1.Length - 1;
    
    while (i >= 0 && j >= 0) {
        if (nums1[i] > nums2[j]) {
            nums1[p] = nums1[i];
            i--;
        } else {
            nums1[p] = nums2[j];
            j--;
        }
        p--;
    }
    
    while (j >= 0) {
        nums1[p] = nums2[j];
        j--;
        p--;
    }
    }
}