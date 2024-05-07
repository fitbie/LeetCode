Solution solution = new();
solution.DoubleIt(new(5));

// This sucks, bc number / chars approach doesnt work bc of testcases. So use collections, meh.

public class Solution
{
    public ListNode DoubleIt(ListNode head)
    {
        Stack<int> number = new();

        for (ListNode currentNode = head; currentNode != null; currentNode = currentNode.next)
        {
            number.Push(currentNode.val);
        }

        List<int> multipliedNumber = new();
        int lefrover = 0;
        foreach(var digid in number)
        {
            int multiplied = digid * 2;
            multipliedNumber.Insert(0, (multiplied % 10) + lefrover);
            lefrover = multiplied / 10;
        }
        if (lefrover != 0) { multipliedNumber.Insert(0, lefrover); }

        ListNode node = head;
        for (int i = 0; i < multipliedNumber.Count; i++)
        {
            node.val = multipliedNumber[i];

            if (i < multipliedNumber.Count - 1)
            node.next ??= new();
            node = node.next;
        }

        return head;
    }
}


// public class Solution
// {
//     public ListNode DoubleIt(ListNode head)
//     {
//         long number = 0;

//         for (ListNode nextNode = head; nextNode != null; nextNode = nextNode.next)
//         {
//             number = number * 10 + nextNode.val;
//         }

//         number *= 2;
//         string numberStr = number.ToString();

//         ListNode node = head;
//         for (int i = 0; i < numberStr.Length; i++)
//         {
//             node.val = numberStr[i] - '0';

//             if (i < numberStr.Length - 1)
//             node.next ??= new();
//             node = node.next;
//         }

//         return head;
//     }
// }



// public class Solution
// {
//     public ListNode DoubleIt(ListNode head)
//     {
//         long number = 0;

//         for (ListNode nextNode = head; nextNode != null; nextNode = nextNode.next)
//         {
//             number = number * 10 + nextNode.val;
//         }

//         number *= 2;
//         int grades = number.ToString().Length - 1;

//         ListNode node = head;
//         while (grades >= 0)
//         {
//             int multiplier = (int)Math.Pow(10, grades);
//             int digid = (int)(number / multiplier);
//             node.val = digid;
//             grades--;
//             number -= digid * multiplier;

//             if (grades < 0) { break; }
//             node.next ??= new();
//             node = node.next;
//         }

//         return head;
//     }
// }


public class ListNode 
{
    public int val;
    public ListNode next;
    public ListNode(int val=0, ListNode next = null) 
    {
        this.val = val;
        this.next = next;
    }
}