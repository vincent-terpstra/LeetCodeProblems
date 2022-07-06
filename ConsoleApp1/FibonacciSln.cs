using System.Runtime.InteropServices;
using Xunit;

namespace LeetCodeProblems;

public class FibonacciSln
{
    [Theory]
    [InlineData(0,0)]
    [InlineData(1, 1)]
    [InlineData(2,1)]
    [InlineData(3,2)]
    [InlineData(4,3)]
    [InlineData(5,5)]
    [InlineData(6,8)]
    public void ExampleTheory(int input, int output)
    {
        Assert.Equal(output, Fib(input));
    }


    public int Fib(int n) {
        if(n < 2)
            return n;
        
        int last = 1;
        int current = 1;
        
        for(int i = 0; i < n - 2; i++)
        {
            int next = last + current;
            last = current;
            current = next;


        }

        return current;
    }
}