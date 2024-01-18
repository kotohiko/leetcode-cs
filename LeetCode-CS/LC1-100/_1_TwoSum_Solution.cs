using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_CS.LC1_100
{
    internal class _1_TwoSum_Solution
    {
        public int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> dic = new Dictionary<int, int>();
            int n = nums.Length;
            for (int i = 0; i < n; ++i)
            {
                int b = target - nums[i];
                if (dic.ContainsKey(b) && dic[b] != i)
                {
                    return new int[] { i, dic[b] };
                }
                if (!dic.ContainsKey(nums[i]))
                {
                    dic.Add(nums[i], i);
                }
            }
            return new int[] { 0, 0 };
        }
    }
}
