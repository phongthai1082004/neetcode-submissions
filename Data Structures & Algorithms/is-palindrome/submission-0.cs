public class Solution {
    public bool IsPalindrome(string s) {
        if (s.Length == 0 || s.Length == 1) {
            return true;
        }
        string news = new string(s.Where(char.IsLetterOrDigit).ToArray()).ToLower();
        int length = news.Length;

        for (int i = 0; i < length / 2; i++) {
            if (news[i] != news[length - 1 - i]) {
                return false;
            }
        }
        return true;
    }
}
