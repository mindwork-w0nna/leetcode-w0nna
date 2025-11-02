using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Two_Sum
{
    public class Solution
    {
        public int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();

            int[] result = new int[2];
            for(int i=0; i < nums.Length; i++)
            {
                
                if (dict.ContainsKey(target - nums[i]))
                {
                    result[0] = dict[target - nums[i]];
                    result[1] = i;
                    return result;
                }
                dict.Add(nums[i], i);
            }
            throw new Exception("No valid pair");            
        }
    }
}
