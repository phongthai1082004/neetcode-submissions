public class Solution {
    public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length) {
            return false;
        }

        var KeyValue = new Dictionary<char, int>();

        foreach (char c in s) {
            if (!KeyValue.ContainsKey(c)) {
                KeyValue.Add(c, 1);
            } else {
                KeyValue[c]++;
            }
        }

        Console.Write(KeyValue);

        foreach (char c in t) {
            if (KeyValue.ContainsKey(c)) {
                if (KeyValue[c] == 0) {
                    return false;
                } else {
                    KeyValue[c]--;
                }
            } else {
                return false;
            }
        }
        return true;
    }
}
