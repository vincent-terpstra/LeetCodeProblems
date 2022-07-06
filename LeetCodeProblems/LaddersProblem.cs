

using System.Collections;

namespace LeetCodeProblems;

public class LaddersProblem
{
    /*
    public static void Main()
    {
        //heights = , bricks = 10, ladders = 2
        int[] heights = new int[]{4,12,2,7,3,18,20,3,19};
        int bricks = 10;
        int ladders = 2;

        var problem = new LaddersProblem();
        int far = problem.FurthestBuilding(heights, bricks, ladders);
        int test2 = problem.FurthestBuilding(new int[] {14, 3, 19, 3}, 17, 0);
    }
    */

    public int FurthestBuilding(int[] heights, int bricks, int ladders)
    {
        int far = 1;
        //PriorityQueue<int,int> queue = new();

        /*while (far < heights.Length)
        {
            int dist = heights[far] - heights[far - 1];
            if (dist > 0)
            {
                queue.Add(dist, dist);
                if (queue.Count > ladders)
                {
                    bricks -= queue.Dequeue();
                    if (bricks < 0)
                    {
                        return far - 1;
                    }

                    queue.Add(dist, dist);
                }
            }

            far++;
        }*/
        
        return far - 1;
    }
}