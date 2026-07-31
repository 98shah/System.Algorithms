public class Solution {
    public bool Check(int[] nums) {
        int spikeDrops = 0;
        for(int i=0; i<nums.Length; i++){
            if(nums[i] > nums[(i+1) % nums.Length]){
                spikeDrops++;
            }
            if (spikeDrops > 1) return false;
        }
        return true;
    }
}