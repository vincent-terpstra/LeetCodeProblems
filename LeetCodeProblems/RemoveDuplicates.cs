namespace LeetCodeProblems;

public class LowestNums
{   /*
    public static void Main()
    {
        var lowestNums = new LowestNums();
        
        int r = lowestNums.RemoveDuplicates(new int[] {1, 1, 2});
        int r2 = lowestNums.RemoveDuplicates(new int[] {0, 0, 1, 1, 1, 2, 2, 3, 3, 4});
    }
   */ 
    public int RemoveDuplicates(int[] nums) {
        int low = 0;
        
        for(int idx = 1; idx < nums.Length; idx++){
            if(nums[idx] != nums[low])
                nums[++low ] = nums[idx];
        }
        
        return low + 1;
    }
}