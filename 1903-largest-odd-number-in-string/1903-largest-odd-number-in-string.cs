public class Solution {
    public string LargestOddNumber(string num) {
        int n = num.Length;
        for(int i=n-1; i>=0;i--){
            int lastNum = (num[i] - '0');
            if(lastNum % 2 != 0){
                return num.Substring(0, i+1);
            }
        }
        return "";
    }
}