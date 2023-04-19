using System;
using System.Collections.Generic;
using System.Text;

namespace CodingProblems
{
    class SingleNumber
    {
        public int SingleNumber(int[] nums)
        {
            var foundList = new List<int>();

            for (var counter = 0; counter < nums.Length; counter++)
            {
                if (counter == 0) foundList.Add(nums[counter]);
                else if (foundList.Contains(nums[counter])) { foundList.Remove(nums[counter]); }
                else { foundList.Add(nums[counter]); }
            }

            return foundList[0];
        }
    }
}
