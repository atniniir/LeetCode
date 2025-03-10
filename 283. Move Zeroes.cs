/*
283. Move Zeroes

Given an integer array nums, move all 0's to the end of it while maintaining the relative order of the non-zero elements.
*/

public class Solution {
    public void MoveZeroes(int[] nums) {
        int[] res = new int[nums.Length];

            int NotZeroNum = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != 0)
                {
                    nums[NotZeroNum++] = nums[i];
                }
            }

            for (int i = NotZeroNum; i < nums.Length; i++)
                nums[i] = 0;
    }
}