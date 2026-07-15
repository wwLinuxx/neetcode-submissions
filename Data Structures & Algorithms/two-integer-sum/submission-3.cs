public class Solution 
{
    // [3, 4, 5, 6] == 7
    // 7 - 3 = 4
    // 7 - 4 = 3
    // 7 - 5 = 2
    // 7 - 6 = 1
    public int[] TwoSum(int[] nums, int target) 
    {
        Dictionary<int, int> map = [];

        for (int i = 0; i < nums.Length; i++)
        {
            int temp = target - nums[i];

            if (map.TryGetValue(temp, out int idx))
                return [idx, i];
            else 
                map[nums[i]] = i;
        }

        return [];
    }
}
