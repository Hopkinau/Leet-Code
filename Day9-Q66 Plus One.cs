//https://www.youtube.com/watch?v=P3K_hKNU2ME

//They are two possibility, normal [1,3,4] or all 9 [ 9,9]
//the all 9 output need to add extra element in arr, 
//input:[9,9]   
//output: [1,0,0]

//So, there are two return 
//1.return digits, if its normal arr ,such as [1,3,4]
//2. all 9 arr. return newDigits


public class Solution {
    public int[] PlusOne(int[] digits) {
        for (int i = digits.Length - 1; i >= 0; i--)
        {
            if (digits[i] != 9)
            {
                digits[i] = digits[i] + 1;
                return digits;
            }
            else
            {
                digits[i] = 0;
            }
        }
        
        int[] newDigits = new int[digits.Length + 1];
        newDigits[0] = 1;
        
        return newDigits;
    }
}