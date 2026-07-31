public class Solution {
    public int RemoveDuplicates(int[] nums) {
        int pin = 0;
        for(int i=1; i<nums.Length; i++){
            if(nums[pin] != nums[i]){
                pin++;
                nums[pin] = nums[i];
            }
        }
        return pin+1;
    }
}