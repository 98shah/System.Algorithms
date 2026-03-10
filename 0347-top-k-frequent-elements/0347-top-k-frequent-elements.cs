public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        var numsFreq = new Dictionary<int, int>();
        foreach (var num in nums){
            numsFreq.TryGetValue(num, out int count);
            numsFreq[num] = count + 1;
        }

        var freqBucket = new List<int>[nums.Length + 1];
        foreach (var (key, val) in numsFreq){
            freqBucket[val] ??= [];
            freqBucket[val].Add(key);
        }

        var topElements = new int[k];
        int kIndex = 0;
        for (int i = freqBucket.Length - 1; i >= 0; i--){
            if (freqBucket[i] != null){
                foreach (int val in freqBucket[i]){
                    topElements[kIndex] = val;
                    kIndex++;

                    if (kIndex == k) return topElements;
                }
            }
        }
        return topElements;

    }
}