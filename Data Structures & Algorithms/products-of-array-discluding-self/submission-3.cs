public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int m1 = 1, allMult = nums[0] == 0 ? 1 : nums[0];
        HashSet<int> zeros = [];
        if (nums[0] == 0) zeros.Add(0);
        for (int i = 1; i < nums.Length; i++)
        {
            m1 *= nums[i];
            if (nums[i] == 0) zeros.Add(i);
            else allMult *= nums[i];
        }
        int[] result = new int[nums.Length];
        result[0] = m1;
        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] != 0)
                result[i] = result[i - 1] * nums[i - 1] / nums[i];
            else
            {
                if (zeros.Count > 1) result[i] = 0;
                else result[i] = allMult;
            }
        }
        return result;
    }
}
