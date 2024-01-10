Solution solution = new();
solution.MinEatingSpeed(new int[] { 3,6,7,11 }, 18);


public class Solution 
{
    public int MinEatingSpeed(int[] piles, int h)
    {
        int left = 0;
        int rigtht = piles.Max();
        int result = rigtht;

        while (left <= rigtht && rigtht + left > 0)
        {
            int middle = left + (rigtht - left) / 2;
            if (middle == 0) { break; }
            int counter = 0;

            foreach (var pile in piles)
            {
                counter += (int)Math.Ceiling((double)pile / middle);
            }

            if (counter > h)
            {
                left = middle + 1;
            }
            else
            {
                result = middle;
                rigtht = middle - 1;
            }
        }

        return result;
    }
}
