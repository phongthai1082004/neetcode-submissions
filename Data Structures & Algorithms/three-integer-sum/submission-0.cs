public class Solution {
    public List<List<int>> ThreeSum(int[] nums) {
        List<List<int>> sums = new List<List<int>>();
        Array.Sort(nums); 

        for (int i = 0; i < nums.Length - 2; i++) {
            if (i > 0 && nums[i] == nums[i - 1]) continue;

            int start = i + 1;
            int end = nums.Length - 1;
            int target = -nums[i];

            while (start < end) {
                int sum = nums[start] + nums[end];

                if (sum == target) {
                    sums.Add(new List<int>() { nums[i], nums[start], nums[end] });

                    while (start < end && nums[start] == nums[start + 1]) start++;
                    while (start < end && nums[end] == nums[end - 1]) end--;

                    start++;
                    end--;
                } 
                else if (sum < target) {
                    start++;
                } 
                else {
                    end--;
                }
            }
        }
        return sums;
    }
}