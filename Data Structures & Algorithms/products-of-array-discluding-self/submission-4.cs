public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int m = 1, temp = 1;
        int[] result = new int[nums.Length];
        result[0] = result[result.Length - 1] = 1;
        for (int i = 1; i < nums.Length; i++)
        {
            result[i] = result[i - 1] * nums[i - 1];
        }
        for (int i = nums.Length - 2; i >= 0; i--)
        {
            temp *= nums[i + 1];
            result[i] *= temp;
        }
        return result;
    }
}
