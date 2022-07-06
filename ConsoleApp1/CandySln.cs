using System.Diagnostics;
using Xunit;

namespace LeetCodeProblems;

public class CandySln
{
    
    /*
     * There are n children standing in a line. Each child is assigned a rating value given in the integer array ratings.

    You are giving candies to these children subjected to the following requirements:

    Each child must have at least one candy.
    Children with a higher rating get more candies than their neighbors.

    Return the minimum number of candies you need to have to distribute the candies to the children.



    Example 1:

    Input: ratings = [1,0,2]
    Output: 5
    Explanation: You can allocate to the first, second and third child with 2, 1, 2 candies respectively.

    Example 2:

    Input: ratings = [1,2,2]
    Output: 4
    Explanation: You can allocate to the first, second and third child with 1, 2, 1 candies respectively.
    The third child gets 1 candy because it satisfies the above two conditions.

     */

    [Fact]
    public void Example1()
    {
        int[] input = {1, 0, 2};
        Assert.Equal(5, Candy(input));
    }
    
    [Fact]
    public void Example2()
    {
        int[] input = {1, 2, 2};
        Assert.Equal(4, Candy(input));
    }

    [Fact]
    public void Example3()
    {
        int[] input = {2, 1, 0};
        Assert.Equal(6, Candy(input));
    }

    [Fact]
    public void Example4()
    {
        int[] input = {0, 1, 2};
        Assert.Equal(6, Candy(input));
    }
    
    public int Candy(int[] ratings)
    {
        if (ratings.Length <= 1)
            return ratings.Length;
        
        int[] candies = new int[ratings.Length];
        Array.Fill(candies, 1);

        bool hasChanged = true;

        while (hasChanged)
        {
            hasChanged = false;
            for (int i = 0; i < ratings.Length; i++) {
                if (i != ratings.Length - 1 && ratings[i] > ratings[i + 1] && candies[i] <= candies[i + 1]) {
                    candies[i] = candies[i + 1] + 1;
                    hasChanged = true;
                }
                if (i > 0 && ratings[i] > ratings[i - 1] && candies[i] <= candies[i - 1]) {
                    candies[i] = candies[i - 1] + 1;
                    hasChanged = true;
                }
            }
        }
        int count = 0;
        foreach (var i in candies)
        {
            count += i;
        }

        return count;
    }
}