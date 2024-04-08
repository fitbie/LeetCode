Solution solution = new();
solution.CountStudents([1,1,1,0,0,1], [1,0,0,0,1,1]);

public class Solution {
    public int CountStudents(int[] students, int[] sandwiches)
    {
        // We could use dictionary, but ints are more lightweight.
        int san0 = 0;
        int san1 = 0;
        int stud0 = 0;
        int stud1 = 0;

        Queue<int> studentsQ = new();
        Stack<int> sandwichesS = new();
        int j = sandwiches.Length - 1; // For stacking.
        for (int i = 0; i < students.Length; i++, j--)
        {
            studentsQ.Enqueue(students[i]);
            if (students[i] == 0) { stud0++; }
            else { stud1++; }

            sandwichesS.Push(sandwiches[j]);
            if (sandwiches[j] == 0) { san0++; }
            else { san1++; }
        }
            
        while (sandwichesS.Count > 0)
        {
            int student = studentsQ.Dequeue();
            int sandwich = sandwichesS.Peek();

            // If there is no student that can take sandwich - break.
            if ((stud0 <= 0 && sandwich == 0) || (stud1 <= 0 && sandwich == 1)) { break; }

            if (student == sandwich) 
            { 
                if (student == 0) { stud0--; san0--; }
                else { stud1--; san1--; }
                sandwichesS.Pop();
            }
            else { studentsQ.Enqueue(student); }
        }

        return stud0 + stud1;
    }
}