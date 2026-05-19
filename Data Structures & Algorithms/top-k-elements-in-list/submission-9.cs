public class Solution {
    public int[] TopKFrequent(int[] nums, int k)
{
    Dictionary<int, int> freq = [];
    int maxFreq = 0;
    foreach (int num in nums)
    {
        freq.TryGetValue(num, out int count);
        freq[num] = count + 1;
        if (freq[num] > maxFreq) maxFreq = freq[num];
    }

    // // Cap at distinct count, not nums.Length
    // foreach (int count in freq.Values)
    //     if (count > maxFreq) maxFreq = count;

    List<int>[] buckets = new List<int>[maxFreq + 1]; // much smaller!
    foreach (var (num, count) in freq)
    {
        buckets[count] ??= [];
        buckets[count].Add(num);
    }

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
