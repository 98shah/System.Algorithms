public class Solution {
    public void ReverseArray(int[] arr, int left, int right){
        while(left < right){
            int temp = arr[left];
            arr[left] = arr[right];
            arr[right] = temp;

            left++;
            right--;
        }
    }
    public void Rotate(int[] nums, int k) {
        int n = nums.Length;
        k = k % n;
        if (k == 0) return;
        ReverseArray(nums, 0, n-1);
        ReverseArray(nums, 0, k-1);
        ReverseArray(nums, k, n-1);
    }
}