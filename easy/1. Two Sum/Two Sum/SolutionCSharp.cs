using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Two_Sum
{
    public class Solution
    {
        public int[] TwoSum(int[] nums, int target)
        {
            int foundkolvo = nums.Length;
            int[] result = new int[2];
            int sum = 0;
            for (int i = 0; i < foundkolvo - 1; i++)
            {
                if (i + 1 < foundkolvo)
                {
                    sum = nums[i] + nums[i + 1];
                    if (sum == target)
                    {
                        result[0] = i;
                        result[1] = i + 1;
                    }
                }
            }
            return result;
        }
    }
}
