public class Solution {
    public bool hasDuplicate(int[] nums) {
        // Array.Sort uses highly optimized primitives under the hood
        System.Array.Sort(nums);

        for (int i = 0; i < nums.Length - 1; i++) {
            // Because it's sorted, any duplicate must be right next to each other
            if (nums[i] == nums[i + 1]) {
                return true;
            }
        }

        return false;
    }
}
