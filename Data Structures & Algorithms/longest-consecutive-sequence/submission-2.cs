public class Solution {
    public int LongestConsecutive(int[] nums) {
        HashSet<int> numsSet = [..nums];
        HashSet<int> isChecked = [];
        int maxLength = 0;
        foreach (var i in numsSet)
        {
            if (isChecked.Contains(i)) continue;
            isChecked.Add(i);
            int currentLength = 1;
            int j = i - 1;
            while (numsSet.Contains(j))
            {
                numsSet.Remove(j);
                currentLength++;
                isChecked.Add(j);
                j--;
            }
            j = i + 1;
            while (numsSet.Contains(j))
            {
                numsSet.Remove(j);
                currentLength++;
                isChecked.Add(j);
                j++;
            }
            maxLength = Math.Max(maxLength, currentLength);
        }
        return maxLength;
    }
}
