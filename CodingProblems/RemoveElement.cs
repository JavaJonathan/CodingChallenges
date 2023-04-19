using System;
using System.Collections.Generic;
using System.Text;

namespace CodingProblems
{
    class RemoveElement
    {
        public int RemoveElement(int[] nums, int val)
        {
            var itemCount = 0;
            for (var counter = 0; counter < nums.Length; counter++)
            {
                if (nums[counter] != val)
                {
                    nums[itemCount] = nums[counter];
                    itemCount++;
                }
            }

            return itemCount;
        }
    }
}
