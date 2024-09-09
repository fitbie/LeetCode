public class Solution {
    public int[][] SpiralMatrix(int m, int n, ListNode head)
    {
        int[][] matrix = new int[m][];
        for (int r = 0; r < m; r++)
        {
            matrix[r] = new int[n];
            for (int c = 0; c < n; c++)
            {
                matrix[r][c] = -1; // Initialize matrix with -1
            }
        }
        
        int row = 0;
        int col = -1;
        int minRow = 0;
        int minCol = 0;

        while (head != null)
        {
            while (FillRow(head.val, 1))
            {
                if (head.next != null)
                {
                    head = head.next;
                }
                else return matrix;
            }
            minRow++;

            while (FillColumn(head.val, 1))
            {
                if (head.next != null)
                {
                    head = head.next;
                }
                else return matrix;
            }
            n--;

            while (FillRow(head.val, -1))
            {
                if (head.next != null)
                {
                    head = head.next;
                }
                else return matrix;
            }
            m--;

            while (FillColumn(head.val, -1))
            {
                if (head.next != null)
                {
                    head = head.next;
                }
                else return matrix;
            }
            minCol++;
        }

        return matrix;


        bool FillRow(int val, int direction)
        {
            if (col + direction >= n || col + direction < minCol)
            {
                return false;
            }

            col += direction;
            matrix[row][col] = val;
            return true;
        }

        bool FillColumn(int val, int direction)
        {
            if (row + direction >= m || row + direction < minRow)
            {
                return false;
            }

            row += direction;
            matrix[row][col] = val;
            return true;
        }
    }
}


public class ListNode
{
    public int val;
    public ListNode next;
    public ListNode(int val = 0, ListNode next = null) {
        this.val = val;
        this.next = next;
    }
}