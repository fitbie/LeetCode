public class Solution {
    public int PassThePillow(int n, int time) 
    {
        int passings = n - 1;
        bool forward = (time / passings) % 2 == 0;

        int lastPassing = time % passings;

        return forward ? 1 + lastPassing : n - lastPassing;
    }
}