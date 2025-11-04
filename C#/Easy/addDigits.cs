public class Solution {
    public int AddDigits(int num) {
        if(num==0)
            return num;
        int n = num % 9;
        if(n == 0)
            return 9;
        else
            return n;
    }
}