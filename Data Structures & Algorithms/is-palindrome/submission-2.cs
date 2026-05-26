public class Solution {
    public bool IsPalindrome(string s) {
        for (int i = 0, j = s.Length - 1; i < j; i++, j--)
        {
            while (i < j && !IsAlphaNumeric(s[i]))
            {
                i++;
            }
            while (i < j && !IsAlphaNumeric(s[j]))
            {
                j--;
            }
            if (i >= j) return true;
            if ((s[i] > 96 ? s[i] - 32 : s[i] - 0) != (s[j] > 96 ? s[j] - 32 : s[j] - 0)) return false;
        }
        return true;
    }
    
    private bool IsAlphaNumeric(char c)
    {
        if ((c >= 'A' && c <= 'z') || (c >= '0' && c <= '9')) return true;
        return false;
    }
}
