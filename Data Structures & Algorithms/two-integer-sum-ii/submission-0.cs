public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        for (int i = 0; i < numbers.Length - 1; i++)
        {
            int result = BinarySearch(numbers, i, target - numbers[i]);
            if (result != -1) return [i + 1, result];
        }
        return [];
    }

    public int BinarySearch(int[] numbers, int firstIndex, int target)
    {
        int s = 0, e = numbers.Length - 1, m;
        while(s <= e)
        {
            m = (s + e) / 2;
            if (numbers[m] == target)
            {
                if (m != firstIndex) return m + 1;
                else if (m > 0 && numbers[m - 1] == target) return m;
                else return m + 2;
            }
            if (numbers[m] > target) e = m - 1;
            else s = m + 1;
        }
        return -1;
    }
}
