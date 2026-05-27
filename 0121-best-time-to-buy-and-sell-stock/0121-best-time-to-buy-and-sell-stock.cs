public class Solution {
    public int MaxProfit(int[] nums) {
        int left=0; int right=1; int maxProfit=0;
        while(right < nums.Length){
            if(nums[right] > nums[left]){
                int profit = nums[right] - nums[left];
                maxProfit = Math.Max(profit, maxProfit);
            } else{
                left = right;
            }
            right++;
        }
        return maxProfit;
    }
}