public class Solution {
    public int Search(int[] nums, int target) {
        int n = nums.Length;
        int left = 0;
        int right = n - 1;

        while(left <= right){
            int mid = left + (right - left)/2;
            if(nums[mid] == target) return mid;

            if(nums[mid] > target){
                right = mid - 1;
            } else {
                left = mid + 1;
            }
        }
        return -1;
    }
}