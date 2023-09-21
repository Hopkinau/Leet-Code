//https://www.youtube.com/watch?v=wvpd_FvSNzo

public class Solution {
    public IList<string> SummaryRanges(int[] nums) {
        List<string> list = new List<string>(); 
        for (int i = 0; i < nums.Length; i++) {
            int num = nums[i];
            while (i + 1 < nums.Length && nums[i + 1] == nums[i] + 1) {
                i++;
            }
            if (num != nums[i]) {
                list.Add(num + "->" + nums[i]);
            } else {
                list.Add(num + "");
            }
        }
      
        return list;
    }
}
