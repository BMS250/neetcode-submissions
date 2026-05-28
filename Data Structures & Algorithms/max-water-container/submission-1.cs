public class Solution {
    public int MaxArea(int[] heights) {
        int maxArea = 0;
        for (int i = 0, j = heights.Length - 1; i < j;)
        {
            maxArea = Math.Max(maxArea, Math.Min(heights[i], heights[j]) * (j - i));
            if (heights[i] < heights[j]) i++;
            else j--;
        }
        return maxArea;
    }
}
