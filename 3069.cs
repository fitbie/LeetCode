public class Solution {
    public int[] ResultArray(int[] nums)
    {
        int[] l = new int[nums.Length];
        int lPointer = 1;
        int[] r = new int[nums.Length];
        int rPointer = 1;

        int i = 0;
        l[0] = nums[i];
        i++;
        r[0] = nums[i];
        i++;

        for (; i < nums.Length; i++)
        {
            if (r[rPointer - 1] > l[lPointer - 1])
            {
                r[rPointer] = nums[i];
                rPointer++;
            }
            else
            {
                l[lPointer] = nums[i];
                lPointer++;
            }
        }

        int[] result = new int[nums.Length];
        Array.Copy(l, result, lPointer);
        Array.Copy(r, 0, result, lPointer, rPointer);

        return result;
    }
}