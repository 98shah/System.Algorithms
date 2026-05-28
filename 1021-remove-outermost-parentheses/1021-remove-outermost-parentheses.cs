public class Solution {
    public string RemoveOuterParentheses(string s) {
        string output = "";
        int count = 0;

        foreach(var c in s){
            if(c == '('){
                count++;
                if (count > 1) output += c;
            } else{
                if(count > 1) output += c;
                count--;
            }
        }
        return output;
    }
}