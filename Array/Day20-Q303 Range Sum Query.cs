//https://www.youtube.com/watch?v=2pndAmo_sMA


1. First find all the prefix in the array
eg:    [-2,0,3,-5,2,-1]
prefix:[-2,-2,1,-4,-2,-3]

public class NumArray {

    private List<int> sum = new List<int>();

    public NumArray(int[] nums)
    {
        sum.Add(0);
        int acc = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            acc += nums[i];
            sum.Add(acc);
        }
    }

    public int SumRange(int i, int j)
    {
        return sum[j + 1] - sum[i];
    }
}