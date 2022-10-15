using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JOS.LeetCode;

/// <summary>
/// https://leetcode.com/submissions/detail/822961763/
/// </summary>
public class ZigzagConversion
{
    public string Convert(string s, int numRows)
    {
        if (numRows == 1)
        {
            return s;
        }
        
        var lists = Enumerable.Range(0, numRows).Select(_ => new List<int>()).ToArray();
        var down = true;
        var listIndex = 0;
        for (var i = 0; i < s.Length; i++)
        {
            lists[listIndex].Add(i);

            if (listIndex == lists.Length - 1)
            {
                down = false;
            }

            if (listIndex == 0)
            {
                down = true;
            }

            listIndex = down ? listIndex + 1 : listIndex - 1;
        }
        
        var output = new StringBuilder(s.Length);
        for (var index = 0; index < lists.Length; index++)
        {
            var indexes = lists[index];
            for (var i = 0; i < indexes.Count; i++)
            {
                output.Append(s[indexes[i]]);
            }
        }

        return output.ToString();
    }
}