public class Solution {
    public int MinPartitions(string n) {
        int max = 0;
        
        foreach (char c in n) {
            int digit = c - '0';
            if (digit > max) {
                max = digit;
            }
        }
        
        return max;
    }
}