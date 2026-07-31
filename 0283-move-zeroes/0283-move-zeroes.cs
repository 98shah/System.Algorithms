public class Solution {
    public void MoveZeroes(int[] nums) {
        int n = nums.Length;
        int zp=0;
        for(int i=0; i < n; i++){
            if(nums[i] != 0){
                (nums[zp], nums[i]) = (nums[i], nums[zp]);
                zp++;
            }
        }
    }
}