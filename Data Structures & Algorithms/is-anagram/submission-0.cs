public class Solution {
    public bool IsAnagram(string s, string t)
    {
        Dictionary<char, int> sChars = new();
        Dictionary<char, int> tChars = new();
        if (s.Length != t.Length) return false;
        for (int i = 0; i < s.Length; i++)
        {
            if (!sChars.TryGetValue(s[i], out var freq))
            {
                sChars[s[i]] = 1;
            }
            else
            {
                sChars[s[i]]++;
            }
        }
        for (int i = 0; i < t.Length; i++)
        {
            if (!tChars.TryGetValue(t[i], out var freq))
            {
                tChars[t[i]] = 1;
            }
            else
            {
                tChars[t[i]]++;
            }
        }
        foreach (var c in sChars)
        {
            if (!tChars.TryGetValue(c.Key, out var freq) || c.Value != freq) return false;
        }
        return true;
    }
}
