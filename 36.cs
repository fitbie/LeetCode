public class Solution {
    public bool IsValidSudoku(char[][] board)
    {   
        for (int row = 0; row < board.Length; row++)
        {
            for (int column = 0; column < board[row].Length; column++)
            {
                if (board[row][column] == '.') { continue; } // We don't need to check empty
                
                for (int y = row + 1; y < board.Length; y++) // Check column in every row
                {
                    if (board[y][column] == board[row][column]) { return false; }
                }

                for (int x = column+1; x < board[row].Length; x++) // Check row in every column
                {
                    if (board[row][column] == board[row][x]) { return false; }
                }

                for (int b = row - row % 3; b < (row - row % 3) + 3; b++) // Check every 3x3 section
                {
                    if (b == row) { continue; }
                    for (int a = column - column % 3; a < (column - column % 3) + 3; a++)
                    {
                        if (a == column) { continue; }
                        if (board[b][a] == board[row][column]) { return false; }
                    }
                }
            }
        }
        
        return true;
    }
}

