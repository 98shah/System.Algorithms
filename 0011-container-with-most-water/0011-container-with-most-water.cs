public class Solution {
    public int MaxArea(int[] height) {
        int n = height.Length; 
        int left = 0;
        int right = n - 1;

        int max_volume = 0;
        
        while(left < right){
            int l = right - left;
            int h = Math.Min(height[left], height[right]);
            int volume = h * l;

            max_volume = Math.Max(volume, max_volume);
            
            if(height[left] < height[right]){
                left++;
            } else{
                right--;
            }
        }
        return max_volume;
        
    }
}