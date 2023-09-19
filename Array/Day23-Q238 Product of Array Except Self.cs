//https://www.youtube.com/watch?v=bNvIQI2wAjk
use prefix and suffix to solve this problem

example: input [1,2,3,4]
output [24,12,8,6]

public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int prefix = 1, postfix = 1;
        int[] res = new int[nums.Length];        
        
        for(int i = 0; i < nums.Length; i++){
            res[i] = prefix;
            prefix =prefix* nums[i];             
        }
        
        for(int i = nums.Length-1; i>=0; i--){
            res[i] =res[i]* postfix;
            postfix =postfix* nums[i];          
        }
        return res;
    }
}

1.res [ ] in prefix loop, res = [1,1,2,6]
input [1,2,3,4]
when i = 0; res[0] = 1; prefix = 1*1 = 1
when i = 1; res[1] = 1; prefix = 1*2 = 2
when i = 2; res[2] = 2; prefix = 2*3 = 6
when i = 3; res[3] = 6; prefix = 6*4 = 24

2.res [1,1,2,6 ] in postfix loop, res = [24,12,8,6]
when i =3 ; res[3] = 6; because postfix = 1; res[3] = 6*1 = 6
when i =2 ; res[2] = 8; postfix = 4, res[2] = 2*4 = 8;
when i =1 ; res[1] = 1; postfix = 12, res[1] = 1*12 = 12;
when i =0 ; res[0] = 1; postfix = 24, res[0] = 1*24 = 24;

The final answer is [24,12,8,6]