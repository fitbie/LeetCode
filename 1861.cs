Solution solution = new();
solution.RotateTheBox([['#','.','*','.'],['#','#','*','.']]);


public class Solution
{
    public char[][] RotateTheBox(char[][] box)
    {
        // Define constants to make code easier to read.
        const char STONE = '#';       
        const char OBST = '*';       
        const char EMPTY = '.';

        for (int row = 0; row < box.Length; row++)
        {
            for (int col = box[row].Length - 1; col >= 0; col--)
            {
                if (box[row][col] == STONE)
                {
                    int tempCol = col; // Declare temporary column indexfor further incrementation.

                    // While next column isn't bottom or stone or obstacle, we move stone down by 1 cell and increment tempCol by 1.
                    while (tempCol < box[row].Length - 1 && box[row][tempCol + 1] != OBST && box[row][tempCol + 1] != STONE)
                    {
                        box[row][tempCol++] = EMPTY;
                        box[row][tempCol] = STONE;
                    }
                }
            }
        }       

        char[][] result = new char[box[0].Length][];

        for (int resRow = 0; resRow < result.Length; resRow++)
        {
            result[resRow] = new char[box.Length];
            for (int resCol = 0; resCol < box.Length; resCol++)
            {
                // We flip row and columns and - because we rotate by 90 degrees - our resulting row actually is !last! column.
                result[resRow][resCol] = box[box.Length - 1 - resCol][resRow];
            }
        }

        return result;
    }
}