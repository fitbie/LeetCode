Solution solution = new();
solution.LargestDivisibleSubset(new int[] { 22,1,74,51,18,38,9,44,88,12 });


public class Solution {
    public IList<int> LargestDivisibleSubset(int[] nums) 
    {
        IList<int> result = new List<int>();
        List<int> tempResult = new();

        Dictionary<int, List<int>> dividers = new();

        Array.Sort(nums);
        for (int i = 0; i < nums.Length; i++)
        {
            FindDividers(i - 1, nums[i]);
            tempResult.Add(nums[i]);
            FindDivisible(i + 1, nums[i]);

            result = result.Count < tempResult.Count ? new List<int>(tempResult) : result;

            tempResult.Clear();
            // CountDivisible(i, i + 1);
        }

        void FindDividers(int from, int divisible)
        {
            int div = divisible;

            for (int j = from; j >= 0; j--)
            {
                if (divisible % nums[j] == 0)
                {
                    tempResult.Add(nums[j]);
                    divisible = nums[j];
                    if (dividers.ContainsKey(nums[j]))
                    {
                        tempResult.AddRange(dividers[nums[j]]);
                        break;
                    }
                }
            }

            if (!dividers.ContainsKey(div)) 
            { 
                dividers.Add(div, new List<int>(tempResult));
            }

        }

        void FindDivisible(int start, int divider)
        {
            for (int i = start; i < nums.Length; i++)
            {
                if (nums[i] % divider == 0)
                {
                    tempResult.Add(nums[i]);
                    divider = nums[i];
                }
            }
        }

        // void CountDivisible(int prev, int next)
        // {
        //     if (LastOne(next)) { return; }

        //     while (nums[next] % nums[prev] != 0) 
        //     { 
        //         next++;
        //         if (LastOne(next)) { return; }
        //     }
            
        //     tempResult.Add(nums[next]);
            
        //     CountDivisible(next, next + 1);

        //     bool LastOne(int val)
        //     {
        //         if (val >= nums.Length)
        //         {
        //             result = result.Count > tempResult.Count ? result : new List<int>(tempResult);
        //             tempResult.Clear();
        //             return true;
        //         }

        //         return false;
        //     }
        // }


        return result;    
    }
}