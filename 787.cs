Solution solution = new();
// solution.FindCheapestPrice(10, new int[][] { new int[] { 3,4,4 }, new int[] { 2,5,6 }, new int[] { 4,7,10 }, new int[] { 9,6,5 }, new int[] { 7,4,4 }, new int[] { 6,2,10 }, new int[] {  6,8,6 }, new int[] {7,9,4}, new int[] { 1,5,4 }, new int[] {1,0,4}, new int[] {9,7,3 }, new int[] {7,0,5}, new int[] {6,5,8}, new int[] {4,0,9}, new int[] {5,9,1}, new int[] {8,7,3}, new int[] {1,2,6}, new int[] {4,1,5}, new int[] {5,2,4}, new int[] {1,9,1}, new int[] {7,8,10}, new int[] {0,4,2}, new int[] {7,2,8}   }, 6, 0, 7);
// solution.FindCheapestPrice(3, new int[][] { new int[] { 0,1,100 }, new int[] { 1,2,100 }, new int[] { 0,2,500 } }, 0, 2, 1);
// solution.FindCheapestPrice(4, new int[][] { new int[] { 0,1,1 }, new int[] { 0, 2, 5 }, new int[] { 1, 2, 1 }, new int[] { 2,3,1 } }, 0, 3, 1);
solution.FindCheapestPrice(5, new int[][] { new int[] {0,1,100},new int[] {0,2,100 },new int[] {0,3,10 },new int[] {1,2,100},new int[] {1,4,10},new int[] {2,1,10},new int[] {2,3,100},new int[] {2,4,100},new int[] {3,2,10},new int[] {3,4,100} }, 0, 4, 3);
// solution.FindCheapestPrice(11, new int[][] { new int[] {0,3,3},new int[] {3,4,3},new int[] {4,1,3},new int[] {0,5,1},new int[] {5,1,100},new int[] {0,6,2},new int[] {6,1,100},new int[] {0,7,1},new int[] {7,8,1},new int[] {8,9,1},new int[] {9,1,1},new int[] {1,10,1},new int[] {10,2,1},new int[] {1,2,100} }, 0, 2, 4);


public class Solution 
{
    public int FindCheapestPrice(int n, int[][] flights, int src, int dst, int k) 
    {
        int result = -1;

        int[,] paths = new int[n,n];
        for (int i = 0; i < flights.Length; i++)
        {
            paths[flights[i][0], flights[i][1]] = flights[i][2];
        }

        int[] visited = new int[n];
        for (int i = 0; i < n; i++)
        {
            visited[i] = int.MaxValue;
        }

        Queue<(int flight, int price, int time)> values = new();
        values.Enqueue((src, 0, 0));

        while (values.Count > 0)
        {
            (int current, int price, int time) = values.Dequeue();
            visited[current] = price;

            for (int i = 0; i < n; i++)
            {
                if (i == dst && paths[current,i] != 0 && current != dst && time <= k)
                {
                    result = result == -1 || result > price + paths[current, i] ? price + paths[current, i] : result;      
                }
                if (paths[current, i] != 0 && price + paths[current, i] < visited[i])
                {
                    values.Enqueue((i, price + paths[current, i], time + 1));
                }
            }
        }

        return result;
    }

}




// public class Solution 
// {
//     public int FindCheapestPrice(int n, int[][] flights, int src, int dst, int k) 
//     {
//         int result = -1;

//         int[,] paths = new int[n,n];
//         for (int i = 0; i < flights.Length; i++)
//         {
//             paths[flights[i][0], flights[i][1]] = flights[i][2];
//         }

//         bool[] visited = new bool[n];

//         PriorityQueue<(int flight, int price), int> values = new();
//         values.Enqueue((src, 0), 0);

//         while (values.Count > 0)
//         {
//             values.TryDequeue(out var currentElement, out int time);
//             (int current, int price) = currentElement;
//             visited[current] = true;

//             for (int i = 0; i < n; i++)
//             {
//                 if (i == dst && paths[current,i] != 0 && current != dst && time <= k)
//                 {
//                     result = result == -1 || result > price + paths[current, i] ? price + paths[current, i] : result;      
//                 }
//                 if (paths[current, i] != 0 && !visited[i])
//                 {
//                     values.Enqueue((i, price + paths[current, i]), time + 1);
//                 }
//             }
//         }

//         return result;
//     }

// }


// public class Solution {
//     public int FindCheapestPrice(int n, int[][] flights, int src, int dst, int k) 
//     {
//         int result = -1;

//         

//         bool[] visited = new bool[n];

//         int[] distances = new int[n];
//         for (int i = 0; i < n; i++)
//         {
//             distances[i] = int.MaxValue;
//         }
//         int[] steps = new int[n];

//         DFS(src, -2, 0);

//         void DFS(int src, int step, int price)
//         {
//             step++;
//             if (step > k) { return; }
//             if (distances[src] > price) { distances[src] = price; }
//             if (src == dst) { return; }

//             visited[src] = true;
//             steps[src] = step;

//             for (int i = 0; i < n; i++)
//             {
//                 if (paths[src, i] != 0)
//                 {
//                     if (visited[i])
//                     {
//                         if (distances[i] < (paths[src,i] + distances[src]) && steps[i] < step)
//                         {
//                             continue;
//                         }
//                     }

//                     DFS(i, step, price + paths[src, i]);
//                 }
//             }
//         }

//         return distances[dst] == int.MaxValue ? -1 : distances[dst];
//     }

// }


// public class Solution {
//     public int FindCheapestPrice(int n, int[][] flights, int src, int dst, int k) 
//     {
//         int[,] paths = new int[n,n];
//         for (int i = 0; i < flights.Length; i++)
//         {
//             paths[flights[i][0], flights[i][1]] = flights[i][2];
//         }

//         bool[] visited = new bool[n];
//         int[] steps = new int[n];

//         int[] distances = new int[n];
//         for (int i = 0; i < n; i++)
//         {
//             distances[i] = int.MaxValue;
//         }
//         distances[src] = 0;
//         steps[src] = -1;

//         for (int i = 0; i < n; i++)
//         {
//             int current = GetMinDistanceIndex();
//             visited[current] = true;

//             for (int j = 0; j < n; j++)
//             {
//                 if (!visited[j] && paths[current,j] != 0 && distances[current] != int.MaxValue)
//                 {
//                     if (distances[current] + paths[current,j] < distances[j] && steps[current] + 1 <= k)
//                     {
//                         distances[j] = distances[current] + paths[current,j];
//                         steps[j] = steps[current] + 1;
//                     }
//                 }
//             }
//         }

        

//         int GetMinDistanceIndex()
//         {
//             int minIndex = -1;
//             int minValue = int.MaxValue;
//             for (int i = 0; i < n; i++)
//             {
//                 if (distances[i] < minValue && !visited[i])
//                 {
//                     minIndex = i;
//                     minValue = distances[i];
//                 }
//             }

//             return minIndex;
//         }

        
//         return distances[dst];
//     }

// }

// public class Solution {
//     public int FindCheapestPrice(int n, int[][] flights, int src, int dst, int k) 
//     {
//         // Dictionary<int, (int end, int price)> paths = new();
//         int result = int.MaxValue;

//         int[,] paths = new int[n,n];
//         // bool[,] visited = new bool[n,n];
//         int[,] visited = new int[n,n];
        
//         for (int i = 0; i < flights.Length; i++)
//         {
//             paths[flights[i][0], flights[i][1]] = flights[i][2];
//         }

//         for (int i = 0; i < n; i++)
//         {
//             if (paths[src, i] != 0) 
//             { 
//                 result = Math.Min(Find(src, i, 0, -1), result);
//             }
//         }

//         int Find(int from, int to, int tempPrice, int steps)
//         {
//             int price = paths[from, to];
            
//             tempPrice += price;
//             steps++;
            
//             if (steps > k) { return 0; }
//             if (to == dst) { result = Math.Min(tempPrice, result); return tempPrice; }

//             for (int i = 0; i < n; i++)
//             {
//                 if (paths[to, i] != 0)
//                 {
//                     if (visited[to, i] != 0)
//                     {
//                         visited[from, to] = Math.Min(tempPrice + visited[to, i], visited[from,to]);
//                     }
//                     else
//                     {
//                         visited[from, to] = Math.Min(Find(to, i, tempPrice, steps), visited[from,to]);
//                     }
//                 }
//             }

//             return tempPrice + visited[from,to];
//         }

//         return result == int.MaxValue ? -1 : result;
//     }
// }


// public class Solution {
//     public int FindCheapestPrice(int n, int[][] flights, int src, int dst, int k) 
//     {
//         // Dictionary<int, (int end, int price)> paths = new();
//         int result = int.MaxValue;

//         int[,] paths = new int[n,n];
        
//         for (int i = 0; i < flights.Length; i++)
//         {
//             paths[flights[i][0], flights[i][1]] = flights[i][2];
//         }

//         for (int i = 0; i < n; i++)
//         {
//             Find(src, i, 0, -1);
//         }

//         void Find(int from, int to, int tempPrice, int stops)
//         {
//             int price = paths[from, to];
//             tempPrice += price;
//             stops++;
            
//             if (stops > k) { return; }
//             if (price == 0) { return; } // There is no way.
//             if (to == dst) { result = Math.Min(tempPrice, result); return; }

//             for (int i = 0; i < n; i++)
//             {
//                 Find(to, i, tempPrice, stops);
//             }
//         }

//         return result == int.MaxValue ? -1 : result;
//     }
// }

// public class Solution {
//     public int FindCheapestPrice(int n, int[][] flights, int src, int dst, int k) 
//     {
//         Dictionary<int, List<int[]>> paths = new();
//         int result = int.MaxValue;

//         for (int i = 0; i < flights.Length; i++)
//         {
//             if (!paths.ContainsKey(flights[i][0]))
//             {
//                 paths.Add(flights[i][0], new List<int[]>());
//             }
//             paths[flights[i][0]].Add(flights[i]);
//         }

//         Find(src, 0, -2); // Bc start and end doesnt count.

//         void Find(int from, int tempPrice, int stops)
//         {
//             stops++;

//             if (stops > k) { return; }
//             if (from == dst) { result = Math.Min(tempPrice, result); return; }
//             if (!paths.ContainsKey(from)) { return; }

//             foreach (var e in paths[from])
//             {
//                 Find(e[1], tempPrice + e[2], stops);
//             }
//         }

//         return result == int.MaxValue ? -1 : result;
//     }
// }