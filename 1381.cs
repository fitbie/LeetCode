public class CustomStack
{
    public int Count { get; private set; }
    private int[] data;
    private int top = -1;


    public CustomStack(int maxSize) 
    {
        data = new int[maxSize];
    }
    
    public void Push(int x)
    {
        if (Count + 1 > data.Length) return;

        data[++top] = x;
        Count++;
    }
    
    public int Pop()
    {
        if (Count == 0) return -1;
        
        Count--;
        return data[top--];
    }
    
    public void Increment(int k, int val)
    {
        for (int i = 0; i <= k && i < data.Length; i++)
        {
            data[i] += val;
        }    
    }
}