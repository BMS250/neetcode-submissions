public class Solution {
    public int[] TopKFrequent(int[] nums, int k)
    {
        Dictionary<int, int> freq = [];
        // Convert it to Dictionary<int, HashSet<int>> and save max freq
        List<HashSet<int>> freqNums = [[]];
        List<int> result = [];
        for (int i = 0; i < nums.Length; i++)
        {
            if (!freq.TryGetValue(nums[i], out var value))
            {
                freq[nums[i]] = 1;
                try
                {
                    freqNums[1].Add(nums[i]);
                }
                catch
                {
                    freqNums.Insert(1, [nums[i]]);
                }
            }
            else
            {
                freqNums[freq[nums[i]]].Remove(nums[i]);
                freq[nums[i]]++;
                try
                {
                    freqNums[freq[nums[i]]].Add(nums[i]);
                }
                catch
                {
                    freqNums.Insert(freq[nums[i]], [nums[i]]);
                }
            }
        }
        int remaining = k;
        for (int i = freqNums.Count - 1; remaining > 0 && i > 0; i--)
        {
            if (freqNums[i] == null) continue;
            List<int> temp = [.. freqNums[i]];
            if (freqNums[i].Count <= remaining)
            {
                result.AddRange(temp);
                remaining -= temp.Count;
            }
            else
            {
                int j = 0;
                for (; j < remaining; j++)
                {
                    result.Add(temp[j]);
                }
                remaining -= j;
            }
        }
        return result.ToArray();
    }
}
