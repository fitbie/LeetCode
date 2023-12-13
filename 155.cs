// MinStack obj = new MinStack();
// obj.Push(2147483646);
// obj.Push(2147483646);
// obj.Push(2147483647);
// obj.Push(2147483647);
// obj.Push(-2147483648);
// obj.Pop();
// obj.Pop();
// obj.Pop();
// obj.Pop();
// obj.GetMin();



// public class MinStack
// {
//     private int[] values = Array.Empty<int>();
//     private int last = -1;

//     private List<int> minValues = new();
//     private int minValue = int.MaxValue;


//     public MinStack(){}
    

//     public void Push(int val) 
//     {
//         if (last + 1 >= values.Length) 
//         { 
//             int[] temp = new int [values.Length+1];
//             Array.Copy(values, temp, values.Length);
//             values = temp;
//         }

//         values[++last] = val;

//         if (val <= minValue)
//         {
//             minValues.Add(val);
//             minValue = val;
//         }
//     }
    

//     public void Pop() 
//     {
//         if (values[last] == minValues[minValues.Count-1])
//         {
//             minValues.RemoveAt(minValues.Count-1);
//             minValue = minValues[minValues.Count-1];
//         }

//         int[] temp = new int [values.Length-1];
//         Array.Copy(values, temp, values.Length-1);
//         values = temp;
//         last--;
//     }
    

//     public int Peek()
//     {
//         return values[last];
//     }


//     public int Top() 
//     {
//         return values[last];
//     }
    

//     public int GetMin() 
//     {
//         return minValue;
//     }
// }