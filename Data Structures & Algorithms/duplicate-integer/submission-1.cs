public class Solution {
    public bool hasDuplicate(int[] nums) {
        var DuplicateList = new HashSet<int>();
        foreach (int i in nums) {
            if (DuplicateList.Contains(i)) {
                return true;
            } else {
                DuplicateList.Add(i);
            }
        }
        return false;
    }
}