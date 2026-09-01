public class Solution {
    public string Encode(IList<string> strs) {
        var message = new StringBuilder();

        foreach (string str in strs) {
            message.Append(str.Length + "#" + str);
        }
        return message.ToString();
    }

    public List<string> Decode(string s) {
        var list = new List<string>();
        int length = s.Length;
        int i = 0;

        while (i < length) {
            int delimiterIndex = s.IndexOf('#', i);
            int len = int.Parse(s.Substring(i, delimiterIndex - i));
            i = delimiterIndex + 1;
            list.Add(s.Substring(i, len));
            i += len;
        }
        return list;
    }
}