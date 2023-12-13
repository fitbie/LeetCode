Solution solution = new();
solution.EvalRPN(new string[] { "4","13","5","/","+" });


public class Solution 
{
    public int EvalRPN(string[] tokens)
    {
        Stack<int> nums = new();
        
        for (int i = 0; i < tokens.Length; i++)
        {
            int temp = 0; // We cash last variable for second operand
            switch (tokens[i])
            {
                case "+":
                temp = nums.Pop();
                nums.Push(nums.Pop() + temp);
                break;

                case "-":
                temp = nums.Pop();
                nums.Push(nums.Pop() - temp);
                break;

                case "*":
                temp = nums.Pop();
                nums.Push(nums.Pop() * temp);
                break;

                case "/":
                temp = nums.Pop();
                nums.Push(nums.Pop() / temp);
                break;

                default:
                nums.Push(int.Parse(tokens[i]));
                break;
            }
        }

        return nums.Pop();
    }
}