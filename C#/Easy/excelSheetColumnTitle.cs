public class Solution {
    public string ConvertToTitle(int columnNumber) {
        string res = "";
        while(columnNumber > 0)
        {
            columnNumber -= 1;
            char c = (char) ('A' + columnNumber % 26);
            res = c + res;
            columnNumber /= 26;
        }
        return res;
    }
}