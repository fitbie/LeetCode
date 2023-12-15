MinStack obj = new MinStack();
obj.Push(2147483646);
obj.Push(2147483646);
obj.Push(2147483647);
obj.Push(2147483647);
obj.Push(-2147483648);
obj.Pop();
obj.Pop();
obj.Pop();
obj.Pop();
obj.GetMin();



public class MinStack
{
    private int[] values = Array.Empty<int>();
    private int last = -1;

    private Stack<int> minValues = new();
    private int minValue = 0;
    private bool minInitialized = false;


    public MinStack(){}
    

    public void Push(int val) 
    {
        if (last + 1 >= values.Length) 
        { 
            int[] temp = new int [values.Length+1];
            Array.Copy(values, temp, values.Length);
            values = temp;
        }

        values[++last] = val;

        if (!minInitialized)
        {
            minValue = val;
            minInitialized = true;
            return;
        }

        if (val <= minValue)
        {
            minValues.Push(minValue);
            minValue = val;
        }
    }
    

    public void Pop() 
    {
        if (values[last] == minValue)
        {
            if (minValues.Count == 0) { minInitialized = false; }
            else { minValue = minValues.Pop(); }
        }

        int[] temp = new int [values.Length-1];
        Array.Copy(values, temp, values.Length-1);
        values = temp;
        last--;
    }
    

    public int Peek()
    {
        return values[last];
    }


    public int Top() 
    {
        return values[last];
    }
    

    public int GetMin() 
    {
        return minValue;
    }
}