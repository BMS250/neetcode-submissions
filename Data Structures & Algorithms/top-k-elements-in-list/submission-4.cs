public class Solution {
    public int[] TopKFrequent(int[] nums, int k)
    {
        // Step 1: Count frequencies
        Dictionary<int, int> freq = [];
        foreach (int num in nums)
        {
            freq.TryGetValue(num, out int count);
            freq[num] = count + 1;
        }

        // Step 2: Bucket sort — index = frequency, value = list of numbers with that frequency
        // Max possible frequency is nums.Length
        List<int>[] buckets = new List<int>[nums.Length + 1];

        foreach (var (num, count) in freq)
        {
            buckets[count] ??= [];
            buckets[count].Add(num);
        }

        // Step 3: Collect top K from highest frequency bucket downward
        int[] result = new int[k];
        int idx = 0;

        for (int i = buckets.Length - 1; i >= 1 && idx < k; i--)
        {
            if (buckets[i] is null) continue;

            foreach (int num in buckets[i])
            {
                result[idx++] = num;
                if (idx == k) break;
            }
        }

        return result;
    }
}
