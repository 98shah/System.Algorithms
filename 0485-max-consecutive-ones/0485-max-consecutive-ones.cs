public class Solution {
    public int FindMaxConsecutiveOnes(int[] nums) {
        int n = nums.Length;
        int max_count = 0;
        int count = 0;
        for(int i=0; i<n; i++){
            if(nums[i] == 1){
                count++;
                max_count = Math.Max(count, max_count);
            } else {
                count = 0;
            }
        }
        return max_count;
    }
}