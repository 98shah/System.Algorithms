public class Solution {
    public int LongestConsecutive(int[] nums) {
        if(nums.Length==0)return 0;
        HashSet<int> set = new(nums);
        int longest=0;

        foreach(var n in set){
            if(!set.Contains(n-1)){
                int currentNum = n;
                int currentStreak = 1;
                while(set.Contains(currentNum+1)){
                    currentStreak++;
                    currentNum++;
                }
                longest = Math.Max(currentStreak, longest);
            }
        }
        return longest;
    }
}