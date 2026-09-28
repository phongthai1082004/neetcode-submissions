public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        int end = numbers.Length - 1;
        int start = 0;
        while (start != end) {
            if (numbers[start] + numbers[end] > target) {
                end--;
            } else if (numbers[start] + numbers[end] < target) {
                start++;
            } else {
                return [start + 1, end + 1];
            }
        }
        return [0, 0];
    }
}
