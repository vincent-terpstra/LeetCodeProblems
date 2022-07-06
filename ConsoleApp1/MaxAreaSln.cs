using Xunit;

namespace LeetCodeProblems;

public class MaxAreaSln
{
    
    /*
     * Input: h = 5, w = 4, horizontalCuts = [1,2,4], verticalCuts = [1,3]
     * Output: 4 
     */
    [Fact]
    public void Example1()
    {
        Assert.Equal(4, MaxArea(5,4,new []{1,2,4},new []{1,3}));
        
        
    }
    /*
     * Input: h = 5, w = 4, horizontalCuts = [3,1], verticalCuts = [1]
     * Output: 6
     * 
     */
    [Fact]
    public void Example2()
    {
        Assert.Equal(6, MaxArea(5,4,new []{3,1},new []{1}));
    }
    
    /*
     * Input: h = 5, w = 4, horizontalCuts = [3], verticalCuts = [3]
     * Output: 9
     */
    [Fact]
    public void Example3()
    {
        Assert.Equal(9, MaxArea(5,4,new []{3},new []{1}));
    }
    
    /*
     * Input: h =  1000000000, w = 1000000000, horizontalCuts = [2], verticalCuts = [2]
     * Output: 9
     */
    [Fact]
    public void Example4()
    {
        Assert.Equal(81, MaxArea(1000000000,1000000000,new []{2},new []{2}));
    }

    public static int MODULE = 1000000007;
    
    public int MaxArea(int h, int w, int[] horizontalCuts, int[] verticalCuts)
    {
        Array.Sort(horizontalCuts);
        Array.Sort(verticalCuts);
        
        long maxh = FindMax(h, horizontalCuts);
        long maxw = FindMax(w, verticalCuts);
        
        
        return (int)((maxh * maxw) % MODULE);
    }

    private int FindMax(int full, int[] cuts)
    {
        if (cuts.Length == 0)
            return full;
        
        int max = Math.Max(cuts[0], full - cuts[cuts.Length - 1]);
        if (cuts.Length == 1)
            return max;

        for (int i = 1; i < cuts.Length; i++)
        {
            max = Math.Max(max, cuts[i] - cuts[i - 1]);
        }
        
        
        return max;
    }
}