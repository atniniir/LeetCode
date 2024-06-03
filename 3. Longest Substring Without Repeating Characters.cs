/*
3. Longest Substring Without Repeating Characters

Given a string s, find the length of the longest
substring without repeating characters.
*/

using System;
using System.Collections.Generic;

namespace leetcode
{
    public class Solution
    {
		public int LengthOfLongestSubstring(string s)
        {
            int leftBorder = 0, rightBorder = 0, maxCounter = 0;

            HashSet<char> set = new HashSet<char>();

            while (rightBorder < s.Length)
            {
                if (!set.Contains(s[rightBorder])) {
                    set.Add(s[rightBorder]);
                    if (maxCounter < set.Count) maxCounter = set.Count;
                    rightBorder++;
                }
                else
                {
                    set.Remove(s[leftBorder]);
                    leftBorder++;
                }
            }
            return maxCounter;
        }
	}
}