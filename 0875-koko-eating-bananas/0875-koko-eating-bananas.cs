public class Solution {
    public int MinEatingSpeed(int[] piles, int h) {
        int left = 1;
        int right = piles.Max();
        int bestSpeed = right;

        while(left <= right){
            int mid = left + (right - left) / 2;
            long time = 0;

            foreach(var p in piles){
                time += (p + mid - 1) / mid;
            }

            if(time <= h){
                bestSpeed = Math.Min(bestSpeed, mid);
                right = mid - 1;
            } else{
                left = mid + 1;
            }
        }
        return bestSpeed;
    }
}