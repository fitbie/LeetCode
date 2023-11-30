Solution solution = new();
solution.ThreeSum(new int[] { -1,0,1,2,-1,-4 });


public class Solution {
    public IList<IList<int>> ThreeSum(int[] nums) 
    {
        List<IList<int>> result = new();

        if (nums.Length == 3)
        {
            if ((nums[0] + nums[1] + nums[2]) != 0) { return result; }
            else { result.Add(nums); return result; }
        }

        Array.Sort(nums);

        for (int i = 0; i < nums.Length; i++)
        {
            int left = i + 1;
            int right = nums.Length - 1;

            while (left < right)
            {
                if (nums[left] + nums[right] + nums[i] > 0) { right--; }
                else if (nums[left] + nums[right] + nums[i] < 0) { left++; }
                else 
                {
                    var temp = new List<int> {nums[i], nums[left], nums[right]};
                    if (!Seen(temp)) { result.Add(temp); }
                    left++;
                }
            }
        }

        return result;
        

        bool Seen(List<int> value)
        {
            for (int i = 0; i < result.Count; i++)
            {
                if (result[i][0] == value[0] && result[i][1] == value[1] && result[i][2] == value[2])
                {
                    return true;
                }
            }
            return false;
        }
    }
    
}