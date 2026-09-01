public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        var keyValue = new Dictionary<string, List<string>>();

        foreach (string str in strs) {
            char[] charArray = str.ToCharArray();
            Array.Sort(charArray);
            string encodedString = new string(charArray);

            if (!keyValue.ContainsKey(encodedString)) {
                keyValue[encodedString] = new List<string>();
            }

            keyValue[encodedString].Add(str);
        }

        return keyValue.Values.ToList();
    }
}
