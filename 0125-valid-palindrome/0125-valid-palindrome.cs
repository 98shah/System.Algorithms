public class Solution {
    public bool IsPalindrome(string s) {
        int begin = 0;
        int end = s.Length - 1;

        while(begin < end){

            if(!char.IsLetterOrDigit(s[begin]))
            {
                begin++;
            }
            else if(!char.IsLetterOrDigit(s[end]))
            {
                end--;
            }
            else
            {
                if (char.ToLower(s[begin]) != char.ToLower(s[end])){
                    return false;
                }
                begin++;
                end--;
            }
        }
        return true;
    }
}