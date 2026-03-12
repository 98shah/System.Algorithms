public class Solution {
    public int LongestConsecutive(int[] nums) {
        if (nums == null || nums.Length == 0) return 0;
        HashSet<int> numSet = new HashSet<int>(nums);
        int longest_streak = 0;

        foreach(int num in numSet){
            if (!numSet.Contains(num-1)){
                int current_streak = 1;
                int current_num = num;

                while(numSet.Contains(current_num + 1)){
                    current_num++;
                    current_streak++;
                }

                if (current_streak > longest_streak){
                    longest_streak = current_streak;
                }

            }
        }
        return longest_streak;
    }
}