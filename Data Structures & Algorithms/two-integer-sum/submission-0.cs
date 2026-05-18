public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, List<int>> freq = new();
        for (int i = 0; i < nums.Length; i++)
        {
            if (freq.TryGetValue(nums[i], out var _))
            {
                freq[nums[i]].Add(i);
            }
            else freq[nums[i]] = [i];
        }
        for (int i = 0; i < nums.Length; i++)
        {
            if (target - nums[i] == nums[i])
            {
                if (freq[nums[i]].Count > 1)
                {
                    return [freq[nums[i]][0], freq[nums[i]][1]];
                }
            }
            else
            {
                if (freq.TryGetValue(target - nums[i], out var list))
                {
                    return [freq[nums[i]][0], list[0]];
                }
            }
        }
        return [];
    }
}
