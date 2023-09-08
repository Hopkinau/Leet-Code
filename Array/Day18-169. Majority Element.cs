
//majorityElement([2, 2, 1, 1, 1, 2, 2]);

public class solution{
public int MajorityElement(int[] nums) {
 int target = 0;
 //hashmap key 
 int count =0;
 //hashmap value

for (int i =0;i<nums.length;i++){
    if(count==0){
        target = nums[i];
        count =1;
    }else if(nums[i]=target)
    {
         count ++;
    }else{
        count --;
    }
}
//1. when i = 0; nums[i]=2; target = 2; count = 1;
//2. when i = 1; nums[i]=2; target = 2; count = 2;
//3. when i = 2; nums[i]=1; target = 2; count = 1;, because count --;
//4. when i = 3; nums[i]=1; target = 2; count = 0;, because count --;
//5. when i = 4; nums[i]=1; target = 1; count = 1;, because when count =0; target become nums[i]; count++;
//6. when i = 5; nums[i]=2; target = 1; count = 0;, because count --;
//7. when i = 6; nums[i]=2; target = 2; count = 1;, because when count =0; target become nums[i]; count++;
//final steps return target 2


 return target;


}

}