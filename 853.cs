Solution solution = new();
solution.CarFleet(10, new int[] { 6, 8 }, new int[] { 3, 2 });


public class Solution 
{
    public int CarFleet(int target, int[] position, int[] speed)
    {
        if (position.Length == 1) { return 1; }

        int fleets = 0;
        Array.Sort(position, speed);

        Stack<float> times = new();

        for (int i = position.Length - 1; i >= 0; i--)
        {
            float time = Time(i);
            if (times.Count == 0) { times.Push(Time(i)); fleets++; continue; }

            if (Time(i) > times.Peek()) { times.Push(time); fleets++; continue; }
        }

        float Time(int index)
        {
            return (float)(target - position[index]) / speed[index];
        }

        return fleets;
    }
}







// public class Solution 
// {
//     public int CarFleet(int target, int[] position, int[] speed)
//     {
//         if (position.Length == 1) { return 1; }

//         int fleets = 0;
//         Array.Sort(position, speed);

//         for (int i = 0; i < position.Length - 1; )
//         {
//             var time = Time(i);

//             if (time <= Time(++i)) { fleets++; continue; }
//         }

//         int Time(int index)
//         {
//             return (target - position[index]) / speed[index];
//         }

//         return fleets;
//     }
// }