public class Solution {
    public IList<IList<string>> GroupAnagrams(string[] strs) {
       Dictionary<string, List<string>> groups = [];

       foreach (string s in strs){
        int[] count = new int[26];

        foreach (char c in s){
            count[c - 'a']++;
        }

        string key = string.Join(",", count);

        if (!groups.ContainsKey(key)){
            groups.Add(key, []);
        }
        groups[key].Add(s);
       } 

       return [.. groups.Values];
    }
}