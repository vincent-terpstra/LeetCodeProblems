﻿using System.Diagnostics;
using Xunit;

namespace LeetCodeProblems;

public class StrStrProblem
{
    //[Fact]
    public void StrStrChecks()
    {
        int result = StrStr("a", "a");
        Assert.Equal(0, result);
    }
    
    public int StrStr(string haystack, string needle) {
        if(needle.Length == 0)
            return 0;
        
        for(int i = 0; i <= (haystack.Length - needle.Length); i++){
            
            int j = 0;
            while(j < needle.Length && haystack[i + j] == needle[j])
            {
                j++;
            }
            
            if(j == needle.Length)
                return i;
        }
        return -1;
    }
}