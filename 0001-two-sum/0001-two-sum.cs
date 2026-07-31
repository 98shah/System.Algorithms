public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        int n = nums.Length;
        Dictionary<int, int> map = [];
        for(int i=0; i<n; i++){
            int diff = target - nums[i];
            if(map.ContainsKey(diff)){
                return [i, map[diff]];
            }
            map[nums[i]] = i;
        }
        return [-1, -1];
    }
}