Solution solution = new();
solution.NumIslands([['1','1','1'],['0','1','0'],['1','1','1']]);

public class Solution 
{
    public int NumIslands(char[][] grid) 
    {
        bool[,] visited = new bool[grid.Length, grid[0].Length];
        int islands = 0;

        for (int row = 0; row < grid.Length; row++)
        {
            for (int col = 0; col < grid[row].Length; col++)
            {
                if (grid[row][col] == '1' && !visited[row, col])
                {
                    FormIsland(row, col);
                    islands++;
                }
            }
        }


        void FormIsland(int row, int col)
        {
            if (row >= grid.Length || row < 0 || col >= grid[row].Length || col < 0 || 
                visited[row,col] || grid[row][col] != '1')
            {
                return;
            }

            visited[row, col] = true;
            FormIsland(row + 1, col);
            FormIsland(row - 1, col);
            FormIsland(row, col + 1);
            FormIsland(row, col - 1);
        }

        return islands;
    }
}