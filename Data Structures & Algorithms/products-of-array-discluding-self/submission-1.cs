public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int m1 = 1;
        for (int i = 1; i < nums.Length; i++)
        {
            m1 *= nums[i];
        }
        int[] result = new int[nums.Length];
        result[0] = m1;
        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] != 0)
                result[i] = result[i - 1] * nums[i - 1] / nums[i];
            else
            {
                int mult = 1;
                for (int j = 0; j < nums.Length; j++)
                {
                    if (i == j) continue;
                    mult *= nums[j];
                }
                result[i] = mult;
            }
        }
        return result;
    }
}
