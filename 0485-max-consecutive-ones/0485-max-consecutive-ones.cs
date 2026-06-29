using System.Linq;
public class Solution {
    public int FindMaxConsecutiveOnes(int[] nums) {
        int n = nums.Length;
        int i = 0;
        int max_count = 0;
        while(i < n){
            if(nums[i] == 1){
                int count = 0;
                while(nums[i] == 1){
                    count++;
                    i++;
                    if(i == n) break;
                }
                max_count = Math.Max(count, max_count);
            }
            i++;
        }
        return max_count;
    }
}