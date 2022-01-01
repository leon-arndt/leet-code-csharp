public class Solution {
    public bool IsPalindrome(int input) {
        var asString = input.ToString();
        for(var i = 0; i < asString.Length / 2; i++) {
            if (asString[i] != asString[asString.Length - i - 1]) {
                return false;
            }
        }
        return true;
    }
}