public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        HashSet<int> seenNumbers = [];
        for(int i=0; i<nums.Length; i++){
            if(seenNumbers.Contains(nums[i])){
                return true;
            }

            seenNumbers.Add(nums[i]);
        }

        return false;
    }
}