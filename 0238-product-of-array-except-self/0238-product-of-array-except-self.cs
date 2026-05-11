public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int[] r= new int[nums.Length];
        r[0]=1;
        for(int i=1;i<nums.Length;i++){
            r[i] = r[i-1]*nums[i-1];
        }
        int rp=1;
        for(int j=nums.Length-1;j>=0;j--){
            r[j] *=rp;
            rp *=nums[j];
        }
        return r;
    }
} 