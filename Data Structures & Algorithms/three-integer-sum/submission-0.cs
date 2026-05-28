public class Solution {
    public List<List<int>> ThreeSum(int[] nums) {
        List<List<int>> result = [];
        Array.Sort(nums);
        for (int i = 0; i < nums.Length; i++)
        {
            if (i > 0 && nums[i] == nums[i - 1]) continue;
            for (int j = i + 1, k = nums.Length - 1; j < k;)
            {
                var sum = nums[i] + nums[j] + nums[k];
                if (sum == 0)
                {
                    result.Add([nums[i], nums[j], nums[k]]);
                    j++;
                    while (nums[j] == nums[j - 1] && j < k) j++;
                    continue;
                }
                if (sum > 0)
                {
                    k--;
                    while (nums[k] == nums[k + 1] && j < k) k--;
                }
                else
                {
                    j++;
                    while (nums[j] == nums[j - 1] && j < k) j++;
                }
            }
        }
        return result;
    }
}
