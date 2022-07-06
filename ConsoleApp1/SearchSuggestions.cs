using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using LeetCodeProblems;



namespace LeetCodeProblems
{
    public class SearchSuggestions
    {
        /*
        public static void Main()
         {
             var suggestions = new SearchSuggestions();
             var products = new String[]{"mobile","mouse","moneypot","monitor","mousepad"};
             var searchWord = "mouse";
             var output = suggestions.SuggestedProducts(products, searchWord);
         }
         */
        public IList<IList<string>> SuggestedProducts(string[] products, string searchWord)
        {
            string[][] results = new string[searchWord.Length][];
            Array.Sort(products);
            var list = products.AsEnumerable();
            for(int i=0; i < searchWord.Length; i++)
            {
                char at = searchWord[i];
                list = list.Where(p => p[i] == at).ToArray();
                results[i] = list.Take(3).ToArray();
            }

            return results;
        }
        
    }
    
    
}