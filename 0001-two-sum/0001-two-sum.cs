public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> idMap = new Dictionary<int, int>();
        for (int i=0; i<nums.Length; i++){
            int diff = target - nums[i];
            if (idMap.ContainsKey(diff)){
                return [idMap[diff], i];
            }
            idMap[nums[i]] = i;
        }
        return null;
    }
}