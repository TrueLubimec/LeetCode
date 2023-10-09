//// DONE.   НУ ГЕНИЙ ПРОСТО

public class Solution {
    public int SearchInsert(int[] nums, int target) {
        // var find = nums.FirstOrDefault(number => number == target, -1);
           for (int i = 0; i < nums.Length; i++){
            if (nums[i] >= target){
                return i;
            }
        }
        return nums.Length;
    }
}