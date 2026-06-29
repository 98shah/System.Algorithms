public class Solution {
    public int RemoveDuplicates(int[] nums) {
        int n = nums.Length;
        if(n == 1) return n;

        int i = 0;
        int j = 1;
        while(j < n){
            if(nums[i] != nums[j]){
                i++;
                nums[i] = nums[j];
            }
            j++;
        }
        return i + 1;
    }
}