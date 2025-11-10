/**
You are given two strings word1 and word2.
 Merge the strings by adding letters in alternating order,
  starting with word1. If a string is longer than the other, append the additional letters onto the end of the merged string.

Return the merged string
*/

public class Solution {
    public string MergeAlternately(string word1, string word2) {
        string result = "";
        int length = word1.Length > word2.Length ? word1.Length : word2.Length;
        Console.WriteLine(length);
        for (var i = 0; length > i; i++) {
            if (i < word1.Length) {
                result += word1[i];
            }
            if (i < word2.Length) {
                result += word2[i];
            }

        }
        return result;
        
    }
}
