public class Solution {
    public int RemoveDuplicates(int[] nums) {
      int n = nums.Length;
      if(n == 1) return n;

      int pin = 0;
      for(int i=1; i<n; i++){
        if(nums[pin] != nums[i]){
            pin++;
            nums[pin] = nums[i];
        }
      }  
      return pin+1;
    }
}