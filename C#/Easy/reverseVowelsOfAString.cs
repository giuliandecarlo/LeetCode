public class Solution {
    public string ReverseVowels(string s)
    {
        char[] vowels = { 'a','e','i','o','u','A','E','I','O','U' };
        char[] arr = s.ToCharArray();
        int left = 0;
        int right = arr.Length - 1;

        while (left < right)
        {
            if (!vowels.Contains(arr[left])) { left++; continue; }
            if (!vowels.Contains(arr[right])) { right--; continue; }

            var temp = arr[left];
            arr[left]  = arr[right];
            arr[right] = temp;
            left++;
            right--;
        }

        return new string(arr);
    }
}