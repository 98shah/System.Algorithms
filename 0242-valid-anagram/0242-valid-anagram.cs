public class Solution {
    public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length) return false;

        Dictionary<char, int> refMap = [];
        for(int i=0; i<s.Length; i++){
            refMap[s[i]] = refMap.GetValueOrDefault(s[i]) + 1;
            refMap[t[i]] = refMap.GetValueOrDefault(t[i]) - 1;
        }

        foreach (var key in refMap){
            if (key.Value != 0) return false;
        }

        return true;
    }
}