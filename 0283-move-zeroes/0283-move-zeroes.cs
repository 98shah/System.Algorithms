public class Solution {
    public void MoveZeroes(int[] nums) {
        int n = nums.Length;
        int zp = 0;
        for(int i=0; i<n; i++){
            if(nums[i] != 0){
                int temp = nums[zp];
                nums[zp] = nums[i];
                nums[i] = temp;
                zp++;
            }
        }
    }
}