public class Solution {
    public bool hasDuplicate(int[] nums) 
    {
        HashSet<int> notDubs = [];

        for (int i = 0; i < nums.Length; i++)
        {
            if (notDubs.Contains(nums[i]))
                return true;
            notDubs.Add(nums[i]);
        }

        return false;
    }
}