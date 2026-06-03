public class Solution {
    public string ReverseWords(string s) {
        s = s.Trim();
        var result = new StringBuilder();
        int i = s.Length - 1;

        while(i >= 0){
            while(i >= 0 && s[i] == ' ') i--;
            if(i < 0) break;
            int end = i;

            while(i >= 0 && s[i] != ' ')i--;
            int start = i + 1;

            if(result.Length > 0) result.Append(' ');
            result.Append(s, start, end - start + 1);
        }  
        return result.ToString(); 
    }
}