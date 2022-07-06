using System.Collections;
using Xunit;

namespace LeetCodeProblems;

public class ReconstructQueueSln
{

    [Fact]
    public void Test1()
    { 
        int[][] input =
        {
            new int[]{7, 0}, 
            new int[]{4, 4}, 
            new int[]{7, 1},
            new int[]{5, 0}, 
            new int[]{6, 1}, 
            new int[]{5, 2}
        };
        int[,] output = {{5, 0}, {7, 0}, {5, 2}, {6, 1}, {4, 4}, {7, 1}};
        

        var array = ReconstructQueue(input);
    }

    

    public int[][] ReconstructQueue(int[][] people) {
        
        Array.Sort(people, new Comparison<int[]>((x, y) => x[0] == y[0] ? x[1]-y[1] : y[0] - x[0]));

        List<int[]> queue = new();
        foreach(int[] p in people)
        {
           queue.Insert(p[1], p);
        }

        return queue.ToArray();
    }
}