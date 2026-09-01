public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        var numberFreq = new Dictionary<int, int>();
        foreach (int num in nums) {
            if (!numberFreq.ContainsKey(num)) {
                numberFreq.Add(num, 1);
            } else {
                numberFreq[num]++;
            }
        }

        var list = new List<KeyValuePair<int, int>>(numberFreq);
        list.Sort((x, y) => y.Value.CompareTo(x.Value));

        int[] array = new int[k];
        for (int i = 0; i < k; i++) {
            array[i] = list[i].Key;
        }
        return array;
    }
}
