using System.Text;
Solution solution = new();
solution.MaximumOddBinaryNumber("01010");

public class Solution {
    public string MaximumOddBinaryNumber(string s) {
        StringBuilder builder = new(s);
        int pointer = builder[^1] == '1' ? 0 : builder.Length - 1;

        for (int i = 0; i < builder.Length - 1; i++)
        {
            if (builder[i] == '1')
            {
                (builder[i], builder[pointer]) = (builder[pointer], builder[i]);
                if (pointer == builder.Length - 1) { pointer = 0; }
                else { pointer++; }
            }
        }

        return builder.ToString();
    }
}