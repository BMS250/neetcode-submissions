public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        List<List<string>> result = [];
        for (int i = 0; i < strs.Length; i++)
        {
            if (result.Count == 0) 
            {
                result.Add([strs[i]]);
                continue;
            }
            int j = 0;
            for (; j < result.Count; j++)
            {
                if (AreAnagrams(strs[i], result[j][0]))
                {
                    result[j].Add(strs[i]);
                    break;
                }
            }
            if (j == result.Count)
                result.Add([strs[i]]);
        }
        return result;
    }

    public bool AreAnagrams(string a, string b)
    {
        if (a.Length != b.Length) return false;
        Dictionary<char, int> aFreq = [];
        Dictionary<char, int> bFreq = [];
        foreach (var c in a)
        {
            if (aFreq.TryGetValue(c, out var value)) aFreq[c]++;
            else aFreq[c] = 1;
        }
        foreach (var c in b)
        {
            if (bFreq.TryGetValue(c, out var value)) bFreq[c]++;
            else bFreq[c] = 1;
        }
        foreach (var freq in aFreq)
        {
            if (!bFreq.TryGetValue(freq.Key, out var value) || freq.Value != value) return false;
        }
        return true;
    }
}
