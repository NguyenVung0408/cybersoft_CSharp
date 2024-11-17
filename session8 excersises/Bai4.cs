using System.Collections.Generic;
using System.Linq;

namespace BaiTap
{
    public class Bai4
    {
        public static IList<int> TopKFrequent(int[] nums, int k)
        {
            Dictionary<int, int> count = new Dictionary<int, int>();
            foreach (var num in nums)
            {
                if (count.ContainsKey(num))
                    count[num]++;
                else
                    count[num] = 1;
            }

            return count.OrderByDescending(x => x.Value)
                        .Take(k)
                        .Select(x => x.Key)
                        .ToList();
        }
    }
}
