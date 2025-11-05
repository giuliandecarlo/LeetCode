public class Solution {
    public int Fib(int n) {
       return Fn(n);
    }
    public int Fn(int n){
        if(n <= 1) return n;
        return Fn(n-1) + Fn(n-2);
    }
}

public class Solution
{
    public int Fib(int n)
    {
        if(n <= 1) return n;
        int f_n0 = 0;
        int f_n1 = 1;
        for (int i = 0; i < n - 1; i++)
        {
            int temp = f_n0;
            f_n0 = f_n1;
            f_n1 = f_n0 + temp;
        }
        return f_n1;
    }
}