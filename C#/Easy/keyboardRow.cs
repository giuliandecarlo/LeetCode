public class Solution{
    public string[] FindWords(string[] words){
        string row1 = "qwertyuiop";
        string row2 = "asdfghjkl";
        string row3 = "zxcvbnm";
        List<string> result = new List<string>();

        foreach (string word in words)
        {
            string lower = word.ToLower();
            string row;

            if (row1.Contains(lower[0]))
                row = row1;
            else if (row2.Contains(lower[0]))
                row = row2;
            else
                row = row3;

            bool valid = true;
            foreach (char c in lower)
            {
                if (!row.Contains(c))
                {
                    valid = false;
                    break;
                }
            }

            if (valid)
                result.Add(word);
        }
        return result.ToArray();
    }
}