using Xunit;

namespace LeetCodeProblems;

public class PlusOneSln
{
    /*
     * Example 1:

        Input: digits = [1,2,3]
        Output: [1,2,4]
        Explanation: The array represents the integer 123.
        Incrementing by one gives 123 + 1 = 124.
        Thus, the result should be [1,2,4].

        Example 2:

        Input: digits = [4,3,2,1]
        Output: [4,3,2,2]
        Explanation: The array represents the integer 4321.
        Incrementing by one gives 4321 + 1 = 4322.
        Thus, the result should be [4,3,2,2].

        Example 3:

        Input: digits = [9]
        Output: [1,0]
        Explanation: The array represents the integer 9.
        Incrementing by one gives 9 + 1 = 10.
        Thus, the result should be [1,0].

     */
    [Fact]
    public void Example1()
    {
        int[] inputs = {1, 2, 3};
        int[] outputs = {1, 2, 4};
        
       Assert.Equal(outputs, PlusOne(inputs)); 
    }
    [Fact]
    public void Example2()
    {
        int[] inputs = {4,3,2,1};
        int[] outputs = {4,3,2,2};
        
        Assert.Equal(outputs, PlusOne(inputs)); 
    }
    [Fact]
    public void Example3()
    {
        int[] inputs = {9,9};
        int[] outputs = {1,0,0};
        
        Assert.Equal(outputs, PlusOne(inputs)); 
    }
    
    public int[] PlusOne(int[] digits)
    {
        for (int i = digits.Length - 1; i >= 0; i--)
        {
            int at = digits[i];
            if (at == 9)
            {
                digits[i] = 0;

                if (i == 0)
                {
                    digits[0] = 1;
                    var list = digits.ToList();
                    list.Add(0);
                    return list.ToArray();
                }
            }
            else
            {
                digits[i] += 1;
                break;
            }
        }

        return digits;
    }
    
}