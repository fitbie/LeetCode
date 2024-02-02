Solution solution = new();
solution.SequentialDigits(10, 1000000000);

public class Solution {
    public IList<int> SequentialDigits(int low, int high) 
    {
        IList<int> result = new List<int>();

        (int lowDigid, int lowTens) = GetTensAndFirstDigid(low);
        int next = IsFirstDigidValid(lowDigid, lowTens) ? low : GetNextValue(lowDigid, lowTens);
        
        while (next <= high && next > 0) // 0 bc of int specific
        {
            (int firstDigid, int tens) = GetTensAndFirstDigid(next);

            next = GetNextValue(firstDigid, tens);
            
            // Main logic, using saved tens and digids increase previous digid
            // and miltuply by power of decreasing tens.
            int current = 0;
            int prevDigid = firstDigid;
            while (tens >= 0)
            {
                current += prevDigid++ * (int)Math.Pow(10, tens);
                tens--;
            }
            
            if (current <= high && current >= low) { result.Add(current); }
        }


        // Get number of tens (basically zeros after first digid) and first digid itself.
        (int, int) GetTensAndFirstDigid(int value)
        {
            int firstDigid = value;
            int tens = 0;
            while (firstDigid >= 10) // Get first digid and save number of tens, except first ten (1 or 2 or etc).
            {
                firstDigid /= 10;
                tens++;
            }

            return (firstDigid, tens);
        }

        // Last digid before we meet 10, e.g. 789, 6789, 56789
        bool IsFirstDigidValid(int digid, int tens)
        {
            return digid <= 10 - (tens + 1); // +1 bc tens is number of digids after first digid.
        }


        // Next value to operate with. If next digid is valid - use it. If not - increase number of tens,
        // e.g. 10 => 100, 100 => 1000.
        int GetNextValue(int firstDigid, int tens)
        {
            int nextValue = 0;
            if (IsFirstDigidValid(firstDigid + 1, tens))
            {
                nextValue = (firstDigid + 1) * (int)Math.Pow(10, tens); 
            }
            else
            {
                nextValue = (int)Math.Pow(10, tens + 1);
            }

            return nextValue;
        }


        return result;    
    }
}