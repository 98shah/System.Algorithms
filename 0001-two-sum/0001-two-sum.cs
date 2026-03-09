public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> indexMap = [];
        for (int i=0; i<nums.Length; i++){
            int diff = target - nums[i];
            if(indexMap.ContainsKey(diff)){
                return [indexMap[diff], i];
            }
            indexMap[nums[i]] = i;
        }
        return null;
    }
}