public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        var keyValue = new Dictionary<string, List<String>>();
        char[] bits = new char[26];

        foreach (string str in strs) {
            Array.Fill(bits, '0');
            var countChar = new Dictionary<char, int>();

            foreach (char c in str) {
                if (countChar.ContainsKey(c)) {
                    countChar[c]++;
                } else {
                    countChar.Add(c, 0);
                }
            }

            foreach (char key in countChar.Keys) {
                bits[key - 'a'] = (char)countChar[key];
            }

            string encodedString = new string(bits);
            if (!keyValue.ContainsKey(encodedString)) {
                keyValue.Add(encodedString, new List<string>() { str });
            } else {
                keyValue[encodedString].Add(str);
            }
        }
        return keyValue.Values.ToList();
    }
}
