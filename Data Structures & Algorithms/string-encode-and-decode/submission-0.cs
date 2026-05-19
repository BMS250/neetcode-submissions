public class Solution {

    public string Encode(IList<string> strs) {
        var result = new StringBuilder();
        foreach (var str in strs)
        {
            result.Append($"{str.Length}#{str}");
        }
        return result.ToString();
    }

    public List<string> Decode(string s) {
        List<string> strs = [];
        bool currentlyCounting = false;
        for (int i = 0; i < s.Length; i++)
        {
            if (int.TryParse(s[i].ToString(), out int num))
            {
                while (int.TryParse(s[++i].ToString(), out int value))
                {
                    num = num * 10 + value;
                }
                if (s[i] == '#')
                {
                    strs.Add(s[(i+1)..(i+1+num)]);
                    i += num;
                }
            }
        }
        return strs;
   }
}
