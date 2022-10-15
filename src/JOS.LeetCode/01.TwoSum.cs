using System;
using System.Collections;
using System.Collections.Generic;

namespace JOS.LeetCode;

public class TwoSum
{
    public int[] Execute(int[] nums, int target)
    {
        if (nums.Length == 2)
        {
            return new[] {0, 1};
        }

        var map = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++)
        {
            var current = nums[i];
            var rest = target - current;
            if (map.ContainsKey(rest))
            {
                return new[] {map[rest], i};
            }

            map[current] = i;
        }

        return Array.Empty<int>();
    }
}