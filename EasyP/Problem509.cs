namespace LeetCode;

//       DONE                     Runtime 23ms | Memory 26.39MB
public class Solution {
    public int Fib(int n) {
        if (n == 1)
            return 1;
        int res= 0;
        int first = 0;
        int sec = 1;
        for (int a = n - 1; a > 0; a--){
            res = first + sec;
            first = sec;
            sec = res;
        }
        return res;
    }
}