using System.Collections;
using Xunit;

namespace LeetCodeProblems;

public class IsInterleaveSln
{
    /*
     * Given strings s1, s2, and s3, find whether s3 is formed by an interleaving of s1 and s2.

        An interleaving of two strings s and t is a configuration where they are divided into non-empty substrings such that:

            s = s1 + s2 + ... + sn
            t = t1 + t2 + ... + tm
            |n - m| <= 1
            The interleaving is s1 + t1 + s2 + t2 + s3 + t3 + ... or t1 + s1 + t2 + s2 + t3 + s3 + ...

        Note: a + b is the concatenation of strings a and b.

         

        Example 1:

        Input: s1 = "aabcc", s2 = "dbbca", s3 = "aadbbcbcac"
        Output: true

        Example 2:

        Input: s1 = "aabcc", s2 = "dbbca", s3 = "aadbbbaccc"
        Output: false

        Example 3:

        Input: s1 = "", s2 = "", s3 = ""
        Output: true

         

        Constraints:

            0 <= s1.length, s2.length <= 100
            0 <= s3.length <= 200
            s1, s2, and s3 consist of lowercase English letters.
     */
    [Fact]
    public void Example1()
    {
        string s1 = "aabcc", s2 = "dbbca", s3 = "aadbbcbcac";
        Assert.True(IsInterleave(s1,s2,s3));
    }
    
    [Fact]
    public void Example2()
    {
        string  s1 = "aabcc", s2 = "dbbca", s3 = "aadbbbaccc";
        Assert.False(IsInterleave(s1,s2,s3));
    }

    [Fact]
    public void Example3()
    {
        string s1 =
            "abababababababababababababababababababababababababababababababababababababababababababababababababbb";
        string s2 =
            "babababababababababababababababababababababababababababababababababababababababababababababababaaaba";
        string s3 = 
            "abababababababababababababababababababababababababababababababababababababababababababababababababababababababababababababababababababababababababababababababababababababababababababababababababababbb";
        
        Assert.False(IsInterleave(s1,s2,s3));
    }

    [Fact]
    public void Example4()
    {
        Assert.True(IsInterleave("","",""));
    }

    public bool IsInterleave(string s1, string s2, string s3)
    {
        if (s1.Length + s2.Length != s3.Length)
            return false;
        
        bool[] dp = new bool[s2.Length + 1];
        for (int i = 0; i <= s1.Length; i++)
        {
            for (int j = 0; j <= s2.Length; j++)
            {
                if (i == 0 && j == 0)
                {
                    dp[j] = true;
                } else if (i == 0)
                {
                    dp[j] = dp[j - 1] && s2[j - 1] == s3[i + j - 1];
                } else if (j == 0)
                {
                    dp[j] = dp[j] && s1[i - 1] == s3[i + j - 1];
                }
                else
                {
                    dp[j] = (dp[j] && s1[i - 1] == s3[i + j - 1]) || (dp[j - 1] && s2[j - 1] == s3[i + j - 1]);
                }
            }
        }


        return dp[s2.Length];
    }

    public bool IsInterleave(string s1, string s2, string s3, int idx1, int idx2, int idx3)
    {
        if (idx1 == s1.Length && idx2 == s2.Length && idx3 == s3.Length)
            return true;

        if (idx3 == s3.Length)
            return false;

        if (idx1 < s1.Length && s1[idx1] == s3[idx3])
        {
            if (IsInterleave(s1, s2, s3, idx1 + 1, idx2, idx3 + 1))
                return true;
        }
        if (idx2 < s2.Length && s2[idx2] == s3[idx3])
        {
            if (IsInterleave(s1, s2, s3, idx1, idx2 + 1, idx3 + 1))
                return true;
        }
        
        return false;
    }
}