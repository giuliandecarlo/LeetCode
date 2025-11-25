public class Solution {
    public int LargestAltitude(int[] gain) {
        int currentAlt = 0;
        int maxAlt = 0;
        foreach(int el in gain)
        {
            currentAlt += el;
            if(currentAlt > maxAlt)
                maxAlt = currentAlt;
        }
        return maxAlt;
    }
}