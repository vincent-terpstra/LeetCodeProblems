using Xunit;

namespace LeetCodeProblems;

public class LongestConsecutiveSln
{
    /*
     * Given an unsorted array of integers nums, return the length of the longest consecutive elements sequence.

        You must write an algorithm that runs in O(n) time.

         

        Example 1:

        Input: nums = [100,4,200,1,3,2]
        Output: 4
        Explanation: The longest consecutive elements sequence is [1, 2, 3, 4]. Therefore its length is 4.

        Example 2:

        Input: nums = [0,3,7,2,5,8,4,6,0,1]
        Output: 9

         

        Constraints:

            0 <= nums.length <= 105
            -109 <= nums[i] <= 109
     */

    [Fact]
    public void Example1()
    {
        int[] input = { 100,4,200,1,3,2};
        Assert.Equal(4, LongestConsecutive(input));
    }
    
    [Fact]
    public void Example2()
    {
        int[] input = { 0,3,7,2,5,8,4,6,0,1};
        Assert.Equal(9, LongestConsecutive(input));
    }
    
    
    public int LongestConsecutive(int[] nums)
    {
        HashSet<int> set = new HashSet<int>();
        foreach (int i in nums)
        {
            set.Add(i);
        }

        int max = 0;
        foreach (int i in set)
        {
            if (!set.Contains(i - 1))
            {
                int currentMax = 1;
                int current = i;
                while (set.Contains(++current))
                {
                    currentMax++;
                }

                max = Math.Max(max, currentMax);
            }
        }
        
        return max;
    }
}