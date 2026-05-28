using System.Text;
public class Solution {
    public string RemoveOuterParentheses(string s) {
        var output = new StringBuilder();
        int count = 0;

        foreach(var c in s){
            if(c == '('){
                count++;
                if (count > 1) output.Append(c);
            } else{
                if(count > 1) output.Append(c);
                count--;
            }
        }
        return output.ToString();
    }
}