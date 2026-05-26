public class Solution {
    public int LongestConsecutive(int[] nums) {
        HashSet<int> numsSet = [..nums];
        int maxLength = 0;
        foreach (var i in numsSet)
        {
            int currentLength = 1;
            int j = i - 1;
            while (numsSet.Contains(j))
            {
                numsSet.Remove(j);
                currentLength++;
                j--;
            }
            j = i + 1;
            while (numsSet.Contains(j))
            {
                numsSet.Remove(j);
                currentLength++;
                j++;
            }
            maxLength = Math.Max(maxLength, currentLength);
        }
        return maxLength;
    }
}
