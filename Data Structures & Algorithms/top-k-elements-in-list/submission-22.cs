public class Solution {
    public int[] TopKFrequent(int[] nums, int k)
{
    Dictionary<int, int> freq = [];
    int maxFreq = 0;
    foreach (int num in nums)
    {
        freq.TryGetValue(num, out int count);
        freq[num] = count + 1;
        maxFreq = freq[num] > maxFreq ? freq[num] : maxFreq;
    }

    List<int>[] buckets = new List<int>[maxFreq + 1];
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
        // foreach (int num in buckets[i])
        for (int j = 0; j < buckets[i].Count; j++)
        {
            result[idx++] = buckets[i][j];
            if (idx == k) break;
        }
    }
    return result;
}
}
