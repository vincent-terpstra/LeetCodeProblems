using System.Linq;
using System.Xml.Schema;

namespace LeetCodeProblems;

public class ScheduleCourseProblem
{
    public class Descending : IComparer<int>
    {
        public int Compare(int x, int y)
        {
            return y.CompareTo(x);
        }
    }
    
    public int ScheduleCourse(int[][] courses) {
        if(courses.Length <= 0)
            return 0;

        var sorted = courses.AsEnumerable().OrderBy(ints => ints[1]);
        
        
        PriorityQueue<int, int> queue = new PriorityQueue<int, int>(new Descending());

        int sum = 0;
        foreach (int[] course in sorted)
        {
            int length = course[0];
            sum += length;
            queue.Enqueue(length, length);

            if (sum > course[1])
            {
                sum -= queue.Dequeue();
            }
        }
        
        return queue.Count;
    }
}